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
    [NUnit.Framework.DescriptionAttribute("UKUSQDF-136 [AT] LoadDataFromCsv")]
    [NUnit.Framework.CategoryAttribute("UKUSQDF_136")]
    [NUnit.Framework.CategoryAttribute("cnxHubTradeActivityImporter:Csv")]
    public partial class UKUSQDF_136ATLoadDataFromCsvFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "UKUSQDF-136 [AT] LoadDataFromCsv.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-GB"), "UKUSQDF-136 [AT] LoadDataFromCsv", "In order to test Redis cnx-deals agains cnx-hub\r\nAs a QDF Tester\r\nI want to be ab" +
                    "le to load selected deals from cnx hub csv", ProgrammingLanguage.CSharp, new string[] {
                        "UKUSQDF_136",
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
        
        public virtual void FeatureBackground()
        {
#line 7
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Login",
                        "Name"});
            table1.AddRow(new string[] {
                        "AUKUS2102",
                        "Lucror"});
            table1.AddRow(new string[] {
                        "AUKUS2089",
                        "Chase Capital"});
            table1.AddRow(new string[] {
                        "AUKUS2065",
                        "Leverate Financial"});
            table1.AddRow(new string[] {
                        "AUKUS2095",
                        "TradingServices"});
            table1.AddRow(new string[] {
                        "AUKUS2099",
                        "BostonPrime"});
            table1.AddRow(new string[] {
                        "AUKUS2106",
                        "Gedik"});
            table1.AddRow(new string[] {
                        "AUKUS2033",
                        "Forex Financial"});
            table1.AddRow(new string[] {
                        "AUKUS1004",
                        "Royal Forex Trading"});
            table1.AddRow(new string[] {
                        "AUKP2962",
                        "Accurate Investment"});
            table1.AddRow(new string[] {
                        "AUKUS2026",
                        "TTCM Traders Trust"});
            table1.AddRow(new string[] {
                        "AUKP3064",
                        "Fidus SAL"});
            table1.AddRow(new string[] {
                        "AUKP2848",
                        "Aganex"});
            table1.AddRow(new string[] {
                        "AUKUS2078",
                        "Scope"});
            table1.AddRow(new string[] {
                        "AUKP3156",
                        "Gerhardus"});
            table1.AddRow(new string[] {
                        "AUKP3399",
                        "Atef Abdulrahman Mohammed AlNuwaiser"});
            table1.AddRow(new string[] {
                        "AUKP3038",
                        "Arab International"});
            table1.AddRow(new string[] {
                        "AUKP1050",
                        "Bailey"});
            table1.AddRow(new string[] {
                        "AUKP3233",
                        "Mohammad Najmudeen"});
            table1.AddRow(new string[] {
                        "AUKP2193",
                        "Uros Frantar"});
            table1.AddRow(new string[] {
                        "AUKP3216",
                        "Javier Timerman"});
#line 8
testRunner.Given("I have this list of takers to load from cnx hub", ((string)(null)), table1, "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Load specified logins")]
        public virtual void LoadSpecifiedLogins()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Load specified logins", ((string[])(null)));
#line 31
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 32
 testRunner.Then("the list of included logins contains 20 logins", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Load Cnx Hub Data")]
        public virtual void LoadCnxHubData()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Load Cnx Hub Data", ((string[])(null)));
#line 34
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 35
 testRunner.When("I load cnx trade activities from \"TestData\\TradeActivitiesForAllAccountsFrom07-08" +
                    "-2014To07-08-2014.csv\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
 testRunner.Then("the count of loaded cnx trade activities is 2460", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Load Cnx Hub Data for specified logins")]
        public virtual void LoadCnxHubDataForSpecifiedLogins()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Load Cnx Hub Data for specified logins", ((string[])(null)));
#line 38
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 39
 testRunner.When("I load cnx trade activities from \"TestData\\TradeActivitiesForAllAccountsFrom07-08" +
                    "-2014To07-08-2014.csv\" for the selected logins", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
 testRunner.Then("the count of loaded cnx trade activities is 2421", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Load Cnx Hub Data for specified logins and check dates")]
        public virtual void LoadCnxHubDataForSpecifiedLoginsAndCheckDates()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Load Cnx Hub Data for specified logins and check dates", ((string[])(null)));
#line 42
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 43
 testRunner.When("I load cnx trade activities from \"TestData\\TradeActivitiesForAllAccountsFrom07-08" +
                    "-2014To07-08-2014.csv\" for the selected logins", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 44
 testRunner.Then("the earliest cnx trade activity is \"07/07/2014  19:13:00\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 45
 testRunner.And("the latest cnx trade activity is \"08/07/2014  20:56:00\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
