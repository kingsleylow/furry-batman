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
    [NUnit.Framework.DescriptionAttribute("CombineManagerApiAndTradeExeToInsertAndDetectTrades")]
    [NUnit.Framework.CategoryAttribute("Mt4ArsPositionsContext")]
    public partial class CombineManagerApiAndTradeExeToInsertAndDetectTradesFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CombineManagerApiAndTradeExeToInsertAndDetectTrades.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CombineManagerApiAndTradeExeToInsertAndDetectTrades", "In order to bulk load trades into MT4\r\nAs a CC tester\r\nI want to enter trades and" +
                    " sync on insert finishing", ProgrammingLanguage.CSharp, new string[] {
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
#line 11
 testRunner.Given("I have a connection to a redis repository on \"localhost\" port 6379 db 0 namespace" +
                    " \"alpari-positions\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 12
 testRunner.And("I have a connection to Mt4ArsPositionsContext", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.When("I get all positions for server \"ProTest\" opened from \'2014/09/02 00:00:00\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
 testRunner.And("I query for open positions after \"2014-09-01\" on \"ars_test_AUKP01\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Bulk load identical trades and sync on insert completion")]
        public virtual void BulkLoadIdenticalTradesAndSyncOnInsertCompletion()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Bulk load identical trades and sync on insert completion", ((string[])(null)));
#line 17
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "login",
                        "tradeInstruction",
                        "quantity",
                        "fileNamePath"});
            table2.AddRow(new string[] {
                        "7003906",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "5",
                        ""});
#line 18
 testRunner.When("I bulk load trades into MT4:-", ((string)(null)), table2, "When ");
#line 21
 testRunner.Then("the count of open trades for login \"7003906\" will increase by 5", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Bulk load identical trades and sync on insert completion and reconcile redis and " +
            "Ars")]
        public virtual void BulkLoadIdenticalTradesAndSyncOnInsertCompletionAndReconcileRedisAndArs()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Bulk load identical trades and sync on insert completion and reconcile redis and " +
                    "Ars", ((string[])(null)));
#line 23
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "login",
                        "tradeInstruction",
                        "quantity",
                        "fileNamePath"});
            table3.AddRow(new string[] {
                        "7003906",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "5",
                        ""});
#line 24
 testRunner.When("I bulk load trades into MT4:-", ((string)(null)), table3, "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "ExcludedFields"});
            table4.AddRow(new string[] {
                        "Timestamp"});
#line 27
 testRunner.And("I compare the \"ProTest\" positions with the \"ars_test_AUKP01\" positions excluding " +
                    "these fields:", ((string)(null)), table4, "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "ExportType",
                        "Overwrite"});
            table5.AddRow(new string[] {
                        "DataTableToCsv",
                        "true"});
#line 31
 testRunner.Then("the redis positions should match the ars positions exactly:-", ((string)(null)), table5, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add Trades then close all positions for login and reconcile")]
        public virtual void AddTradesThenCloseAllPositionsForLoginAndReconcile()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Trades then close all positions for login and reconcile", ((string[])(null)));
#line 36
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
                        "7004066",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "5",
                        "",
                        ""});
#line 37
 testRunner.When("I bulk load trades into MT4:-", ((string)(null)), table6, "When ");
#line 40
 testRunner.Then("the count of open trades for login \"7003906\" will increase by 5", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 41
 testRunner.When("I close all positions for login \"7003906\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 42
 testRunner.Then("the count of open trades for login \"7003906\" will be 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 43
 testRunner.When("I get all positions for server \"ProTest\" opened from \'2014/09/02 00:00:00\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 44
 testRunner.And("I query for open positions after \"2014-09-01\" on \"ars_test_AUKP01\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "ExcludedFields"});
            table7.AddRow(new string[] {
                        "Timestamp"});
#line 45
 testRunner.And("I compare the \"ProTest\" positions with the \"ars_test_AUKP01\" positions excluding " +
                    "these fields:", ((string)(null)), table7, "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "ExportType",
                        "Overwrite"});
            table8.AddRow(new string[] {
                        "DataTableToCsv",
                        "true"});
#line 49
 testRunner.Then("the redis positions should match the ars positions exactly:-", ((string)(null)), table8, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add Trades in parallel then close all positions for login and reconcile")]
        public virtual void AddTradesInParallelThenCloseAllPositionsForLoginAndReconcile()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Trades in parallel then close all positions for login and reconcile", ((string[])(null)));
#line 72
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "login",
                        "tradeInstruction",
                        "quantity"});
            table9.AddRow(new string[] {
                        "7003906",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7003906",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004130",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004129",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004128",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004127",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004126",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004125",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004124",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004123",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004122",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004121",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004120",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004119",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004118",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004117",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004116",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004115",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004114",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004113",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004112",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004111",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004110",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004109",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004108",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004107",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004106",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004105",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004104",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004103",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004102",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004101",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004100",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004099",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004098",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004097",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004096",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004095",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004094",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004093",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004092",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004091",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004090",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004089",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004088",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004087",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004086",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004085",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004084",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004083",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004082",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004081",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004080",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004079",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004078",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004077",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004076",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004075",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004074",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004073",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004072",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004071",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004070",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004069",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
            table9.AddRow(new string[] {
                        "7004068",
                        "buy volume=345 symbol=EURUSD price=1.5",
                        "150"});
#line 73
 testRunner.When("I bulk load trades into MT4:-", ((string)(null)), table9, "When ");
#line 141
 testRunner.Then("the count of open trades for login \"7003906\" will increase by 500", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 142
 testRunner.When("I close all positions for login \"7003906\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 143
 testRunner.Then("the count of open trades for login \"7003906\" will be 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 144
 testRunner.When("I get all positions for server \"ProTest\" opened from \'2014/09/02 00:00:00\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 145
 testRunner.And("I query for open positions after \"2014-09-01\" on \"ars_test_AUKP01\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "ExcludedFields"});
            table10.AddRow(new string[] {
                        "Timestamp"});
            table10.AddRow(new string[] {
                        "OpenTime"});
#line 146
 testRunner.And("I compare the \"ProTest\" positions with the \"ars_test_AUKP01\" positions excluding " +
                    "these fields:", ((string)(null)), table10, "And ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "ExportType",
                        "Overwrite"});
            table11.AddRow(new string[] {
                        "DataTableToCsv",
                        "true"});
#line 150
 testRunner.Then("the redis positions should match the ars positions exactly:-", ((string)(null)), table11, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Bulk Close Trades in parallel then close all positions for login and reconcile")]
        public virtual void BulkCloseTradesInParallelThenCloseAllPositionsForLoginAndReconcile()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Bulk Close Trades in parallel then close all positions for login and reconcile", ((string[])(null)));
#line 154
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "login"});
            table12.AddRow(new string[] {
                        "7003906"});
            table12.AddRow(new string[] {
                        "7004130"});
            table12.AddRow(new string[] {
                        "7004129"});
            table12.AddRow(new string[] {
                        "7004128"});
            table12.AddRow(new string[] {
                        "7004127"});
            table12.AddRow(new string[] {
                        "7004126"});
            table12.AddRow(new string[] {
                        "7004125"});
            table12.AddRow(new string[] {
                        "7004124"});
            table12.AddRow(new string[] {
                        "7004123"});
            table12.AddRow(new string[] {
                        "7004122"});
            table12.AddRow(new string[] {
                        "7004121"});
            table12.AddRow(new string[] {
                        "7004120"});
            table12.AddRow(new string[] {
                        "7004119"});
            table12.AddRow(new string[] {
                        "7004118"});
            table12.AddRow(new string[] {
                        "7004117"});
            table12.AddRow(new string[] {
                        "7004116"});
            table12.AddRow(new string[] {
                        "7004115"});
            table12.AddRow(new string[] {
                        "7004114"});
            table12.AddRow(new string[] {
                        "7004113"});
            table12.AddRow(new string[] {
                        "7004112"});
            table12.AddRow(new string[] {
                        "7004111"});
            table12.AddRow(new string[] {
                        "7004110"});
            table12.AddRow(new string[] {
                        "7004109"});
            table12.AddRow(new string[] {
                        "7004108"});
            table12.AddRow(new string[] {
                        "7004107"});
            table12.AddRow(new string[] {
                        "7004106"});
            table12.AddRow(new string[] {
                        "7004105"});
            table12.AddRow(new string[] {
                        "7004104"});
            table12.AddRow(new string[] {
                        "7004103"});
            table12.AddRow(new string[] {
                        "7004102"});
            table12.AddRow(new string[] {
                        "7004101"});
            table12.AddRow(new string[] {
                        "7004100"});
            table12.AddRow(new string[] {
                        "7004099"});
            table12.AddRow(new string[] {
                        "7004098"});
            table12.AddRow(new string[] {
                        "7004097"});
            table12.AddRow(new string[] {
                        "7004096"});
            table12.AddRow(new string[] {
                        "7004095"});
            table12.AddRow(new string[] {
                        "7004094"});
            table12.AddRow(new string[] {
                        "7004093"});
            table12.AddRow(new string[] {
                        "7004092"});
            table12.AddRow(new string[] {
                        "7004091"});
            table12.AddRow(new string[] {
                        "7004090"});
            table12.AddRow(new string[] {
                        "7004089"});
            table12.AddRow(new string[] {
                        "7004088"});
            table12.AddRow(new string[] {
                        "7004087"});
            table12.AddRow(new string[] {
                        "7004086"});
            table12.AddRow(new string[] {
                        "7004085"});
            table12.AddRow(new string[] {
                        "7004084"});
            table12.AddRow(new string[] {
                        "7004083"});
            table12.AddRow(new string[] {
                        "7004082"});
            table12.AddRow(new string[] {
                        "7004081"});
            table12.AddRow(new string[] {
                        "7004080"});
            table12.AddRow(new string[] {
                        "7004079"});
            table12.AddRow(new string[] {
                        "7004078"});
            table12.AddRow(new string[] {
                        "7004077"});
            table12.AddRow(new string[] {
                        "7004076"});
            table12.AddRow(new string[] {
                        "7004075"});
            table12.AddRow(new string[] {
                        "7004074"});
            table12.AddRow(new string[] {
                        "7004073"});
            table12.AddRow(new string[] {
                        "7004072"});
            table12.AddRow(new string[] {
                        "7004071"});
            table12.AddRow(new string[] {
                        "7004070"});
            table12.AddRow(new string[] {
                        "7004069"});
            table12.AddRow(new string[] {
                        "7004068"});
#line 155
 testRunner.When("I bulk close trades in MT4 for these logins:-", ((string)(null)), table12, "When ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
