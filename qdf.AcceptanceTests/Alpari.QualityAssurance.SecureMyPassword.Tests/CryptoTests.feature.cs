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

namespace Alpari.QualityAssurance.SecureMyPassword.Tests
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("CryptoTests")]
    public partial class CryptoTestsFeature
    {
        private static TechTalk.SpecFlow.ITestRunner testRunner;

#line 1 "CryptoTests.feature"
#line hidden

        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            var featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"),
                "CryptoTests", "In order to protect passwords\r\nAs a concerned it user\r\nI want to be able to secur" +
                               "e my credentials", ProgrammingLanguage.CSharp, ((string[]) (null)));
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
        [NUnit.Framework.DescriptionAttribute("Encypt and Decrypt Password")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void EncyptAndDecryptPassword()
        {
            var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Encypt and Decrypt Password", new string[]
            {
                "mytag"
            });
#line 7
            this.ScenarioSetup(scenarioInfo);
#line 8
            testRunner.Given("my unencypted password is \"password\"", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "Given ");
#line 9
            testRunner.When("encypt my password", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "When ");
#line 10
            testRunner.And("I decrypt the encrypted password", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)),
                "And ");
#line 11
            testRunner.Then("the decrypted password is \"password\"", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Encypt and Decrypt complex Password")]
        public virtual void EncyptAndDecryptComplexPassword()
        {
            var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Encypt and Decrypt complex Password",
                ((string[]) (null)));
#line 13
            this.ScenarioSetup(scenarioInfo);
#line 14
            testRunner.Given("my unencypted password is \"server=10.25.9.213;user id=ars;password=1q2w3e;port=33" +
                             "06;database=cc\"", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "Given ");
#line 15
            testRunner.When("encypt my password", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "When ");
#line 16
            testRunner.And("I decrypt the encrypted password", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)),
                "And ");
#line 17
            testRunner.Then("the decrypted password is \"server=10.25.9.213;user id=ars;password=1q2w3e;port=33" +
                            "06;database=cc\"", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Direct Encypt and Decrypt Password")]
        public virtual void DirectEncyptAndDecryptPassword()
        {
            var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Direct Encypt and Decrypt Password",
                ((string[]) (null)));
#line 19
            this.ScenarioSetup(scenarioInfo);
#line 20
            testRunner.Given("my unencrypted password is \"password\"", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "Given ");
#line 21
            testRunner.When("I directly encrypt my password", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)),
                "When ");
#line 22
            testRunner.And("I directly decrypt the encrypted password", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 23
            testRunner.Then("the decrypted password is \"password\"", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Direct Encypt and Decrypt complex Password")]
        public virtual void DirectEncyptAndDecryptComplexPassword()
        {
            var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Direct Encypt and Decrypt complex Password",
                ((string[]) (null)));
#line 25
            this.ScenarioSetup(scenarioInfo);
#line 26
            testRunner.Given("my unencypted password is \"server=10.25.9.213;user id=ars;password=1q2w3e;port=33" +
                             "06;database=cc\"", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "Given ");
#line 27
            testRunner.When("encypt my password", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "When ");
#line 28
            testRunner.And("I decrypt the encrypted password", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)),
                "And ");
#line 29
            testRunner.Then("the decrypted password is \"server=10.25.9.213;user id=ars;password=1q2w3e;port=33" +
                            "06;database=cc\"", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}

#pragma warning restore

#endregion