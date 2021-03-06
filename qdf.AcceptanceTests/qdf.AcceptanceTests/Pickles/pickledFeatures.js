jsonPWrapper ([
  {
    "RelativeFolder": "SelfTests\\ReuseDealReconciliationSteps.feature",
    "Feature": {
      "Name": "ReuseDealReconciliationSteps",
      "Description": "In order to show deal recon steps are inherited from master step base\r\nAs a tester\r\nI want to see methods available between step definition files",
      "FeatureElements": [
        {
          "Name": "reuse the deal recon steps",
          "Description": "",
          "Steps": [
            {
              "Keyword": "Given",
              "NativeKeyword": "Given ",
              "Name": "I have connected to \"MySqlDataContextSubstitute\""
            }
          ],
          "Tags": [
            "@mytag"
          ],
          "Result": {
            "WasExecuted": true,
            "WasSuccessful": true
          }
        }
      ],
      "Result": {
        "WasExecuted": true,
        "WasSuccessful": true
      },
      "Tags": []
    },
    "Result": {
      "WasExecuted": true,
      "WasSuccessful": true
    }
  },
  {
    "RelativeFolder": "SelfTests\\RedisConnectionSelfTests.feature",
    "Feature": {
      "Name": "RedisConnectionSelfTests",
      "Description": "In order to check deals in QDF\r\nAs a tester\r\nI want to be able to get data from Redis",
      "FeatureElements": [
        {
          "Name": "retrieve deal data by absolute date",
          "Description": "",
          "Steps": [
            {
              "Keyword": "Given",
              "NativeKeyword": "Given ",
              "Name": "I have QDF Deal Data",
              "TableArgument": {
                "HeaderRow": [
                  "ConvertedStartTime",
                  "ConvertedEndTime"
                ],
                "DataRows": [
                  [
                    "05/05/2014  12:45:42",
                    "05/05/2014  12:49:51"
                  ]
                ]
              }
            }
          ],
          "Tags": [
            "@mytag"
          ],
          "Result": {
            "WasExecuted": true,
            "WasSuccessful": true
          }
        }
      ],
      "Result": {
        "WasExecuted": true,
        "WasSuccessful": true
      },
      "Tags": []
    },
    "Result": {
      "WasExecuted": true,
      "WasSuccessful": true
    }
  },
  {
    "RelativeFolder": "SelfTests\\QdfAnalysisOfArsCcEcnDiffDeltasWithLoadedFiles.feature",
    "Feature": {
      "Name": "QdfAnalysisOfArsCcEcnDiffDeltasWithLoadedFiles",
      "Description": "In order to test the analysis of the diff delta summaries\r\nAs a tester\r\nI want to load pre run result files and analyse them",
      "FeatureElements": [
        {
          "Name": "Load and analyse 6 summary files and check combination deltas",
          "Description": "",
          "Steps": [
            {
              "Keyword": "Given",
              "NativeKeyword": "Given ",
              "Name": "I have loaded all \"Summary.csv\" files"
            },
            {
              "Keyword": "When",
              "NativeKeyword": "When ",
              "Name": "I summarise the analysis and output the result to \"csv\""
            },
            {
              "Keyword": "Then",
              "NativeKeyword": "Then ",
              "Name": "the combination with the highest diffdelta sum is \"AGBPUSDMt4Micro2DiffDeltaSummary.csv\" with 4662000.000000004"
            }
          ],
          "Tags": [
            "@mytag"
          ],
          "Result": {
            "WasExecuted": true,
            "WasSuccessful": true
          }
        },
        {
          "Name": "Load and analyse 6 summary files and check book deltas",
          "Description": "",
          "Steps": [
            {
              "Keyword": "Given",
              "NativeKeyword": "Given ",
              "Name": "I have loaded all \"Summary.csv\" files"
            },
            {
              "Keyword": "When",
              "NativeKeyword": "When ",
              "Name": "I summarise the analysis and output the result to \"csv\""
            },
            {
              "Keyword": "Then",
              "NativeKeyword": "Then ",
              "Name": "the book with the highest diffdelta sum is \"A\" with 7736000.000000004"
            }
          ],
          "Tags": [
            "@mytag"
          ],
          "Result": {
            "WasExecuted": true,
            "WasSuccessful": true
          }
        },
        {
          "Name": "Load and analyse 6 summary files and check server deltas",
          "Description": "",
          "Steps": [
            {
              "Keyword": "Given",
              "NativeKeyword": "Given ",
              "Name": "I have loaded all \"Summary.csv\" files"
            },
            {
              "Keyword": "When",
              "NativeKeyword": "When ",
              "Name": "I summarise the analysis and output the result to \"csv\""
            },
            {
              "Keyword": "Then",
              "NativeKeyword": "Then ",
              "Name": "the server with the highest diffdelta sum is \"Mt4Micro2\" with 4696000.000000004"
            }
          ],
          "Tags": [
            "@mytag"
          ],
          "Result": {
            "WasExecuted": true,
            "WasSuccessful": true
          }
        },
        {
          "Name": "Load and analyse 6 summary files and check symbol deltas",
          "Description": "",
          "Steps": [
            {
              "Keyword": "Given",
              "NativeKeyword": "Given ",
              "Name": "I have loaded all \"Summary.csv\" files"
            },
            {
              "Keyword": "And",
              "NativeKeyword": "And ",
              "Name": "I have loaded all \"Deltas.csv\" files as lists of deltas"
            },
            {
              "Keyword": "When",
              "NativeKeyword": "When ",
              "Name": "I summarise the analysis and output the result to \"csv\""
            },
            {
              "Keyword": "Then",
              "NativeKeyword": "Then ",
              "Name": "the symbol with the highest diffdelta sum is \"GBPUSD\" with 7983000.000000004"
            }
          ],
          "Tags": [
            "@mytag"
          ],
          "Result": {
            "WasExecuted": true,
            "WasSuccessful": true
          }
        },
        {
          "Name": "Load and analyse 6 Delta files and check for unknown data",
          "Description": "",
          "Steps": [
            {
              "Keyword": "Given",
              "NativeKeyword": "Given ",
              "Name": "I have loaded all \"Deltas.csv\" files as lists of deltas"
            },
            {
              "Keyword": "Then",
              "NativeKeyword": "Then ",
              "Name": "these combinations contain unknown data",
              "TableArgument": {
                "HeaderRow": [
                  "Combinations"
                ],
                "DataRows": [
                  [
                    "BGBPUSDMt4Micro2DiffDeltas.csv"
                  ],
                  [
                    "BEURNZDMt4ProDiffDeltas.csv"
                  ]
                ]
              }
            }
          ],
          "Tags": [
            "@mytag"
          ],
          "Result": {
            "WasExecuted": true,
            "WasSuccessful": true
          }
        }
      ],
      "Result": {
        "WasExecuted": true,
        "WasSuccessful": true
      },
      "Tags": [
        "@SnapOnCc"
      ]
    },
    "Result": {
      "WasExecuted": true,
      "WasSuccessful": true
    }
  },
  {
    "RelativeFolder": "SelfTests\\MySqlQUickStart.feature",
    "Feature": {
      "Name": "MySqlQUickStart",
      "Description": "In order to access MySql Data\r\nAs a tester\r\nI want a working linq provider",
      "FeatureElements": [
        {
          "Name": "Create connection",
          "Description": "",
          "Steps": [
            {
              "Keyword": "Given",
              "NativeKeyword": "Given ",
              "Name": "I have created a connection to \"MySqlDataContextSubstitute\""
            },
            {
              "Keyword": "When",
              "NativeKeyword": "When ",
              "Name": "I retrieve cc_tbl_position_section data from cc"
            },
            {
              "Keyword": "Then",
              "NativeKeyword": "Then ",
              "Name": "the cc_tbl_position_section data from cc has 4 records"
            }
          ],
          "Tags": [
            "@SelfTest"
          ],
          "Result": {
            "WasExecuted": true,
            "WasSuccessful": true
          }
        }
      ],
      "Result": {
        "WasExecuted": true,
        "WasSuccessful": true
      },
      "Tags": []
    },
    "Result": {
      "WasExecuted": true,
      "WasSuccessful": true
    }
  },
  {
    "RelativeFolder": "SelfTests\\LoadDailySnapshot.feature",
    "Feature": {
      "Name": "LoadDataOnce",
      "Description": "In order to avoid multiple data loads\r\nAs a tester\r\nI want to be to load data once for a feature and have it available for all scenarios",
      "FeatureElements": [
        {
          "Name": "Load Test Data and Check it's there",
          "Description": "",
          "Steps": [
            {
              "Keyword": "Then",
              "NativeKeyword": "Then ",
              "Name": "there are 350 deals in AllQdfDeals and 3722 records in CcToolData"
            }
          ],
          "Tags": [
            "@mytag"
          ],
          "Result": {
            "WasExecuted": true,
            "WasSuccessful": true
          }
        },
        {
          "Name": "Load Test Data and Check it's there again",
          "Description": "",
          "Steps": [
            {
              "Keyword": "Then",
              "NativeKeyword": "Then ",
              "Name": "there are 350 deals in AllQdfDeals and 3722 records in CcToolData"
            }
          ],
          "Tags": [],
          "Result": {
            "WasExecuted": true,
            "WasSuccessful": true
          }
        }
      ],
      "Background": {
        "Name": "Load data",
        "Description": "",
        "Steps": [
          {
            "Keyword": "Given",
            "NativeKeyword": "Given ",
            "Name": "I have already loaded QDF deal data from \"TestData\\AllQdfDeals.csv\""
          },
          {
            "Keyword": "And",
            "NativeKeyword": "And ",
            "Name": "I have already loaded CCTool data from \"TestData\\CcToolData.csv\""
          },
          {
            "Keyword": "And",
            "NativeKeyword": "And ",
            "Name": "I have already aggregated the QdfDeal Data and CcToolData"
          }
        ],
        "Tags": [],
        "Result": {
          "WasExecuted": false,
          "WasSuccessful": false
        }
      },
      "Result": {
        "WasExecuted": true,
        "WasSuccessful": true
      },
      "Tags": []
    },
    "Result": {
      "WasExecuted": true,
      "WasSuccessful": true
    }
  },
  {
    "RelativeFolder": "SelfTests\\GetDailySnapshotFromCC.feature",
    "Feature": {
      "Name": "GetDailySnapshotFromCC",
      "Description": "In order to get daily snapshot delatas\r\nAs a Tester\r\nI want to get the nearest snapshot to midday for each position",
      "FeatureElements": [
        {
          "Name": "Get 2 daily snapshots",
          "Description": "",
          "Steps": [
            {
              "Keyword": "Given",
              "NativeKeyword": "Given ",
              "Name": "I have daily ccTool snapshot data from \"-3D\" to \"+2D\""
            }
          ],
          "Tags": [
            "@mytag"
          ],
          "Result": {
            "WasExecuted": true,
            "WasSuccessful": false
          }
        }
      ],
      "Result": {
        "WasExecuted": true,
        "WasSuccessful": false
      },
      "Tags": []
    },
    "Result": {
      "WasExecuted": true,
      "WasSuccessful": false
    }
  },
  {
    "RelativeFolder": "SelfTests\\GenerateDistinctDiffDeltas.feature",
    "Feature": {
      "Name": "GenerateDistinctDiffDeltas",
      "Description": "In order to get all relevant data for diff delta comparisons\r\nAs a tester\r\nI want an exhaustive list of distinct book, symbol and server combinations for a specified date range",
      "FeatureElements": [
        {
          "Name": "Generate Distinct DiffDeltas",
          "Description": "",
          "Steps": [
            {
              "Keyword": "Given",
              "NativeKeyword": "Given ",
              "Name": "I want to analyse these diff deltas by timeslice in",
              "TableArgument": {
                "HeaderRow": [
                  "StartDate",
                  "EndDate",
                  "NumberOfDiffs"
                ],
                "DataRows": [
                  [
                    "03-Feb-2014",
                    "09-Mar-2014",
                    "20"
                  ]
                ]
              }
            },
            {
              "Keyword": "Then",
              "NativeKeyword": "Then ",
              "Name": "the number of parameter sets is 846"
            }
          ],
          "Tags": [
            "@mytag"
          ],
          "Result": {
            "WasExecuted": true,
            "WasSuccessful": true
          }
        }
      ],
      "Result": {
        "WasExecuted": true,
        "WasSuccessful": true
      },
      "Tags": []
    },
    "Result": {
      "WasExecuted": true,
      "WasSuccessful": true
    }
  },
  {
    "RelativeFolder": "SelfTests\\ConnectToSignalsDb.feature",
    "Feature": {
      "Name": "ConnectToSignalsDb",
      "Description": "In order to get comparison data\r\nAs a Tester\r\nI want to be able to get data from the SignalsDB",
      "FeatureElements": [
        {
          "Name": "Get a server name from Signals DB",
          "Description": "",
          "Steps": [
            {
              "Keyword": "Given",
              "NativeKeyword": "Given ",
              "Name": "I have connected to SignalsCompareData"
            },
            {
              "Keyword": "When",
              "NativeKeyword": "When ",
              "Name": "I query SignalsCompareData for server \"Mt4Pro\""
            },
            {
              "Keyword": "Then",
              "NativeKeyword": "Then ",
              "Name": "the server should be \"Mt4Pro\""
            }
          ],
          "Tags": [
            "@mytag"
          ],
          "Result": {
            "WasExecuted": true,
            "WasSuccessful": true
          }
        }
      ],
      "Result": {
        "WasExecuted": true,
        "WasSuccessful": true
      },
      "Tags": []
    },
    "Result": {
      "WasExecuted": true,
      "WasSuccessful": true
    }
  },
  {
    "RelativeFolder": "SelfTests\\ArsQdfReconciliationWithLoadedFiles.feature",
    "Feature": {
      "Name": "ArsQdfReconciliationWithLoadedFiles",
      "Description": "In order to test the reconciliation functionality\r\nAs a tester\r\nI want to be able to re-use the same input data",
      "FeatureElements": [
        {
          "Name": "Load Test Data and Compare",
          "Description": "",
          "Steps": [
            {
              "Keyword": "Given",
              "NativeKeyword": "Given ",
              "Name": "I have loaded QDF deal data from \"TestData\\AllQdfDeals.csv\""
            },
            {
              "Keyword": "And",
              "NativeKeyword": "And ",
              "Name": "I have loaded CCTool data from \"TestData\\CcToolData.csv\""
            },
            {
              "Keyword": "When",
              "NativeKeyword": "When ",
              "Name": "I compare the loaded QDF and CC data"
            },
            {
              "Keyword": "Then",
              "NativeKeyword": "Then ",
              "Name": "the data should not match"
            }
          ],
          "Tags": [
            "@mytag"
          ],
          "Result": {
            "WasExecuted": true,
            "WasSuccessful": true
          }
        }
      ],
      "Result": {
        "WasExecuted": true,
        "WasSuccessful": true
      },
      "Tags": []
    },
    "Result": {
      "WasExecuted": true,
      "WasSuccessful": true
    }
  },
  {
    "RelativeFolder": "QdfAnalysisOfArsCcEcnDiffDeltasSnapOnCc.feature",
    "Feature": {
      "Name": "QdfAnalysisOfArsCcEcnDiffDeltasSnapOnCc",
      "Description": "In order to reconcile Qdf Data\r\nAs a tester\r\nI want to be able to find the biggest differences in the data streams",
      "FeatureElements": [
        {
          "Name": "Analyse diff deltas in B Book GBPUSD Mt4Pro",
          "Description": "",
          "Steps": [
            {
              "Keyword": "Given",
              "NativeKeyword": "Given ",
              "Name": "I want to analyse diff deltas by timeslice in",
              "TableArgument": {
                "HeaderRow": [
                  "Book",
                  "Symbol",
                  "Server",
                  "StartDate",
                  "EndDate",
                  "NumberOfDiffs"
                ],
                "DataRows": [
                  [
                    "B",
                    "GBP/USD",
                    "Mt4Pro",
                    "05-May-2014",
                    "06-May-2014",
                    "20"
                  ]
                ]
              }
            },
            {
              "Keyword": "When",
              "NativeKeyword": "When ",
              "Name": "I analyse the diff deltas by timeslice"
            },
            {
              "Keyword": "Then",
              "NativeKeyword": "Then ",
              "Name": "The diff delta analysis is output to \"csv\""
            },
            {
              "Keyword": "And",
              "NativeKeyword": "And ",
              "Name": "no diff delta is greater than 10 percent of the mean position for the timeslice"
            }
          ],
          "Tags": [],
          "Result": {
            "WasExecuted": false,
            "WasSuccessful": false
          }
        },
        {
          "Name": "Analyse diff deltas in B Book EURNZD Mt4Pro",
          "Description": "",
          "Steps": [
            {
              "Keyword": "Given",
              "NativeKeyword": "Given ",
              "Name": "I want to analyse diff deltas by timeslice in",
              "TableArgument": {
                "HeaderRow": [
                  "Book",
                  "Symbol",
                  "Server",
                  "StartDate",
                  "EndDate",
                  "NumberOfDiffs"
                ],
                "DataRows": [
                  [
                    "B",
                    "EUR/NZD",
                    "Mt4Pro",
                    "05-May-2014",
                    "06-May-2014",
                    "20"
                  ]
                ]
              }
            },
            {
              "Keyword": "When",
              "NativeKeyword": "When ",
              "Name": "I analyse the diff deltas by timeslice"
            },
            {
              "Keyword": "Then",
              "NativeKeyword": "Then ",
              "Name": "The diff delta analysis is output to \"csv\""
            },
            {
              "Keyword": "And",
              "NativeKeyword": "And ",
              "Name": "no diff delta is greater than 10 percent of the mean position for the timeslice"
            }
          ],
          "Tags": [],
          "Result": {
            "WasExecuted": false,
            "WasSuccessful": false
          }
        },
        {
          "Name": "Analyse diff deltas in A Book GBPUSD Mt4Pro",
          "Description": "",
          "Steps": [
            {
              "Keyword": "Given",
              "NativeKeyword": "Given ",
              "Name": "I want to analyse diff deltas by timeslice in",
              "TableArgument": {
                "HeaderRow": [
                  "Book",
                  "Symbol",
                  "Server",
                  "StartDate",
                  "EndDate",
                  "NumberOfDiffs"
                ],
                "DataRows": [
                  [
                    "A",
                    "GBP/USD",
                    "Mt4Pro",
                    "05-May-2014",
                    "06-May-2014",
                    "20"
                  ]
                ]
              }
            },
            {
              "Keyword": "When",
              "NativeKeyword": "When ",
              "Name": "I analyse the diff deltas by timeslice"
            },
            {
              "Keyword": "Then",
              "NativeKeyword": "Then ",
              "Name": "The diff delta analysis is output to \"csv\""
            },
            {
              "Keyword": "And",
              "NativeKeyword": "And ",
              "Name": "no diff delta is greater than 10 percent of the mean position for the timeslice"
            }
          ],
          "Tags": [],
          "Result": {
            "WasExecuted": false,
            "WasSuccessful": false
          }
        },
        {
          "Name": "Analyse diff deltas in A Book GBPUSD Mt4Micro2",
          "Description": "",
          "Steps": [
            {
              "Keyword": "Given",
              "NativeKeyword": "Given ",
              "Name": "I want to analyse diff deltas by timeslice in",
              "TableArgument": {
                "HeaderRow": [
                  "Book",
                  "Symbol",
                  "Server",
                  "StartDate",
                  "EndDate",
                  "NumberOfDiffs"
                ],
                "DataRows": [
                  [
                    "A",
                    "GBP/USD",
                    "Mt4Micro2",
                    "05-May-2014",
                    "06-May-2014",
                    "20"
                  ]
                ]
              }
            },
            {
              "Keyword": "When",
              "NativeKeyword": "When ",
              "Name": "I analyse the diff deltas by timeslice"
            },
            {
              "Keyword": "Then",
              "NativeKeyword": "Then ",
              "Name": "The diff delta analysis is output to \"csv\""
            },
            {
              "Keyword": "And",
              "NativeKeyword": "And ",
              "Name": "no diff delta is greater than 10 percent of the mean position for the timeslice"
            }
          ],
          "Tags": [],
          "Result": {
            "WasExecuted": false,
            "WasSuccessful": false
          }
        },
        {
          "Name": "Analyse diff deltas in A Book EURNZD Mt4Micro2",
          "Description": "",
          "Steps": [
            {
              "Keyword": "Given",
              "NativeKeyword": "Given ",
              "Name": "I want to analyse diff deltas by timeslice in",
              "TableArgument": {
                "HeaderRow": [
                  "Book",
                  "Symbol",
                  "Server",
                  "StartDate",
                  "EndDate",
                  "NumberOfDiffs"
                ],
                "DataRows": [
                  [
                    "A",
                    "EUR/NZD",
                    "Mt4Micro2",
                    "05-May-2014",
                    "06-May-2014",
                    "20"
                  ]
                ]
              }
            },
            {
              "Keyword": "When",
              "NativeKeyword": "When ",
              "Name": "I analyse the diff deltas by timeslice"
            },
            {
              "Keyword": "Then",
              "NativeKeyword": "Then ",
              "Name": "The diff delta analysis is output to \"csv\""
            },
            {
              "Keyword": "And",
              "NativeKeyword": "And ",
              "Name": "no diff delta is greater than 10 percent of the mean position for the timeslice"
            }
          ],
          "Tags": [],
          "Result": {
            "WasExecuted": false,
            "WasSuccessful": false
          }
        },
        {
          "Name": "Analyse diff deltas in B Book GBPUSD Mt4Micro2",
          "Description": "",
          "Steps": [
            {
              "Keyword": "Given",
              "NativeKeyword": "Given ",
              "Name": "I want to analyse diff deltas by timeslice in",
              "TableArgument": {
                "HeaderRow": [
                  "Book",
                  "Symbol",
                  "Server",
                  "StartDate",
                  "EndDate",
                  "NumberOfDiffs"
                ],
                "DataRows": [
                  [
                    "B",
                    "GBP/USD",
                    "Mt4Micro2",
                    "05-May-2014",
                    "06-May-2014",
                    "20"
                  ]
                ]
              }
            },
            {
              "Keyword": "When",
              "NativeKeyword": "When ",
              "Name": "I analyse the diff deltas by timeslice"
            },
            {
              "Keyword": "Then",
              "NativeKeyword": "Then ",
              "Name": "The diff delta analysis is output to \"csv\""
            },
            {
              "Keyword": "And",
              "NativeKeyword": "And ",
              "Name": "no diff delta is greater than 10 percent of the mean position for the timeslice"
            }
          ],
          "Tags": [],
          "Result": {
            "WasExecuted": false,
            "WasSuccessful": false
          }
        },
        {
          "Name": "Analyse diff deltas in A Book EURUSD Mt4Classic2",
          "Description": "",
          "Steps": [
            {
              "Keyword": "Given",
              "NativeKeyword": "Given ",
              "Name": "I want to analyse diff deltas by timeslice in",
              "TableArgument": {
                "HeaderRow": [
                  "Book",
                  "Symbol",
                  "Server",
                  "StartDate",
                  "EndDate",
                  "NumberOfDiffs"
                ],
                "DataRows": [
                  [
                    "A",
                    "EUR/USD",
                    "Mt4Classic2",
                    "05-May-2014",
                    "06-May-2014",
                    "20"
                  ]
                ]
              }
            },
            {
              "Keyword": "When",
              "NativeKeyword": "When ",
              "Name": "I analyse the diff deltas by timeslice"
            },
            {
              "Keyword": "Then",
              "NativeKeyword": "Then ",
              "Name": "The diff delta analysis is output to \"csv\""
            },
            {
              "Keyword": "And",
              "NativeKeyword": "And ",
              "Name": "no diff delta is greater than 10 percent of the mean position for the timeslice"
            }
          ],
          "Tags": [],
          "Result": {
            "WasExecuted": false,
            "WasSuccessful": false
          }
        },
        {
          "Name": "Analyse diff deltas in B Book EURUSD Mt4Classic2",
          "Description": "",
          "Steps": [
            {
              "Keyword": "Given",
              "NativeKeyword": "Given ",
              "Name": "I want to analyse diff deltas by timeslice in",
              "TableArgument": {
                "HeaderRow": [
                  "Book",
                  "Symbol",
                  "Server",
                  "StartDate",
                  "EndDate",
                  "NumberOfDiffs"
                ],
                "DataRows": [
                  [
                    "B",
                    "EUR/USD",
                    "Mt4Classic2",
                    "05-May-2014",
                    "06-May-2014",
                    "20"
                  ]
                ]
              }
            },
            {
              "Keyword": "When",
              "NativeKeyword": "When ",
              "Name": "I analyse the diff deltas by timeslice"
            },
            {
              "Keyword": "Then",
              "NativeKeyword": "Then ",
              "Name": "The diff delta analysis is output to \"csv\""
            },
            {
              "Keyword": "And",
              "NativeKeyword": "And ",
              "Name": "no diff delta is greater than 10 percent of the mean position for the timeslice"
            }
          ],
          "Tags": [],
          "Result": {
            "WasExecuted": false,
            "WasSuccessful": false
          }
        },
        {
          "Name": "Analyse All Distinct DiffDeltas",
          "Description": "",
          "Steps": [
            {
              "Keyword": "Given",
              "NativeKeyword": "Given ",
              "Name": "I want to analyse these diff deltas by timeslice in",
              "TableArgument": {
                "HeaderRow": [
                  "StartDate",
                  "EndDate",
                  "NumberOfDiffs"
                ],
                "DataRows": [
                  [
                    "03-Feb-2014",
                    "09-Mar-2014",
                    "20"
                  ]
                ]
              }
            },
            {
              "Keyword": "When",
              "NativeKeyword": "When ",
              "Name": "I analyse the diff deltas by timeslice and output to \"csv\""
            },
            {
              "Keyword": "Then",
              "NativeKeyword": "Then ",
              "Name": "I can summarise the analysis and output the result to \"csv\""
            }
          ],
          "Tags": [],
          "Result": {
            "WasExecuted": false,
            "WasSuccessful": false
          }
        }
      ],
      "Result": {
        "WasExecuted": false,
        "WasSuccessful": false
      },
      "Tags": [
        "@SnapOnCc",
        "@LongRunning"
      ]
    },
    "Result": {
      "WasExecuted": false,
      "WasSuccessful": false
    }
  },
  {
    "RelativeFolder": "QdfAnalysisOfArsCcEcnDiffDeltas.feature",
    "Feature": {
      "Name": "QdfAnalysisOfArsCcEcnDiffDeltas",
      "Description": "In order to reconcile Qdf Data\r\nAs a tester\r\nI want to be able to find the biggest differences in the data streams",
      "FeatureElements": [
        {
          "Name": "Analyse diff deltas in B Book GBPUSD Mt4Pro",
          "Description": "",
          "Steps": [
            {
              "Keyword": "Given",
              "NativeKeyword": "Given ",
              "Name": "I want to analyse diff deltas by timeslice in",
              "TableArgument": {
                "HeaderRow": [
                  "Book",
                  "Symbol",
                  "Server",
                  "StartDate",
                  "EndDate",
                  "NumberOfDiffs"
                ],
                "DataRows": [
                  [
                    "B",
                    "GBP/USD",
                    "Mt4Pro",
                    "03-Feb-2014",
                    "09-Mar-2014",
                    "20"
                  ]
                ]
              }
            },
            {
              "Keyword": "When",
              "NativeKeyword": "When ",
              "Name": "I analyse the diff deltas by timeslice"
            },
            {
              "Keyword": "Then",
              "NativeKeyword": "Then ",
              "Name": "The diff delta analysis is output to \"csv\""
            },
            {
              "Keyword": "And",
              "NativeKeyword": "And ",
              "Name": "no diff delta is greater than 10 percent of the mean position for the timeslice"
            }
          ],
          "Tags": [
            "@mytag"
          ],
          "Result": {
            "WasExecuted": false,
            "WasSuccessful": false
          }
        },
        {
          "Name": "Analyse All Distinct DiffDeltas",
          "Description": "",
          "Steps": [
            {
              "Keyword": "Given",
              "NativeKeyword": "Given ",
              "Name": "I want to analyse these diff deltas by timeslice in",
              "TableArgument": {
                "HeaderRow": [
                  "StartDate",
                  "EndDate",
                  "NumberOfDiffs"
                ],
                "DataRows": [
                  [
                    "03-Feb-2014",
                    "09-Mar-2014",
                    "20"
                  ]
                ]
              }
            },
            {
              "Keyword": "When",
              "NativeKeyword": "When ",
              "Name": "I analyse the diff deltas by timeslice and output to \"csv\""
            }
          ],
          "Tags": [
            "@LongRunning"
          ],
          "Result": {
            "WasExecuted": false,
            "WasSuccessful": false
          }
        }
      ],
      "Result": {
        "WasExecuted": false,
        "WasSuccessful": false
      },
      "Tags": []
    },
    "Result": {
      "WasExecuted": false,
      "WasSuccessful": false
    }
  },
  {
    "RelativeFolder": "ArsQdfCCReconciliation.feature",
    "Feature": {
      "Name": "Deal Reconciliation",
      "Description": "In Order to have faith in the QDF data \r\nAs a quant user\r\nI want a reconciliation of ARS QDF against CC",
      "FeatureElements": [
        {
          "Name": "Book A Deals for server C1 in symbol EURUSD in QDF should equal CC from 5 minutes ago",
          "Description": "",
          "Steps": [],
          "Tags": [
            "@Broken"
          ],
          "Result": {
            "WasExecuted": false,
            "WasSuccessful": false
          }
        }
      ],
      "Background": {
        "Name": "Load data",
        "Description": "",
        "Steps": [
          {
            "Keyword": "Given",
            "NativeKeyword": "Given ",
            "Name": "I have already loaded QDF deal data",
            "TableArgument": {
              "HeaderRow": [
                "startTime",
                "endTime"
              ],
              "DataRows": [
                [
                  "-5D",
                  "+4D"
                ]
              ]
            }
          },
          {
            "Keyword": "And",
            "NativeKeyword": "And ",
            "Name": "I have already loaded CCTool data"
          }
        ],
        "Tags": [],
        "Result": {
          "WasExecuted": false,
          "WasSuccessful": false
        }
      },
      "Result": {
        "WasExecuted": false,
        "WasSuccessful": false
      },
      "Tags": []
    },
    "Result": {
      "WasExecuted": false,
      "WasSuccessful": false
    }
  }
]);