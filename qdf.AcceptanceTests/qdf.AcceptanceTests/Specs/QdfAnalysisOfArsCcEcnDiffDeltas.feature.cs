﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18063
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace qdf.AcceptanceTests.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("QdfAnalysisOfArsCcEcnDiffDeltas")]
    public partial class QdfAnalysisOfArsCcEcnDiffDeltasFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "QdfAnalysisOfArsCcEcnDiffDeltas.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "QdfAnalysisOfArsCcEcnDiffDeltas", "In order to reconcile Qdf Data\r\nAs a tester\r\nI want to be able to find the bigges" +
                    "t differences in the data streams", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Analyse diff deltas in B Book GBPUSD Mt4Pro")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void AnalyseDiffDeltasInBBookGBPUSDMt4Pro()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Analyse diff deltas in B Book GBPUSD Mt4Pro", new string[] {
                        "mytag"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Book",
                        "Instrument",
                        "Server",
                        "StartDate",
                        "EndDate",
                        "NumberOfDiffs"});
            table1.AddRow(new string[] {
                        "B",
                        "GBPUSD",
                        "Mt4Pro",
                        "03/02/2014",
                        "09/03/2014",
                        "10"});
#line 8
 testRunner.Given("I want to analyse diff deltas by timeslice in", ((string)(null)), table1, "Given ");
#line 11
 testRunner.When("I analyse the diff deltas by timeslice", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
 testRunner.Then("The diff delta analysis is output to \"csv\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 13
 testRunner.And("no diff delta is greater than 10 percent of the mean position for the timeslice", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion