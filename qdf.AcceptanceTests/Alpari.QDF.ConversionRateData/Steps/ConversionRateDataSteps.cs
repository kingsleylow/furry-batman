﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using Alpari.QA.QDF.Test.Domain.WebClients;
using Alpari.QualityAssurance.SpecFlowExtensions.FileUtilities;
using Alpari.QualityAssurance.SpecFlowExtensions.StepBases;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace Alpari.QDF.ConversionRateData.Steps
{
    [Binding]
    public class ConversionRateDataSteps : MasterStepBase
    {
        public static readonly string FullName = typeof(ConversionRateDataSteps).FullName;

        public ConversionRateDataSteps(CurrenexHubAdminWebClient currenexHubAdminWebClient)
        {
            CurrenexHubAdminWebClient = currenexHubAdminWebClient;
        }

        public CurrenexHubAdminWebClient CurrenexHubAdminWebClient { get; set; }

        [Given(@"I have connected to currenex hub admin")]
        public void GivenIHaveConnectedToCurrenexHubAdmin()
        {
            //CurrenexHubAdminWebClient.Login("auk_dgalloway", "auk12345");
            CurrenexHubAdminWebClient.Login(
                ConfigurationManager.AppSettings[CurrenexHubAdminWebClient.CNX_HUB_ADMIN_USER_NAME],
                ConfigurationManager.AppSettings[CurrenexHubAdminWebClient.CNX_HUB_ADMIN_PASSWORD]);

            // Download some secure resource
            string result =
                CurrenexHubAdminWebClient.DownloadString("https://pret.currenex.com/webadmin/report/list.action");
            result.Should().NotBeNullOrWhiteSpace();
        }

        protected static ExportParameters SetupImportParameters(string reportDate)
        {
            //Note:- have used an output path as a query parameter - this duplicates functionality already supplied in ExportParameters, so could potentially be removed (as long ads the equivalent property in ExportParameters is used instead)
            return new ExportParameters
            {
                QueryParameters = new Dictionary<string, string>
                {
                    {
                        CurrenexHubAdminWebClient.CNX_HUB_ADMIN_USER_NAME,
                        ConfigurationManager.AppSettings[CurrenexHubAdminWebClient.CNX_HUB_ADMIN_USER_NAME]
                    },
                    {
                        CurrenexHubAdminWebClient.CNX_HUB_ADMIN_PASSWORD,
                        ConfigurationManager.AppSettings[CurrenexHubAdminWebClient.CNX_HUB_ADMIN_PASSWORD]
                    },
                    {
                        CurrenexHubAdminWebClient.CURRENT_DATE,
                        DateTime.Today.ToString("MM/dd/yyyy")
                    },
                    {
                        CurrenexHubAdminWebClient.FROM_DATE_STR, 
                        reportDate
                    },
                    {
                        CurrenexHubAdminWebClient.TO_DATE_STR, 
                        reportDate
                    },
                    {
                        CurrenexHubAdminWebClient.OUTPUT_PATH, 
                        ScenarioOutputDirectory
                    }
                }
            };
        }

        public void LogOut()
        {
            string result = CurrenexHubAdminWebClient.LogOut();
            result.Should().Contain("Logged out successfully");
        }
    }
}
