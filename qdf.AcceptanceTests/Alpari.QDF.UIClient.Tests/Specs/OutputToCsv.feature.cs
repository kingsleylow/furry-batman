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
namespace Alpari.QDF.UIClient.Tests.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("OutputToCsv")]
    [NUnit.Framework.CategoryAttribute("ClientSideFiltering")]
    [NUnit.Framework.CategoryAttribute("TeardownRedisConnection")]
    public partial class OutputToCsvFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "OutputToCsv.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-GB"), "OutputToCsv", "In order to export deal data from Redis QDF\r\nAs a QDF Analyst\r\nI want to be able " +
                    "to save query results to CSV", ProgrammingLanguage.CSharp, new string[] {
                        "ClientSideFiltering",
                        "TeardownRedisConnection"});
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
        [NUnit.Framework.DescriptionAttribute("Output to CSV")]
        public virtual void OutputToCSV()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Output to CSV", ((string[])(null)));
#line 7
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Symbol",
                        "Servers",
                        "ConvertedStartTime",
                        "ConvertedEndTime"});
            table1.AddRow(new string[] {
                        "EURUSD,GBPUSD,AUDJPY",
                        "Currenex,Mt5Pro,Mt4JapaneseC1",
                        "05/05/2014  12:45:42",
                        "05/05/2014  12:49:51"});
#line 8
 testRunner.Given("I have the following search criteria for qdf deals", ((string)(null)), table1, "Given ");
#line 11
 testRunner.When("I retrieve the qdf deal data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
 testRunner.And("I export the data to \"C:\\temp\\temp.csv\" and import the csv", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Symbol",
                        "Count"});
            table2.AddRow(new string[] {
                        "EURUSD",
                        "16"});
            table2.AddRow(new string[] {
                        "GBPUSD",
                        "2"});
            table2.AddRow(new string[] {
                        "AUDJPY",
                        "1"});
#line 13
 testRunner.Then("the deals imported for each symbol will have the following counts", ((string)(null)), table2, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Server",
                        "Count"});
            table3.AddRow(new string[] {
                        "Mt4JapaneseC1",
                        "12"});
            table3.AddRow(new string[] {
                        "Currenex",
                        "5"});
            table3.AddRow(new string[] {
                        "Mt5Pro",
                        "2"});
#line 18
 testRunner.And("the deals imported for each server will have the following counts", ((string)(null)), table3, "And ");
#line 23
 testRunner.And("the count of imported deals will be 19", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Output ecn deals to CSV")]
        [NUnit.Framework.CategoryAttribute("UKUSQDF_71")]
        public virtual void OutputEcnDealsToCSV()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Output ecn deals to CSV", new string[] {
                        "UKUSQDF_71"});
#line 26
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "DealSource",
                        "Symbol",
                        "Servers",
                        "ConvertedStartTime",
                        "ConvertedEndTime"});
            table4.AddRow(new string[] {
                        "ecn-deals",
                        "EURUSD,GBPUSD,AUDJPY",
                        "Currenex,Mt5Pro,Mt4JapaneseC1",
                        "05/05/2014  12:45:42",
                        "05/05/2014  12:49:51"});
#line 27
 testRunner.Given("I have the following search criteria for qdf deals", ((string)(null)), table4, "Given ");
#line 30
 testRunner.When("I retrieve the qdf deal data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
 testRunner.And("I export the data to \"C:\\temp\\temp.csv\" and import the csv", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Symbol",
                        "Count"});
            table5.AddRow(new string[] {
                        "EURUSD",
                        "11"});
            table5.AddRow(new string[] {
                        "AUDJPY",
                        "1"});
#line 32
 testRunner.Then("the deals imported for each symbol will have the following counts", ((string)(null)), table5, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Server",
                        "Count"});
            table6.AddRow(new string[] {
                        "Mt4JapaneseC1",
                        "12"});
#line 36
 testRunner.And("the deals imported for each server will have the following counts", ((string)(null)), table6, "And ");
#line 39
 testRunner.And("the count of imported deals will be 12", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
