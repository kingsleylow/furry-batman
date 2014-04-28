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

using TechTalk.SpecFlow;

#pragma warning disable

namespace qdf.AcceptanceTests.Specs.SelfTests
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("MySqlQUickStart")]
    public partial class MySqlQUickStartFeature
    {
        private static TechTalk.SpecFlow.ITestRunner testRunner;

#line 1 "MySqlQUickStart.feature"
#line hidden

        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            var featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"),
                "MySqlQUickStart", "In order to access MySql Data\r\nAs a tester\r\nI want a working linq provider",
                ProgrammingLanguage.CSharp, ((string[]) (null)));
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
        [NUnit.Framework.DescriptionAttribute("Create connection")]
        [NUnit.Framework.CategoryAttribute("SelfTest")]
        public virtual void CreateConnection()
        {
            var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create connection", new string[]
            {
                "SelfTest"
            });
#line 7
            this.ScenarioSetup(scenarioInfo);
#line 8
            testRunner.Given("I have created a connection to \"MySqlDataContextSubstitute\"", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "Given ");
#line 9
            testRunner.When("I retrieve cc_tbl_position_section data from cc", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "When ");
#line 10
            testRunner.Then("the cc_tbl_position_section data from cc has 4 records", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}

#pragma warning restore

#endregion