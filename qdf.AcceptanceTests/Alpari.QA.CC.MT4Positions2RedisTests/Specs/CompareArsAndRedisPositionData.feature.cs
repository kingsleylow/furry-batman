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
namespace Alpari.QA.CC.MT4Positions2RedisTests.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("CompareArsAndRedisPositionData")]
    [NUnit.Framework.CategoryAttribute("Mt4ArsPositionsContext")]
    public partial class CompareArsAndRedisPositionDataFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CompareArsAndRedisPositionData.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-GB"), "CompareArsAndRedisPositionData", "In order to test redis positions\r\nAs a CC Tester\r\nI want to be able to compare re" +
                    "dis positions with Ars Positions", ProgrammingLanguage.CSharp, new string[] {
                        "Mt4ArsPositionsContext"});
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
        
        public virtual void FeatureBackground()
        {
#line 9
#line 10
 testRunner.Given("I have a connection to a redis repository on \"uk-redis-dev.corp.alpari.com\" port " +
                    "6379 db 0 namespace \"alpari-positions\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 11
 testRunner.And("I have a connection to Mt4ArsPositionsContext", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.When("I get all positions for server \"ProTest\" opened from \'2014/09/02 00:00:00\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
 testRunner.And("I query for open positions after \"2014-09-02\" on \"ars_test_AUKP01\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get open positions")]
        public virtual void GetOpenPositions()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get open positions", ((string[])(null)));
#line 18
this.ScenarioSetup(scenarioInfo);
#line 9
this.FeatureBackground();
#line 19
 testRunner.Then("at least 1 position is for login 111196738", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 20
 testRunner.And("at least 1 position is returned for login \"7003713\" on \"ars_test_AUKP01\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Compare open positions")]
        public virtual void CompareOpenPositions()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Compare open positions", ((string[])(null)));
#line 22
this.ScenarioSetup(scenarioInfo);
#line 9
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "ExcludedFields"});
            table1.AddRow(new string[] {
                        "Timestamp"});
            table1.AddRow(new string[] {
                        "OpenTime"});
            table1.AddRow(new string[] {
                        "Server"});
#line 23
 testRunner.When("I compare the \"ProTest\" positions with the \"ars_test_AUKP01\" positions excluding " +
                    "these fields:", ((string)(null)), table1, "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "ExportType",
                        "Overwrite"});
            table2.AddRow(new string[] {
                        "DataTableToCsv",
                        "true"});
#line 28
 testRunner.Then("the redis positions should match the ars positions exactly:-", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
