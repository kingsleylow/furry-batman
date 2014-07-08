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
namespace Alpari.QualityAssurance.Cnx2Redis.Tests.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("UKUSQDF-92 [AT] Cnx2Redis Data Collector - Data Reconciliation tests")]
    [NUnit.Framework.CategoryAttribute("UKUSQDF_92")]
    public partial class UKUSQDF_92ATCnx2RedisDataCollector_DataReconciliationTestsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "UKUSQDF-92 [AT] Cnx2Redis Data Collector - Data Reconciliation tests.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-GB"), "UKUSQDF-92 [AT] Cnx2Redis Data Collector - Data Reconciliation tests", "In order to test Cnx2Redis\r\nAs a QDF Tester\r\nI want to be able to compare data fr" +
                    "om MySql and Redis", ProgrammingLanguage.CSharp, new string[] {
                        "UKUSQDF_92"});
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
        [NUnit.Framework.DescriptionAttribute("Compare last day\'s data")]
        public virtual void CompareLastDaySData()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Compare last day\'s data", ((string[])(null)));
#line 7
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "DealSource",
                        "StartTime",
                        "EndTime",
                        "DealType"});
            table1.AddRow(new string[] {
                        "cnx-deals",
                        "-1D",
                        "+1D",
                        "BookLessDeal"});
#line 8
 testRunner.Given("I have the following search criteria for qdf deals", ((string)(null)), table1, "Given ");
#line 11
  testRunner.When("I retrieve the qdf deal data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
   testRunner.And("I query cnx trade by using the same deal search criteria", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
   testRunner.And("I compare the cnx trade deals with the qdf deal data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "ExportType",
                        "Overwrite"});
            table2.AddRow(new string[] {
                        "DataTableToCsv",
                        "true"});
#line 18
  testRunner.Then("the cnx trade deals should match the qdf deal data exactly:-", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Compare last 2 day\'s data")]
        public virtual void CompareLast2DaySData()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Compare last 2 day\'s data", ((string[])(null)));
#line 22
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "DealSource",
                        "StartTime",
                        "EndTime",
                        "DealType"});
            table3.AddRow(new string[] {
                        "cnx-deals",
                        "-2D",
                        "+2D",
                        "BookLessDeal"});
#line 23
 testRunner.Given("I have the following search criteria for qdf deals", ((string)(null)), table3, "Given ");
#line 26
  testRunner.When("I retrieve the qdf deal data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 27
   testRunner.And("I query cnx trade by using the same deal search criteria", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
   testRunner.And("I compare the cnx trade deals with the qdf deal data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "ExportType",
                        "Overwrite"});
            table4.AddRow(new string[] {
                        "DataTableToCsv",
                        "true"});
#line 33
  testRunner.Then("the cnx trade deals should match the qdf deal data exactly:-", ((string)(null)), table4, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Spot Test")]
        public virtual void SpotTest()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Spot Test", ((string[])(null)));
#line 37
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "DealSource",
                        "ConvertedStartTime",
                        "ConvertedEndTime",
                        "DealType"});
            table5.AddRow(new string[] {
                        "cnx-deals",
                        "07/07/2014  06:04:52",
                        "07/07/2014  06:04:53",
                        "BookLessDeal"});
#line 38
 testRunner.Given("I have the following search criteria for qdf deals", ((string)(null)), table5, "Given ");
#line 41
  testRunner.When("I retrieve the qdf deal data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 42
   testRunner.And("I query cnx trade by using the same deal search criteria", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
   testRunner.And("I compare the cnx trade deals with the qdf deal data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "ExportType",
                        "Overwrite"});
            table6.AddRow(new string[] {
                        "DataTableToCsv",
                        "true"});
#line 44
  testRunner.Then("the cnx trade deals should match the qdf deal data exactly:-", ((string)(null)), table6, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
