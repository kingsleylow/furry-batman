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
namespace Alpari.QA.Six06Console.Tests.Specs.SelfTest
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("UKUSQDF-156AutomateTestingOfSix06ConsoleApp")]
    [NUnit.Framework.CategoryAttribute("UKUSQDF_156")]
    public partial class UKUSQDF_156AutomateTestingOfSix06ConsoleAppFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "UKUSQDF-156AutomateTestingOf606ConsoleApp.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-GB"), "UKUSQDF-156AutomateTestingOfSix06ConsoleApp", "In order to test the 606.5 Console App\r\nAs a QDF Tester\r\nI want to be able to lau" +
                    "nch the console and read its output", ProgrammingLanguage.CSharp, new string[] {
                        "UKUSQDF_156"});
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
                        "FileName",
                        "UseShellExecute",
                        "RedirectStandardError",
                        "RedirectStandardInput",
                        "RedirectStandardOutput",
                        "CreateNoWindow"});
            table1.AddRow(new string[] {
                        "AUT\\QDF\\606.5Console\\606.5Console.exe",
                        "false",
                        "true",
                        "true",
                        "false",
                        "true"});
#line 8
 testRunner.Given("I have the following process parameters", ((string)(null)), table1, "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Launch 606.5Console")]
        public virtual void Launch606_5Console()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Launch 606.5Console", ((string[])(null)));
#line 12
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 13
 testRunner.When("I launch the process", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
 testRunner.Then("the process is launched ok", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Launch 606.5Console and check config loaded")]
        public virtual void Launch606_5ConsoleAndCheckConfigLoaded()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Launch 606.5Console and check config loaded", ((string[])(null)));
#line 16
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 17
 testRunner.When("I launch the process", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
 testRunner.Then("the process is launched ok", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 19
 testRunner.And("the standard error output contains text \"get_config: success\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Launch 606.5Console and check SqlState")]
        public virtual void Launch606_5ConsoleAndCheckSqlState()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Launch 606.5Console and check SqlState", ((string[])(null)));
#line 21
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 22
 testRunner.When("I launch the process", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
 testRunner.Then("the process is launched ok", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 24
 testRunner.And("the standard error output contains text \"SQLSTATE: 01000\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Launch 606.5Console and check Sql Executed ok")]
        public virtual void Launch606_5ConsoleAndCheckSqlExecutedOk()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Launch 606.5Console and check Sql Executed ok", ((string[])(null)));
#line 26
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 27
 testRunner.When("I launch the process", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
 testRunner.Then("the process is launched ok", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 29
 testRunner.And("the standard error output contains text \"SQLExecDirect: success\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.And("the standard error output contains text \">\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.And("the standard error output contains text \"waiting 2 seconds..\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Launch 606.5Console and parse deal mapping")]
        public virtual void Launch606_5ConsoleAndParseDealMapping()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Launch 606.5Console and parse deal mapping", ((string[])(null)));
#line 33
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 34
 testRunner.When("I launch the process", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 35
 testRunner.And("I parse the order events from the console into orders and deals", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
 testRunner.Then("the order Event ID to deal mapping dictionary contains at least 1 record", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Call 606.5 Stored Proc and retrieve deals from qdf database")]
        public virtual void Call606_5StoredProcAndRetrieveDealsFromQdfDatabase()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Call 606.5 Stored Proc and retrieve deals from qdf database", ((string[])(null)));
#line 38
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 39
 testRunner.Given("I have a connection to QDF.GetTradeswithEventIDProc", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 40
 testRunner.When("I call QDF.GetAutoTradeswithEventID with ID 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
  testRunner.And("I save the QDF.GetAutoTradeswithEventID result as a datatable", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
 testRunner.Then("the QDF.GetAutoTradeswithEventID data table contains at least one result", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Launch 606.5Console and check deals against stored proc results")]
        public virtual void Launch606_5ConsoleAndCheckDealsAgainstStoredProcResults()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Launch 606.5Console and check deals against stored proc results", ((string[])(null)));
#line 44
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 45
 testRunner.When("I call QDF.GetAutoTradeswithEventID with ID 0 and save the result as a datatable", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 46
 testRunner.And("I launch the process and parse the order events from the console into orders and " +
                    "deals", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
 testRunner.Then("the order Event ID to deal mapping dictionary contains all the deals returned by " +
                    "QDF.GetAutoTradeswithEventID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Launch 606.5Console and close the process gracefully")]
        public virtual void Launch606_5ConsoleAndCloseTheProcessGracefully()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Launch 606.5Console and close the process gracefully", ((string[])(null)));
#line 49
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 50
 testRunner.When("I launch the process", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 51
 testRunner.And("I close the process using Ctrl+c in the StdInput", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
 testRunner.Then("the process is closed ok", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Map Trade with Event Ids to Mt5 Order Ids")]
        public virtual void MapTradeWithEventIdsToMt5OrderIds()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Map Trade with Event Ids to Mt5 Order Ids", ((string[])(null)));
#line 54
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 55
 testRunner.When("I call QDF.GetAutoTradeswithEventID with ID 0 and save the result as a datatable", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 56
  testRunner.And("I launch the process and parse the order events from the console into orders and " +
                    "deals", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
  testRunner.And("I close the process using Ctrl+c in the StdInput", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
  testRunner.And("I convert the trades with event ids to trades with deal and order ids", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
 testRunner.Then("all order events in the order event id to deal mapping dictionary are mapped to t" +
                    "rades with event ids", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Map Trade with Event Ids to Mt5 Order Ids if they have them")]
        public virtual void MapTradeWithEventIdsToMt5OrderIdsIfTheyHaveThem()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Map Trade with Event Ids to Mt5 Order Ids if they have them", ((string[])(null)));
#line 62
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 63
 testRunner.When("I call QDF.GetAutoTradeswithEventID with ID 0 and save the result as a datatable", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 64
  testRunner.And("I launch the process and parse the order events from the console into orders and " +
                    "deals", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
  testRunner.And("I close the process using Ctrl+c in the StdInput", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
  testRunner.And("I convert the trades with event ids to trades with deal and order ids if they exi" +
                    "st", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
 testRunner.Then("at least one order event in the order event id to deal mapping dictionary is mapp" +
                    "ed to trades with event ids", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Run 606.5Console and compare Mt5 deals against QDF")]
        [NUnit.Framework.CategoryAttribute("Mt5DealsContext")]
        public virtual void Run606_5ConsoleAndCompareMt5DealsAgainstQDF()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Run 606.5Console and compare Mt5 deals against QDF", new string[] {
                        "Mt5DealsContext"});
#line 71
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 72
 testRunner.Given("I have stored the highest mt5 deal id for login \'8900907\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 76
 testRunner.When("I import auto hedged trades into MT5 starting at deal id 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "ExcludedFields"});
            table2.AddRow(new string[] {
                        "Deal"});
            table2.AddRow(new string[] {
                        "login"});
            table2.AddRow(new string[] {
                        "Order"});
            table2.AddRow(new string[] {
                        "ExecID"});
            table2.AddRow(new string[] {
                        "OrderTimeTypeID"});
            table2.AddRow(new string[] {
                        "OrderPriceTypeID"});
#line 79
  testRunner.And("I compare the MT5 deals against QDF except for these fields", ((string)(null)), table2, "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "ExportType",
                        "Overwrite"});
            table3.AddRow(new string[] {
                        "DataTableToCsv",
                        "true"});
#line 89
 testRunner.Then("the MT5 deals exactly match the QDF deals:-", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
