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

namespace Alpari.QualityAssurance.SpecFlowExtensions.Specs
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("TypedDataTableFun")]
    public partial class TypedDataTableFunFeature
    {
        private static TechTalk.SpecFlow.ITestRunner testRunner;

#line 1 "TypedDataTableFun.feature"
#line hidden

        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            var featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"),
                "TypedDataTableFun",
                "In order to compare sets of actual and expected data\r\nAs a Tester\r\nI want methods" +
                " for comparing Typed Data Tables", ProgrammingLanguage.CSharp, ((string[]) (null)));
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
        [NUnit.Framework.DescriptionAttribute("Compare Two matching data sets")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void CompareTwoMatchingDataSets()
        {
            var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Compare Two matching data sets", new string[]
            {
                "mytag"
            });
#line 7
            this.ScenarioSetup(scenarioInfo);
#line hidden
            var table1 = new TechTalk.SpecFlow.Table(new string[]
            {
                "ID",
                "Forenames",
                "Lastname",
                "Age",
                "Occupation"
            });
            table1.AddRow(new string[]
            {
                "1",
                "Vladimir",
                "Putin",
                "99",
                "Impaler"
            });
            table1.AddRow(new string[]
            {
                "2",
                "John",
                "Kerry",
                "100",
                "stand up comic"
            });
#line 8
            testRunner.Given("I have the following \"expected\" person data:", ((string) (null)), table1, "Given ");
#line hidden
            var table2 = new TechTalk.SpecFlow.Table(new string[]
            {
                "ID",
                "Forenames",
                "Lastname",
                "Age",
                "Occupation"
            });
            table2.AddRow(new string[]
            {
                "1",
                "Vladimir",
                "Putin",
                "99",
                "Impaler"
            });
            table2.AddRow(new string[]
            {
                "2",
                "John",
                "Kerry",
                "100",
                "stand up comic"
            });
#line 12
            testRunner.And("I have the following \"actual\" person data:", ((string) (null)), table2, "And ");
#line 16
            testRunner.When("I compare the \"expected\" and \"actual\" person data", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "When ");
#line 17
            testRunner.Then("the person data should match exactly", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Compare Two data sets one mismatch")]
        public virtual void CompareTwoDataSetsOneMismatch()
        {
            var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Compare Two data sets one mismatch",
                ((string[]) (null)));
#line 19
            this.ScenarioSetup(scenarioInfo);
#line hidden
            var table3 = new TechTalk.SpecFlow.Table(new string[]
            {
                "ID",
                "Forenames",
                "Lastname",
                "Age",
                "Occupation"
            });
            table3.AddRow(new string[]
            {
                "1",
                "Vladimir",
                "Putin",
                "99",
                "Impaler"
            });
            table3.AddRow(new string[]
            {
                "2",
                "John",
                "Kerry",
                "100",
                "stand up comic"
            });
#line 20
            testRunner.Given("I have the following \"expected\" person data:", ((string) (null)), table3, "Given ");
#line hidden
            var table4 = new TechTalk.SpecFlow.Table(new string[]
            {
                "ID",
                "Forenames",
                "Lastname",
                "Age",
                "Occupation"
            });
            table4.AddRow(new string[]
            {
                "1",
                "Vladimir",
                "Putin",
                "98",
                "Impaler"
            });
            table4.AddRow(new string[]
            {
                "2",
                "John",
                "Kerry",
                "100",
                "stand up comic"
            });
#line 24
            testRunner.And("I have the following \"actual\" person data:", ((string) (null)), table4, "And ");
#line 28
            testRunner.When("I compare the \"expected\" and \"actual\" person data", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "When ");
#line 29
            testRunner.Then("the person data should contain 1 \"mismatch\"", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Compare Two data sets one missing")]
        public virtual void CompareTwoDataSetsOneMissing()
        {
            var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Compare Two data sets one missing",
                ((string[]) (null)));
#line 31
            this.ScenarioSetup(scenarioInfo);
#line hidden
            var table5 = new TechTalk.SpecFlow.Table(new string[]
            {
                "ID",
                "Forenames",
                "Lastname",
                "Age",
                "Occupation"
            });
            table5.AddRow(new string[]
            {
                "1",
                "Vladimir",
                "Putin",
                "98",
                "Impaler"
            });
            table5.AddRow(new string[]
            {
                "2",
                "John",
                "Kerry",
                "100",
                "stand up comic"
            });
#line 32
            testRunner.Given("I have the following \"expected\" person data:", ((string) (null)), table5, "Given ");
#line hidden
            var table6 = new TechTalk.SpecFlow.Table(new string[]
            {
                "ID",
                "Forenames",
                "Lastname",
                "Age",
                "Occupation"
            });
            table6.AddRow(new string[]
            {
                "1",
                "Vladimir",
                "Putin",
                "98",
                "Impaler"
            });
#line 36
            testRunner.And("I have the following \"actual\" person data:", ((string) (null)), table6, "And ");
#line 39
            testRunner.When("I compare the \"expected\" and \"actual\" person data", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "When ");
#line 40
            testRunner.Then("the person data should contain 1 \"missing\"", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Compare Two data sets one extra")]
        public virtual void CompareTwoDataSetsOneExtra()
        {
            var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Compare Two data sets one extra", ((string[]) (null)));
#line 42
            this.ScenarioSetup(scenarioInfo);
#line hidden
            var table7 = new TechTalk.SpecFlow.Table(new string[]
            {
                "ID",
                "Forenames",
                "Lastname",
                "Age",
                "Occupation"
            });
            table7.AddRow(new string[]
            {
                "1",
                "Vladimir",
                "Putin",
                "98",
                "Impaler"
            });
#line 43
            testRunner.Given("I have the following \"expected\" person data:", ((string) (null)), table7, "Given ");
#line hidden
            var table8 = new TechTalk.SpecFlow.Table(new string[]
            {
                "ID",
                "Forenames",
                "Lastname",
                "Age",
                "Occupation"
            });
            table8.AddRow(new string[]
            {
                "1",
                "Vladimir",
                "Putin",
                "98",
                "Impaler"
            });
            table8.AddRow(new string[]
            {
                "2",
                "John",
                "Kerry",
                "100",
                "stand up comic"
            });
#line 46
            testRunner.And("I have the following \"actual\" person data:", ((string) (null)), table8, "And ");
#line 50
            testRunner.When("I compare the \"expected\" and \"actual\" person data", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "When ");
#line 51
            testRunner.Then("the person data should contain 1 \"extra\"", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}

#pragma warning restore

#endregion