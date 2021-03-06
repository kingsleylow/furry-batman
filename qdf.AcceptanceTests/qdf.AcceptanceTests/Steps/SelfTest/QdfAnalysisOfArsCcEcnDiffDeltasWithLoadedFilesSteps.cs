﻿using Alpari.QualityAssurance.SpecFlowExtensions.FileUtilities;
using FluentAssertions;
using System;
using System.Linq;
using TechTalk.SpecFlow;

namespace qdf.AcceptanceTests.Steps.SelfTest
{
    [Binding]
    public class QdfAnalysisOfArsCcEcnDiffDeltasWithLoadedFilesSteps : StepCentral
    {
        private readonly QdfAnalysisOfArsCcEcnDiffDeltasSnapOnCcSteps _sharedSteps;

        public QdfAnalysisOfArsCcEcnDiffDeltasWithLoadedFilesSteps()
        {
            _sharedSteps = QdfAnalysisOfArsCcEcnDiffDeltasSnapOnCcSteps;
        }

        [Given(@"I have loaded all ""(.*)"" files")]
        public void GivenIHaveLoadedAllFiles(string filePattern)
        {
            _sharedSteps.DiffDeltaSummary.LoadFilesToDictionary(filePattern);
        }

        [Given(@"I have loaded all ""(.*)"" files as lists of deltas")]
        public void GivenIHaveLoadedAllFilesAsListsOfDeltas(string filePattern)
        {
            _sharedSteps.DiffDeltaList.LoadFilesToDictionary(filePattern);
        }

        [Then(@"these combinations contain unknown data")]
        public void ThenTheseCombinationsContainUnknownData(Table table)
        {
            var expectedUnknowns = (table.Rows.Select(row => row["Combinations"])).ToList();
            var actualUnknowns = _sharedSteps.GetActualUnknowns();
            //TODO:- find is there's an assertion that can do this more concisely!
            expectedUnknowns.Should().Contain(actualUnknowns);
            actualUnknowns.Should().Contain(expectedUnknowns);
            expectedUnknowns.Except(actualUnknowns).Should().BeNullOrEmpty();
            actualUnknowns.Except(expectedUnknowns).Should().BeNullOrEmpty();
            _sharedSteps.AnalyzeAndExportUnknowns("csv");
        }




        [Then(@"the combination with the highest diffdelta sum is ""(.*)"" with (.*)")]
        public void ThenTheCombinationWithTheHighestDiffdeltaSumIsWith(string combination, decimal amount)
        {
            _sharedSteps.DeltaSumDecimals.Values.Max().Should().Be(amount);
            _sharedSteps.DeltaSumDecimals[combination].Should().Be(amount);
        }

        [Then(@"the book with the highest diffdelta sum is ""(.*)"" with (.*)")]
        public void ThenTheBookWithTheHighestDiffdeltaSumIsWith(string book, Decimal amount)
        {
            _sharedSteps.DeltaSumByBook.Values.Max().Should().Be(amount);
            _sharedSteps.DeltaSumByBook[Convert.ToChar(book)].Should().Be(amount);
        }

        [Then(@"the server with the highest diffdelta sum is ""(.*)"" with (.*)")]
        public void ThenTheServerWithTheHighestDiffdeltaSumIsWith(string server, Decimal amount)
        {
            _sharedSteps.DeltaSumByServer.Values.Max().Should().Be(amount);
            _sharedSteps.DeltaSumByServer[server].Should().Be(amount);
        }

        [Then(@"the symbol with the highest diffdelta sum is ""(.*)"" with (.*)")]
        public void ThenTheSymbolWithTheHighestDiffdeltaSumIsWith(string symbol, Decimal amount)
        {
            _sharedSteps.DeltaSumBySymbol.Values.Max().Should().Be(amount);
            _sharedSteps.DeltaSumBySymbol[symbol].Should().Be(amount);
        }    
    }
}
