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
    [NUnit.Framework.DescriptionAttribute("UKUSCC_1155_CompareCCPositionRedisToArs")]
    [NUnit.Framework.CategoryAttribute("CCDataContext")]
    [NUnit.Framework.CategoryAttribute("UKUSCC_1155")]
    public partial class UKUSCC_1155_CompareCCPositionRedisToArsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "UKUSCC_1155_CompareCCPositionRedisToArs.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "UKUSCC_1155_CompareCCPositionRedisToArs", "In order to compare position snapshots in different data sources\r\nAs a CC Tester\r" +
                    "\nI want to get positions from different cc ars and cc redis", ProgrammingLanguage.CSharp, new string[] {
                        "CCDataContext",
                        "UKUSCC_1155"});
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
        [NUnit.Framework.DescriptionAttribute("Get data for cc redis and cc ars for various symbols C1")]
        public virtual void GetDataForCcRedisAndCcArsForVariousSymbolsC1()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get data for cc redis and cc ars for various symbols C1", ((string[])(null)));
#line 13
this.ScenarioSetup(scenarioInfo);
#line 14
 testRunner.Given("I have a connection to CCDataContext", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "server1",
                        "server2",
                        "Database1",
                        "section",
                        "book",
                        "symbol",
                        "startTime",
                        "endTime"});
            table1.AddRow(new string[] {
                        "C1",
                        "C1 Red",
                        "cc_uat",
                        "default",
                        "A",
                        "EURUSD",
                        "2014/10/14 00:00:00",
                        "2014/10/15 14:20:00"});
            table1.AddRow(new string[] {
                        "C1",
                        "C1 Red",
                        "cc_uat",
                        "default",
                        "A",
                        "GBPUSD",
                        "2014/10/14 00:00:00",
                        "2014/10/15 14:20:00"});
            table1.AddRow(new string[] {
                        "C1",
                        "C1 Red",
                        "cc_uat",
                        "default",
                        "A",
                        "GBPJPY",
                        "2014/10/14 00:00:00",
                        "2014/10/15 14:20:00"});
            table1.AddRow(new string[] {
                        "C1",
                        "C1 Red",
                        "cc_uat",
                        "default",
                        "A",
                        "USDCHF",
                        "2014/10/14 00:00:00",
                        "2014/10/15 14:20:00"});
            table1.AddRow(new string[] {
                        "C1",
                        "C1 Red",
                        "cc_uat",
                        "default",
                        "A",
                        "EURCHF",
                        "2014/10/14 00:00:00",
                        "2014/10/15 14:20:00"});
            table1.AddRow(new string[] {
                        "C1",
                        "C1 Red",
                        "cc_uat",
                        "default",
                        "A",
                        "USDJPY",
                        "2014/10/14 00:00:00",
                        "2014/10/15 14:20:00"});
            table1.AddRow(new string[] {
                        "C1",
                        "C1 Red",
                        "cc_uat",
                        "default",
                        "B",
                        "EURUSD",
                        "2014/10/14 00:00:00",
                        "2014/10/15 14:20:00"});
            table1.AddRow(new string[] {
                        "C1",
                        "C1 Red",
                        "cc_uat",
                        "default",
                        "B",
                        "GBPUSD",
                        "2014/10/14 00:00:00",
                        "2014/10/15 14:20:00"});
            table1.AddRow(new string[] {
                        "C1",
                        "C1 Red",
                        "cc_uat",
                        "default",
                        "B",
                        "AUDCAD",
                        "2014/10/14 00:00:00",
                        "2014/10/15 14:20:00"});
            table1.AddRow(new string[] {
                        "C1",
                        "C1 Red",
                        "cc_uat",
                        "default",
                        "B",
                        "CL.X4",
                        "2014/10/14 00:00:00",
                        "2014/10/15 14:20:00"});
            table1.AddRow(new string[] {
                        "C1",
                        "C1 Red",
                        "cc_uat",
                        "default",
                        "B",
                        "XAUUSD",
                        "2014/10/14 00:00:00",
                        "2014/10/15 14:20:00"});
            table1.AddRow(new string[] {
                        "C1",
                        "C1 Red",
                        "cc_uat",
                        "default",
                        "B",
                        "XAGUSD",
                        "2014/10/14 00:00:00",
                        "2014/10/15 14:20:00"});
            table1.AddRow(new string[] {
                        "C1",
                        "C1 Red",
                        "cc_uat",
                        "default",
                        "B",
                        "USDJPY",
                        "2014/10/14 00:00:00",
                        "2014/10/15 14:20:00"});
#line 15
 testRunner.When("I get cc redis and cc ars position data for these sets of snapshot parameters:-", ((string)(null)), table1, "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get data for cc redis and cc ars for various symbols C2")]
        public virtual void GetDataForCcRedisAndCcArsForVariousSymbolsC2()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get data for cc redis and cc ars for various symbols C2", ((string[])(null)));
#line 31
this.ScenarioSetup(scenarioInfo);
#line 32
 testRunner.Given("I have a connection to CCDataContext", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "server1",
                        "server2",
                        "Database1",
                        "section",
                        "book",
                        "symbol",
                        "startTime",
                        "endTime"});
            table2.AddRow(new string[] {
                        "C2",
                        "C2 Red",
                        "cc_uat",
                        "UK",
                        "A",
                        "EURUSD",
                        "2014/10/14 00:00:00",
                        "2014/10/15 14:20:00"});
            table2.AddRow(new string[] {
                        "C2",
                        "C2 Red",
                        "cc_uat",
                        "UK",
                        "A",
                        "GBPUSD",
                        "2014/10/14 00:00:00",
                        "2014/10/15 14:20:00"});
            table2.AddRow(new string[] {
                        "C2",
                        "C2 Red",
                        "cc_uat",
                        "UK",
                        "A",
                        "GBPJPY",
                        "2014/10/14 00:00:00",
                        "2014/10/15 14:20:00"});
            table2.AddRow(new string[] {
                        "C2",
                        "C2 Red",
                        "cc_uat",
                        "UK",
                        "A",
                        "USDCHF",
                        "2014/10/14 00:00:00",
                        "2014/10/15 14:20:00"});
            table2.AddRow(new string[] {
                        "C2",
                        "C2 Red",
                        "cc_uat",
                        "UK",
                        "A",
                        "EURCHF",
                        "2014/10/14 00:00:00",
                        "2014/10/15 14:20:00"});
            table2.AddRow(new string[] {
                        "C2",
                        "C2 Red",
                        "cc_uat",
                        "UK",
                        "A",
                        "USDJPY",
                        "2014/10/14 00:00:00",
                        "2014/10/15 14:20:00"});
            table2.AddRow(new string[] {
                        "C2",
                        "C2 Red",
                        "cc_uat",
                        "UK",
                        "A",
                        "XAUUSD",
                        "2014/10/14 00:00:00",
                        "2014/10/15 14:20:00"});
            table2.AddRow(new string[] {
                        "C2",
                        "C2 Red",
                        "cc_uat",
                        "UK",
                        "A",
                        "XAGUSD",
                        "2014/10/14 00:00:00",
                        "2014/10/15 14:20:00"});
            table2.AddRow(new string[] {
                        "C2",
                        "C2 Red",
                        "cc_uat",
                        "UK",
                        "B",
                        "EURUSD",
                        "2014/10/14 00:00:00",
                        "2014/10/15 14:20:00"});
            table2.AddRow(new string[] {
                        "C2",
                        "C2 Red",
                        "cc_uat",
                        "UK",
                        "B",
                        "GBPUSD",
                        "2014/10/14 00:00:00",
                        "2014/10/15 14:20:00"});
            table2.AddRow(new string[] {
                        "C2",
                        "C2 Red",
                        "cc_uat",
                        "UK",
                        "B",
                        "GBPJPY",
                        "2014/10/14 00:00:00",
                        "2014/10/15 14:20:00"});
            table2.AddRow(new string[] {
                        "C2",
                        "C2 Red",
                        "cc_uat",
                        "UK",
                        "B",
                        "USDCHF",
                        "2014/10/14 00:00:00",
                        "2014/10/15 14:20:00"});
            table2.AddRow(new string[] {
                        "C2",
                        "C2 Red",
                        "cc_uat",
                        "UK",
                        "B",
                        "EURCHF",
                        "2014/10/14 00:00:00",
                        "2014/10/15 14:20:00"});
            table2.AddRow(new string[] {
                        "C2",
                        "C2 Red",
                        "cc_uat",
                        "UK",
                        "B",
                        "USDJPY",
                        "2014/10/14 00:00:00",
                        "2014/10/15 14:20:00"});
            table2.AddRow(new string[] {
                        "C2",
                        "C2 Red",
                        "cc_uat",
                        "UK",
                        "B",
                        "XAUUSD",
                        "2014/10/14 00:00:00",
                        "2014/10/15 14:20:00"});
            table2.AddRow(new string[] {
                        "C2",
                        "C2 Red",
                        "cc_uat",
                        "UK",
                        "B",
                        "XAGUSD",
                        "2014/10/14 00:00:00",
                        "2014/10/15 14:20:00"});
            table2.AddRow(new string[] {
                        "C2",
                        "C2 Red",
                        "cc_uat",
                        "UK",
                        "B",
                        "EUA.Z4",
                        "2014/10/14 00:00:00",
                        "2014/10/15 14:20:00"});
            table2.AddRow(new string[] {
                        "C2",
                        "C2 Red",
                        "cc_uat",
                        "UK",
                        "B",
                        "US30.Z",
                        "2014/10/14 00:00:00",
                        "2014/10/15 14:20:00"});
#line 33
 testRunner.When("I get cc redis and cc ars position data for these sets of snapshot parameters:-", ((string)(null)), table2, "When ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
