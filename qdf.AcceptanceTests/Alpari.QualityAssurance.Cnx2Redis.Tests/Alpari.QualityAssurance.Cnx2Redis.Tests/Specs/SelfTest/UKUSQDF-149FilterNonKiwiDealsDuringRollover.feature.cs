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
namespace Alpari.QualityAssurance.Cnx2Redis.Tests.Specs.SelfTest
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("UKUSQDF-149FilterNonKiwiDealsDuringRollover")]
    [NUnit.Framework.CategoryAttribute("UKUSQDF_149")]
    [NUnit.Framework.CategoryAttribute("UKUSQDF_150")]
    [NUnit.Framework.CategoryAttribute("redisLocalhost")]
    [NUnit.Framework.CategoryAttribute("RedisDataImportParams:deal:cnx_deals:TestData\\UKUSQDF-149cnx-deals.csv")]
    [NUnit.Framework.CategoryAttribute("cnxHubTradeActivityImporter:Csv")]
    public partial class UKUSQDF_149FilterNonKiwiDealsDuringRolloverFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "UKUSQDF-149FilterNonKiwiDealsDuringRollover.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-GB"), "UKUSQDF-149FilterNonKiwiDealsDuringRollover", @"In order to get the correct deals for comparison between cnx-deals and cnx hub admin
As a QDF Tester
I want to filter non NZD deals during the rollover period

In order to test outlying deals on the cnx hub admin report
As a QDF Tester
I want to search for deals in redis using the deal ids from the cnx hub report", ProgrammingLanguage.CSharp, new string[] {
                        "UKUSQDF_149",
                        "UKUSQDF_150",
                        "redisLocalhost",
                        "RedisDataImportParams:deal:cnx_deals:TestData\\UKUSQDF-149cnx-deals.csv",
                        "cnxHubTradeActivityImporter:Csv"});
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
        [NUnit.Framework.DescriptionAttribute("Filter non kiwi deals during rollover")]
        public virtual void FilterNonKiwiDealsDuringRollover()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Filter non kiwi deals during rollover", ((string[])(null)));
#line 11
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "DealSource"});
            table1.AddRow(new string[] {
                        "cnx-deals"});
#line 12
 testRunner.Given("I have the following search criteria for qdf deals", ((string)(null)), table1, "Given ");
#line 15
 testRunner.When("I load cnx trade activities from \"TestData\\UKUSQDF-149CnxHubData.csv\" for the inc" +
                    "luded logins", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
  testRunner.And("I retrieve the qdf deal data filtered by cnx hub start and end times and by inclu" +
                    "ded logins", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
 testRunner.Then("the count of loaded cnx trade activities is 6", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 18
 testRunner.And("the count of retrieved deals will be 5", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
