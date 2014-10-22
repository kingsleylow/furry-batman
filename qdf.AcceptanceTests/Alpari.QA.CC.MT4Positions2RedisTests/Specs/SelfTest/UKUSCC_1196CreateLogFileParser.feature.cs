﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18444
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Alpari.QA.CC.MT4Positions2RedisTests.Specs.SelfTest
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("UKUSCC_1196CreateLogFileParser")]
    [NUnit.Framework.CategoryAttribute("UKUSCC_1196")]
    public partial class UKUSCC_1196CreateLogFileParserFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "UKUSCC_1196CreateLogFileParser.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-GB"), "UKUSCC_1196CreateLogFileParser", "In order to interpret log files from the positions 2 Redis service\r\nAs a CC teste" +
                    "r\r\nI want to be able to parse the service log and interpret the results", ProgrammingLanguage.CSharp, new string[] {
                        "UKUSCC_1196"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Cleanse log file extract")]
        public virtual void CleanseLogFileExtract()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cleanse log file extract", ((string[])(null)));
#line 7
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "fileToParse",
                        "parseSyntax",
                        "OuterSyntaxDelimiter",
                        "InnerSyntaxDelimiter",
                        "outputfile"});
            table1.AddRow(new string[] {
                        "TestData\\LogFileTests\\Build56_Service_Log_extract.log",
                        "[,1,,0, ,^],1,,0, ,^ ,0,U_TRANS,2, ,",
                        "^",
                        ",",
                        "TestOutput\\output.csv"});
#line 8
 testRunner.Given("I have the following log file parser parameters:-", ((string)(null)), table1, "Given ");
#line 12
 testRunner.When("I parse the log file", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Parse log file extract")]
        public virtual void ParseLogFileExtract()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Parse log file extract", ((string[])(null)));
#line 14
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "fileToParse",
                        "parseSyntax",
                        "ColumnJoins",
                        "OuputDelimiter",
                        "OuterSyntaxDelimiter",
                        "InnerSyntaxDelimiter",
                        "outputfile"});
            table2.AddRow(new string[] {
                        "TestData\\LogFileTests\\Build56_Service_Log_extract.log",
                        "[,1,,0, ,^],1,,0, ,^ ,0,U_TRANS,2, ,",
                        "",
                        ",",
                        "^",
                        ",",
                        "output.csv"});
#line 15
 testRunner.Given("I have the following log file parser parameters:-", ((string)(null)), table2, "Given ");
#line 19
 testRunner.When("I parse the log file to memory", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
 testRunner.And("I write the parsed log file to disk", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Parse log extended file extract")]
        public virtual void ParseLogExtendedFileExtract()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Parse log extended file extract", ((string[])(null)));
#line 22
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "fileToParse",
                        "parseSyntax",
                        "ColumnJoins",
                        "OuputDelimiter",
                        "OuterSyntaxDelimiter",
                        "InnerSyntaxDelimiter",
                        "outputfile"});
            table3.AddRow(new string[] {
                        "TestData\\LogFileTests\\Build56_Service_Log_extract_extended.log",
                        "[,1,,0, ,^],1,,0, ,^ ,0,U_,2, ,",
                        "",
                        ",",
                        "^",
                        ",",
                        "output.csv"});
#line 23
 testRunner.Given("I have the following log file parser parameters:-", ((string)(null)), table3, "Given ");
#line 27
 testRunner.When("I parse the log file to memory", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
 testRunner.And("I write the parsed log file to disk", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Cleanse log file")]
        public virtual void CleanseLogFile()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cleanse log file", ((string[])(null)));
#line 30
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "fileToParse",
                        "parseSyntax",
                        "OuterSyntaxDelimiter",
                        "InnerSyntaxDelimiter",
                        "outputfile"});
            table4.AddRow(new string[] {
                        "C:\\TEMP\\LoadTestResults\\build58\\run002\\01InsertTrades\\MT4P2R_build58_10_10_144_25" +
                            "_443_2014-10-21.log",
                        "[,1,,0, ,^],1,,0, ,^ ,0,U_,2, ,",
                        "^",
                        ",",
                        "MT4P2R_build58_10_10_144_25_443_2014-10-21_parsed.log"});
#line 31
 testRunner.Given("I have the following log file parser parameters:-", ((string)(null)), table4, "Given ");
#line 35
 testRunner.When("I parse the log file", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
