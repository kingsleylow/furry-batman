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
namespace Alpari.QA.CC.UI.Tests.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("UKUSCC-1310ComparePositionsTableComparisons")]
    [NUnit.Framework.CategoryAttribute("UKUSCC_1310")]
    public partial class UKUSCC_1310ComparePositionsTableComparisonsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "UKUSCC-1310ComparePositionsTableComparisons.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-GB"), "UKUSCC-1310ComparePositionsTableComparisons", "In order to check the CC UI is displaying the correct data\r\nas a tester\r\nI want t" +
                    "o compare the positions table in different CC environments", ProgrammingLanguage.CSharp, new string[] {
                        "UKUSCC_1310"});
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
        [NUnit.Framework.DescriptionAttribute("Compare new and old servers current position")]
        [NUnit.Framework.CategoryAttribute("ICcPositionTableComparison")]
        public virtual void CompareNewAndOldServersCurrentPosition()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Compare new and old servers current position", new string[] {
                        "ICcPositionTableComparison"});
#line 9
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "CcCurrent",
                        "CcNew",
                        "CcCurrentVersion",
                        "CcNewVersion"});
            table1.AddRow(new string[] {
                        "cc_prod",
                        "cc_new",
                        "4.5",
                        "4.6"});
#line 10
 testRunner.Given("I have the following cc comparison parameters:-", ((string)(null)), table1, "Given ");
#line 13
 testRunner.When("I compare the current positions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "ExportType",
                        "Overwrite"});
            table2.AddRow(new string[] {
                        "DataTableToCsv",
                        "true"});
#line 14
 testRunner.Then("the current positions should match exactly:-", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Monitor new and old servers position")]
        [NUnit.Framework.CategoryAttribute("ICcPositionTableComparison")]
        public virtual void MonitorNewAndOldServersPosition()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Monitor new and old servers position", new string[] {
                        "ICcPositionTableComparison"});
#line 20
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "CcCurrent",
                        "CcNew",
                        "MonitorFor",
                        "MonitorEvery",
                        "CcCurrentVersion",
                        "CcNewVersion"});
            table3.AddRow(new string[] {
                        "cc_prod",
                        "cc_new",
                        "1MIN",
                        "10SEC",
                        "4.5",
                        "4.6"});
#line 21
 testRunner.Given("I have the following cc comparison parameters:-", ((string)(null)), table3, "Given ");
#line 24
 testRunner.When("I monitor the current positions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Monitor new and old servers position longer test")]
        [NUnit.Framework.CategoryAttribute("ICcPositionTableComparison")]
        public virtual void MonitorNewAndOldServersPositionLongerTest()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Monitor new and old servers position longer test", new string[] {
                        "ICcPositionTableComparison"});
#line 28
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "CcCurrent",
                        "CcNew",
                        "MonitorFor",
                        "MonitorEvery",
                        "CcCurrentVersion",
                        "CcNewVersion"});
            table4.AddRow(new string[] {
                        "cc_prod",
                        "cc_new",
                        "1HR",
                        "1MIN",
                        "4.5",
                        "4.6"});
#line 29
 testRunner.Given("I have the following cc comparison parameters:-", ((string)(null)), table4, "Given ");
#line 32
 testRunner.When("I monitor the current positions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Monitor new and old servers position A And B")]
        [NUnit.Framework.CategoryAttribute("ICcPositionTableComparisons")]
        public virtual void MonitorNewAndOldServersPositionAAndB()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Monitor new and old servers position A And B", new string[] {
                        "ICcPositionTableComparisons"});
#line 35
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "CcCurrent",
                        "CcNew",
                        "MonitorFor",
                        "MonitorEvery",
                        "CcCurrentVersion",
                        "CcNewVersion",
                        "Book",
                        "Select"});
            table5.AddRow(new string[] {
                        "cc_prod",
                        "cc_new",
                        "1MIN",
                        "10SEC",
                        "4.5",
                        "4.6",
                        "A",
                        "All"});
            table5.AddRow(new string[] {
                        "cc_prod",
                        "cc_new",
                        "1MIN",
                        "10SEC",
                        "4.5",
                        "4.6",
                        "B",
                        "All"});
#line 36
 testRunner.Given("I have the following cc comparison parameter sets:-", ((string)(null)), table5, "Given ");
#line 40
 testRunner.When("I monitor the current positions in parallel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Monitor new and old servers position A And B Longer Test")]
        [NUnit.Framework.CategoryAttribute("ICcPositionTableComparisons")]
        public virtual void MonitorNewAndOldServersPositionAAndBLongerTest()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Monitor new and old servers position A And B Longer Test", new string[] {
                        "ICcPositionTableComparisons"});
#line 43
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "CcCurrent",
                        "CcNew",
                        "MonitorFor",
                        "MonitorEvery",
                        "CcCurrentVersion",
                        "CcNewVersion",
                        "Book"});
            table6.AddRow(new string[] {
                        "cc_prod",
                        "cc_new",
                        "1HR",
                        "10SEC",
                        "4.5",
                        "4.6",
                        "A"});
            table6.AddRow(new string[] {
                        "cc_prod",
                        "cc_new",
                        "1HR",
                        "10SEC",
                        "4.5",
                        "4.6",
                        "B"});
#line 44
 testRunner.Given("I have the following cc comparison parameter sets:-", ((string)(null)), table6, "Given ");
#line 48
 testRunner.When("I monitor the current positions in parallel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
