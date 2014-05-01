﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentAssertions;
using TechTalk.SpecFlow;
using Alpari.QualityAssurance.RefData;

namespace Alpari.QualityAssurance.RefData.Tests
{
    [Binding]
    public class RefDataSteps
    {
        private ReferenceData _refData;

        [Given(@"I have connected to the ref data dictionary")]
        public void GivenIHaveConnectedToTheRefDataDictionary()
        {
            _refData = ReferenceData.Instance;
        }

        [When(@"I lookup key ""(.*)"" in the QdfToCcServerMapping dictionary")]
        public void WhenILookupKeyInTheQdfToCcServerMappingDictionary(string key)
        {
            ScenarioContext.Current["lookupValue"] = _refData.QdfToCcServerMapping[key];
        }

        [When(@"I lookup key ""(.*)"" in the CcToQdfServerMapping dictionary")]
        public void WhenILookupKeyInTheCcToQdfServerMappingDictionary(string key)
        {
            ScenarioContext.Current["lookupValue"] = _refData.CcToQdfServerMapping[key];
        }


        [Then(@"the value returned by the lookup is ""(.*)""")]
        public void ThenTheValueReturnedByTheLookupIs(string lookupValue)
        {
            ScenarioContext.Current["lookupValue"].Should().Be(lookupValue);
        }

    }
}
