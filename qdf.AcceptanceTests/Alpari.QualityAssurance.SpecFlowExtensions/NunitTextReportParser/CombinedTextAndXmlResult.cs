﻿using System.Collections.Generic;
using Alpari.QualityAssurance.SpecFlowExtensions.StepBases;

namespace Alpari.QualityAssurance.SpecFlowExtensions.NunitTextReportParser
{
    public class CombinedTextAndXmlResult
    {
        public CombinedTextAndXmlResult(TestCaseTextResult textResult,
            IList<IDictionary<string, object>> testCasesByTestSuiteAsList)
        {
            this.textResult = textResult;
            //TODO:- convert to LINQ if possible
            foreach (var item in testCasesByTestSuiteAsList)
            {
                string taglist = item["tags"].ToString();
                    //.Replace('_', '-'); //TODO:- would be more efficient to do this at source, but would have to change tests!
                if (taglist.Contains(this.textResult.PrimaryTag))
                {
                    xmlResult = DataTableOperations.ConvertIDictionaryToDictionary(item);
                    testCasesByTestSuiteAsList.Remove(xmlResult);
                        // assumes that the promary tag really is unique across all tests. Removing from source list isn't (easily) possible in LINQ
                    break;
                }
            }
        }

        public TestCaseTextResult textResult { get; set; }
        public Dictionary<string, object> xmlResult { get; set; } // new Dictionary<string, object>();
    }
}