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
    [NUnit.Framework.DescriptionAttribute("UKUSCC_1171_CombineManagerApiAndTradeExeToInsertAndDetectTradesLoadedFromFile")]
    [NUnit.Framework.CategoryAttribute("Mt4ArsPositionsContext")]
    [NUnit.Framework.CategoryAttribute("UKUSCC_1171")]
    public partial class UKUSCC_1171_CombineManagerApiAndTradeExeToInsertAndDetectTradesLoadedFromFileFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "UKUSCC_1171_CombineManagerApiAndTradeExeToInsertAndDetectTrades.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-GB"), "UKUSCC_1171_CombineManagerApiAndTradeExeToInsertAndDetectTradesLoadedFromFile", "In order to bulk load trades into MT4\r\nAs a CC tester\r\nI want to enter trades and" +
                    " sync on insert finishing", ProgrammingLanguage.CSharp, new string[] {
                        "Mt4ArsPositionsContext",
                        "UKUSCC_1171"});
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
                        "server",
                        "login",
                        "password"});
            table1.AddRow(new string[] {
                        "10.10.144.25:443",
                        "95",
                        "1q2w3e"});
#line 8
 testRunner.Given("I have the following connection parameters for the Mt4CompositeApi:-", ((string)(null)), table1, "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("BackupScenario - old load test format should still work")]
        public virtual void BackupScenario_OldLoadTestFormatShouldStillWork()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("BackupScenario - old load test format should still work", ((string[])(null)));
#line 17
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "login",
                        "tradeInstruction",
                        "quantity"});
            table2.AddRow(new string[] {
                        "1000000001",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "100"});
            table2.AddRow(new string[] {
                        "1000001000",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "100"});
#line 18
 testRunner.When("I bulk load trades into MT4:-", ((string)(null)), table2, "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add Trades in parallel then close all positions for login and reconcile")]
        public virtual void AddTradesInParallelThenCloseAllPositionsForLoginAndReconcile()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Trades in parallel then close all positions for login and reconcile", ((string[])(null)));
#line 24
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "login",
                        "tradeInstruction",
                        "quantity",
                        "fileNamePath",
                        "threads"});
            table3.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "TestData\\100InsertsFor2Logins.csv",
                        "200"});
#line 25
 testRunner.When("I bulk load trades into MT4:-", ((string)(null)), table3, "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add 15 Trades in parallel then close all positions for login and reconcile")]
        public virtual void Add15TradesInParallelThenCloseAllPositionsForLoginAndReconcile()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add 15 Trades in parallel then close all positions for login and reconcile", ((string[])(null)));
#line 30
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "login",
                        "tradeInstruction",
                        "quantity",
                        "fileNamePath",
                        "threads"});
            table4.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "TestData\\5InsertsFor3Logins.csv",
                        "200"});
#line 31
 testRunner.When("I bulk load trades into MT4:-", ((string)(null)), table4, "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add 30 Trades in parallel in groups then close all positions for login and reconc" +
            "ile")]
        public virtual void Add30TradesInParallelInGroupsThenCloseAllPositionsForLoginAndReconcile()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add 30 Trades in parallel in groups then close all positions for login and reconc" +
                    "ile", ((string[])(null)));
#line 36
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "login",
                        "tradeInstruction",
                        "quantity",
                        "fileNamePath",
                        "threads"});
            table5.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "TestData\\2GroupsOf5InsertsFor3Logins.csv",
                        "200"});
#line 37
 testRunner.When("I bulk load trades into MT4:-", ((string)(null)), table5, "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add 300 Trades in parallel in groups then close all positions for login and recon" +
            "cile")]
        public virtual void Add300TradesInParallelInGroupsThenCloseAllPositionsForLoginAndReconcile()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add 300 Trades in parallel in groups then close all positions for login and recon" +
                    "cile", ((string[])(null)));
#line 41
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "login",
                        "tradeInstruction",
                        "quantity",
                        "fileNamePath",
                        "threads"});
            table6.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "TestData\\2GroupsOf5InsertsFor30Logins.csv",
                        "200"});
#line 42
 testRunner.When("I bulk load trades into MT4:-", ((string)(null)), table6, "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add 100k Trades in parallel then close all positions for login and reconcile")]
        public virtual void Add100KTradesInParallelThenCloseAllPositionsForLoginAndReconcile()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add 100k Trades in parallel then close all positions for login and reconcile", ((string[])(null)));
#line 46
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "login",
                        "tradeInstruction",
                        "quantity",
                        "fileNamePath",
                        "threads"});
            table7.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "TestData\\100InsertsFor1000Logins.csv",
                        "300"});
#line 47
 testRunner.When("I bulk load trades into MT4:-", ((string)(null)), table7, "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("MiniBuySellPartialCloseAll")]
        public virtual void MiniBuySellPartialCloseAll()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("MiniBuySellPartialCloseAll", ((string[])(null)));
#line 51
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "login",
                        "tradeInstruction",
                        "quantity",
                        "fileNamePath",
                        "threads"});
            table8.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "TestData\\MiniBuySellPartialCloseAll.csv",
                        "500"});
#line 52
 testRunner.When("I bulk load trades into MT4:-", ((string)(null)), table8, "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("BigBuySellPartialCloseAll")]
        public virtual void BigBuySellPartialCloseAll()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("BigBuySellPartialCloseAll", ((string[])(null)));
#line 57
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "login",
                        "tradeInstruction",
                        "quantity",
                        "fileNamePath",
                        "threads"});
            table9.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "TestData\\BigBuySellPartialCloseAll.csv",
                        "400"});
#line 58
 testRunner.When("I bulk load trades into MT4:-", ((string)(null)), table9, "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("MediumBuySellPartialCloseAll")]
        public virtual void MediumBuySellPartialCloseAll()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("MediumBuySellPartialCloseAll", ((string[])(null)));
#line 63
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "login",
                        "tradeInstruction",
                        "quantity",
                        "fileNamePath",
                        "threads"});
            table10.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "TestData\\MediumBuySellPartialCloseAll.csv",
                        "400"});
#line 64
 testRunner.When("I bulk load trades into MT4:-", ((string)(null)), table10, "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("SingleBuySellPartialCloseAll")]
        public virtual void SingleBuySellPartialCloseAll()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("SingleBuySellPartialCloseAll", ((string[])(null)));
#line 68
  this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "login",
                        "tradeInstruction",
                        "quantity",
                        "fileNamePath",
                        "threads"});
            table11.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "TestData\\SingleBuySellPartialCloseAl.csv",
                        "400"});
#line 69
 testRunner.When("I bulk load trades into MT4:-", ((string)(null)), table11, "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Bulk Close Trades in parallel then reconcile")]
        public virtual void BulkCloseTradesInParallelThenReconcile()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Bulk Close Trades in parallel then reconcile", ((string[])(null)));
#line 73
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "login"});
            table12.AddRow(new string[] {
                        "1000000001"});
            table12.AddRow(new string[] {
                        "1000010240"});
#line 74
 testRunner.When("I bulk close trades in MT4 for these logins:-", ((string)(null)), table12, "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Bulk Close Trades in parallel using start and stop logins then reconcile")]
        public virtual void BulkCloseTradesInParallelUsingStartAndStopLoginsThenReconcile()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Bulk Close Trades in parallel using start and stop logins then reconcile", ((string[])(null)));
#line 80
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "startLogin",
                        "endLogin",
                        "threads"});
            table13.AddRow(new string[] {
                        "1000000001",
                        "1000010240",
                        "30"});
#line 81
 testRunner.When("I bulk close trades in MT4 for these logins:-", ((string)(null)), table13, "When ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
