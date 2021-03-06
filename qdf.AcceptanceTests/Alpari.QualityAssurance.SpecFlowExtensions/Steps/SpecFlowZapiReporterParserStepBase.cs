﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Alpari.QualityAssurance.SpecFlowExtensions.NUnitReportParser;
using Alpari.QualityAssurance.SpecFlowExtensions.StepBases;
using TechTalk.SpecFlow;

namespace Alpari.QualityAssurance.SpecFlowExtensions.Steps
{
    public class SpecFlowZapiReporterParserStepBase : CrossStepDefinitionStepBase
    {
        /// <summary>
        ///     The key that will be used to set the NunitXmlParser in the Scenario Context
        ///     TODO:- Get these strings from Reflection!
        /// </summary>
        public static readonly string NunitXmlParserFullyQualifiedName =
            "Alpari.QualityAssurance.SpecFlowExtensions.NUnitReportParser.NunitXmlParser";

        public static void SetNunitXmlParser(string fileNamePath)
        {
            var nunitXmlParser = new NunitXmlParser(fileNamePath, FileMode.Open);
            // var nunitXmlParser = new NunitXmlParser(fileNamePath,true, FileMode.Open);
            //ScenarioContext.Current[nunitXmlParser.ToString()] = nunitXmlParser;
            ScenarioContext.Current[NunitXmlParserFullyQualifiedName] = nunitXmlParser;
        }

        /// <summary>
        ///     Get the default xml parser
        /// </summary>
        /// <returns></returns>
        public static NunitXmlParser GetNunitXmlParser()
        {
            return (NunitXmlParser) ScenarioContext.Current[NunitXmlParserFullyQualifiedName];
        }

        public static IDictionary<string, object> GetTestResultsDictionary(NunitXmlParser nunitXmlParser)
        {
            Type testResultsType = nunitXmlParser.TestResults.GetType();
            IDictionary<string, object> testResultsDictionary =
                DataTableOperations.GetObjectPropertiesAsDictionary(nunitXmlParser.TestResults, testResultsType);
            return testResultsDictionary;
        }

        public static IDictionary<string, object> GetHostTestEnvironmentDictionary(NunitXmlParser nunitXmlParser)
        {
            Type hostTestEnvironmentType = nunitXmlParser.HostTestEnvironment.GetType();
            IDictionary<string, object> hostTestEnvironmentDictionary =
                DataTableOperations.GetObjectPropertiesAsDictionary(nunitXmlParser.HostTestEnvironment,
                    hostTestEnvironmentType);
            return hostTestEnvironmentDictionary;
        }

        public static IDictionary<string, object> GetCultureInfoDictionary(NunitXmlParser nunitXmlParser)
        {
            Type cultureinfoType = nunitXmlParser.CultureinfoType.GetType();
            IDictionary<string, object> cultureinfoTypeDictionary =
                DataTableOperations.GetObjectPropertiesAsDictionary(nunitXmlParser.CultureinfoType, cultureinfoType);
            return cultureinfoTypeDictionary;
        }

        /// <summary>
        ///     TODO:- investigate using Generics , type arguments, and Linq to reduce number of methods needed to do these
        ///     transformations
        /// </summary>
        /// <param name="testSuiteTypeCollection"></param>
        /// <returns></returns>
        public IList<Dictionary<string, object>> GetTestSuiteCollectionAsListOfTestSuiteDictionaries(
            List<TestsuiteType> testSuiteTypeCollection)
        {
            Type testSuiteType = testSuiteTypeCollection[0].GetType();
            return
                testSuiteTypeCollection.Select(
                    testSuiteTypeCollectionItem =>
                        DataTableOperations.GetObjectPropertiesAsDictionary(testSuiteTypeCollectionItem, testSuiteType))
                    .Select(cultureinfoTypeDictionary => cultureinfoTypeDictionary)
                    .Cast<Dictionary<string, object>>()
                    .ToList();
        }

        public IList<Dictionary<string, object>> SaveTestSuiteCollectionAsListOfDictionaries()
        {
            NunitXmlParser nunitXmlParser = GetNunitXmlParser();
            List<TestsuiteType> testSuiteTypeCollection = nunitXmlParser.TestSuiteTypeCollection;
            IList<Dictionary<string, object>> testSuiteCollectionAsListOfTestSuiteDictionaries =
                GetTestSuiteCollectionAsListOfTestSuiteDictionaries(testSuiteTypeCollection);
            ScenarioContext.Current[testSuiteCollectionAsListOfTestSuiteDictionaries.ToString()] =
                testSuiteCollectionAsListOfTestSuiteDictionaries;
            return testSuiteCollectionAsListOfTestSuiteDictionaries;
        }

        public static ExpectedAndActualTestCasesBySuiteAsIlIsts GetExpectedAndActualTestCasesBySuiteAsILists(
            Table testCasesInTestSuites)
        {
            var expectedAndActualTestCases = new ExpectedAndActualTestCasesBySuiteAsIlIsts
            {
                Expected = DataTableOperations.GetTableAsList(testCasesInTestSuites),
                Actual = GetNunitXmlParser().GetTestCasesByTestSuiteAsList()
            };
            return expectedAndActualTestCases;
        }
    }

    public class ExpectedAndActualTestCasesBySuiteAsIlIsts : ExpectedAndActualIDictionariesAsIlIsts
    {
    }
}