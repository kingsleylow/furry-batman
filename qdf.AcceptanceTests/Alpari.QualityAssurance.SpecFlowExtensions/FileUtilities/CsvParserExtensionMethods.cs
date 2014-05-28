﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Alpari.QualityAssurance.SpecFlowExtensions.LoggingUtilities;
using Alpari.QualityAssurance.SpecFlowExtensions.TypeUtilities;
using Microsoft.VisualBasic.FileIO;
using SearchOption = System.IO.SearchOption;

namespace Alpari.QualityAssurance.SpecFlowExtensions.FileUtilities
{
    public static class CsvParserExtensionMethods
    {
// ReSharper disable once InconsistentNaming
        public static readonly string csv = "csv";

        public static string EscapeCommasIfInEscapeList(this string val, int[] columnsToEscape,
            KeyValuePair<string, int> column)
        {
            if (columnsToEscape.Contains(column.Value))
            {
                val = CsvParser.StringToCsvCell(val);
            }
            return val;
        }

        public static List<string> GetValuesFromCsvRow(this string row, string delimiter)
        {
            using (var sr = new StringReader(row))
            {
                var parser = new TextFieldParser(sr);
                parser.SetDelimiters(delimiter);
                // ReSharper disable once AssignNullToNotNullAttribute
                return parser.ReadFields().Select(x => x.Trim()).ToList();
            }
        }

        public static int GetColumnIndex(this IList<string> columnNames, string columnName)
        {
            return columnNames.IndexOf(columnName);
        }

        public static List<T> CsvToList<T>(this string fileNamePath, string delimiter) where T : new()
        {
            Dictionary<string, int> columnMap;
            List<T> parsedFile;
            long line;
            Type type;
            IEnumerable<string> unparsedFile = ReadFileAndSetupList(fileNamePath, delimiter, out columnMap,
                out parsedFile, out line, out type);
            CreateObjectsInList(fileNamePath, delimiter, unparsedFile, type, columnMap, line, parsedFile, null);
            return parsedFile;
        }

        public static List<T> CsvToList<T>(this string fileNamePath, string delimiter, string[] ignoreProps)
            where T : new()
        {
            Dictionary<string, int> columnMap;
            List<T> parsedFile;
            long line;
            Type type;
            IEnumerable<string> unparsedFile = ReadFileAndSetupList(fileNamePath, delimiter, out columnMap,
                out parsedFile, out line, out type);
            CreateObjectsInList(fileNamePath, delimiter, unparsedFile, type, columnMap, line, parsedFile, ignoreProps);
            return parsedFile;
        }

        /// <summary>
        ///     removes characters from a string which might cause Windows a problem when creationg files/directories
        /// </summary>
        /// <param name="stringToCleanse"></param>
        /// <returns></returns>
        public static string RemoveWindowsUnfriendlyChars(this object stringToCleanse)
        {
            string cleansedString =
                stringToCleanse.ToString()
                    .Replace(" ", "")
                    .Replace(@"\", "")
                    .Replace(@"/", "")
                    .Replace(@"(", "")
                    .Replace(@")", "")
                    .Replace("-", "");
            return cleansedString;
        }

        /// <summary>
        /// Load files from the exe / dll directory or subdirectory matching a simple pattern (including the file extension)
        /// and return a dictionary of lists of the specified type of data that is expected to be in those files
        /// </summary>
        /// <typeparam name="T">the type of data expected to be in the file, and also of the type that the list should contain</typeparam>
        /// <param name="dictionary"> dicitionary to add the lists to. the key is the matched filename</param>
        /// <param name="filePattern">the pattern to use to select the files to load, e.g. "People.csv" will load files "MyPeople.csv" and "NewPeople.csv"</param>
        public static void LoadFilesToDictionary<T>(this Dictionary<string, List<T>> dictionary, string filePattern) where T : new()
        {
            var codeBase = Assembly.GetExecutingAssembly().GetName().CodeBase;
            if (codeBase != null)
            {
                var path = Path.GetDirectoryName(codeBase);
                if (path != null)
                {
                    var directoryInfo = new DirectoryInfo(new Uri(path).LocalPath);
                    var fileList = directoryInfo.GetFiles(String.Format("*{0}", filePattern), SearchOption.AllDirectories);
                    foreach (var fileInfo in fileList)
                    {
                        dictionary.Add
                            (fileInfo.Name,
                            fileInfo.FullName.CsvToList<T>(","));
                    }
                }
                else
                {
                    throw new FileLoadException(codeBase);
                }
            }
            else
            {
                throw new FileLoadException();
            }
        }

        private static IEnumerable<string> ReadFileAndSetupList<T>(string fileNamePath, string delimiter,
            out Dictionary<string, int> columnMap,
            out List<T> parsedFile, out long line, out Type type) where T : new()
        {
            string[] unparsedFile = File.ReadAllLines(fileNamePath);
            IList<string> headers = unparsedFile.First().GetValuesFromCsvRow(delimiter);
            columnMap = headers.ToDictionary(header => header, headers.GetColumnIndex);
            parsedFile = new List<T>();
            line = 1;
            Type getType;
            try
            {
                getType = Type.GetType(typeof (T).FullName, true);
            }
            catch (Exception e)
            {
                string assemblyQualifiedName = typeof (T).AssemblyQualifiedName;

                if (assemblyQualifiedName != null)
                {
                    getType = Type.GetType(assemblyQualifiedName, true);
                }
                else
                {
                    throw new Exception("could not resolve a fully qualifed name for T ", e);
                }
            }
            type = getType;
            return unparsedFile;
        }

        private static void CreateObjectsInList<T>(string fileNamePath, string delimiter,
            IEnumerable<string> unparsedFile, Type type, Dictionary<string, int> columnMap, long line,
            List<T> parsedFile, string[] ignoreProps) where T : new()
        {
            foreach (string s in unparsedFile.Skip(1))
            {
                T newT = default(T);
                try
                {
                    try
                    {
                        IList<string> row = s.GetValuesFromCsvRow(delimiter);
                        var instance = (T) Activator.CreateInstance(type);
                        foreach (var pair in columnMap)
                        {
                            if (ignoreProps == null || ignoreProps != null && !ignoreProps.Contains(pair.Key))
                            {
                                try
                                {
                                    PropertyInfo prop = type.GetProperty(pair.Key);
                                    if (prop.PropertyType.BaseType.Name == "Enum")
                                    {
                                        Type enumProp = type.GetProperty(pair.Key).PropertyType;
                                        object value = Enum.Parse(enumProp, row[columnMap[pair.Key]]);
                                        instance.SetValue(prop, value);                                        
                                    }
                                    else
                                    {
                                        instance.SetValue(prop, row[columnMap[pair.Key]]);
                                    }
                                }
                                catch (Exception e)
                                {
                                    e.ConsoleExceptionLogger(
                                        String.Format(
                                            "unable to get value for property {0} in line {1}. values = {2}. filename = {3}",
                                            pair.Key, line, s, fileNamePath));
                                }
                            }
                        }
                        newT = instance;
                    }
                    catch (Exception e)
                    {
                        e.ConsoleExceptionLogger(
                            String.Format("unable to get values for line {0}. values = {1} , file = {2}", line, s,
                                fileNamePath));
                    }
                }
                catch (Exception e)
                {
                    e.ConsoleExceptionLogger(String.Format("unable to get values for a line,  , file = {0}",
                        fileNamePath));
                }
                parsedFile.Add(newT);
                line++;
            }
        }
    }
}