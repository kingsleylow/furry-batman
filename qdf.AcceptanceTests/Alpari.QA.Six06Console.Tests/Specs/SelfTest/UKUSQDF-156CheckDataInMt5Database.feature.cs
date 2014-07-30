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
    [NUnit.Framework.DescriptionAttribute("UKUSQDF-156CheckDataInMt5Database")]
    [NUnit.Framework.CategoryAttribute("UKUSQDF_156")]
    [NUnit.Framework.CategoryAttribute("Mt5DealsContext")]
    public partial class UKUSQDF_156CheckDataInMt5DatabaseFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "UKUSQDF-156CheckDataInMt5Database.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-GB"), "UKUSQDF-156CheckDataInMt5Database", "In order to check deals have been successfully inserted into MT5\r\nAs a QDF Tester" +
                    "\r\nI want to be able to query deal data from MT5", ProgrammingLanguage.CSharp, new string[] {
                        "UKUSQDF_156",
                        "Mt5DealsContext"});
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
        [NUnit.Framework.DescriptionAttribute("Get Highest Deal ID for Login")]
        public virtual void GetHighestDealIDForLogin()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get Highest Deal ID for Login", ((string[])(null)));
#line 12
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 13
 testRunner.Given("I am using mt5 manager login \'8900907\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 14
 testRunner.When("I get the highest mt5 deal id for my login", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
 testRunner.Then("The highest mt5 deal id is greater than 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check the highest deal id increases after running the console app")]
        public virtual void CheckTheHighestDealIdIncreasesAfterRunningTheConsoleApp()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check the highest deal id increases after running the console app", ((string[])(null)));
#line 17
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 18
 testRunner.Given("I have stored the highest mt5 deal id for login \'8900907\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 19
 testRunner.When("I launch the process and parse the order events from the console into orders and " +
                    "deals", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
 testRunner.Then("the new highest mt5 deal id is greater than the original", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Map Mt5Deals to Order Event Ids")]
        public virtual void MapMt5DealsToOrderEventIds()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Map Mt5Deals to Order Event Ids", ((string[])(null)));
#line 22
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 23
 testRunner.Given("I have stored the highest mt5 deal id for login \'8900907\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 24
 testRunner.When("I launch the process and parse the order events from the console into orders and " +
                    "deals", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
 testRunner.And("I close the process using Ctrl+c in the StdInput", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.And("I query the mt5 deals table for new deals for my login", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
 testRunner.And("I convert the mt5 deals to trades with event id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.Then("all order events in the order event id to deal mapping dictionary are mapped", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
