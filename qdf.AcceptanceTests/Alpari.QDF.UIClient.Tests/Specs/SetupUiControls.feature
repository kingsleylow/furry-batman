﻿@TeardownRedisConnection
Feature: SetupUIControls
	In order to select search options
	As a QDF Analyst
	I want search options to be accurate and complete

@mytag
Scenario: Set up trade server list
	Given I filter deals by server
	Then the list of server options should be:
	| Server               |
	| Unknown              |
	| Mt4CapitalBankJordan |
	| Mt4Pro               |
	| Currenex             |
	| Mt4Micro1            |
	| Mt4Micro2            |
	| Mt4Classic1          |
	| Mt4Classic2          |
	| Mt4JapaneseC1        |
	| Mt5Pro               |
	| Mt4MarketMena        |
	| Mt4SpreadBetting     |
	| Mt4Market1           |
	| Mt4B2B               |
	| Coverage101          |
	| Coverage601          |
	| Coverage602          |
	| Coverage604          |

Scenario: Set up book list
	Given I filter deals by book
	Then the list of book options should be:
	| Book |
	| None |
	| A    |
	| B    |

@UKUSQDF_69
Scenario: Set up datatypes list
	Given I choose the type of data to be queried
	Then the list of data type options should be:
	| DataType     |
	| CurrentState |
	| deals        |
	| PriceQuote   |
	| ecn-deals    |

@UKUSQDF_69
Scenario: Set up default datatype
	Given I choose the type of data to be queried
	Then the default datatype should be "deals"

Scenario: set up symbol list
	Given I filter deals by symbol
	Then the list of symbol options should be:
	| Symbol |
	| AUDCAD |
	| AUDCHF |
	| AUDJPY |
	| AUDNZD |
	| AUDSGD |
	| AUDUSD |
	| AUDZAR |
	| CADCHF |
	| CADJPY |
	| CADSGD |
	| CHFJPY |
	| CHFSGD |
	| DE30   |
	| EUR50  |
	| EURAUD |
	| EURCAD |
	| EURCHF |
	| EURCZK |
	| EURDKK |
	| EURGBP |
	| EURHKD |
	| EURHUF |
	| EURJPY |
	| EURMXN |
	| EURNOK |
	| EURNZD |
	| EURPLN |
	| EURRUB |
	| EURSEK |
	| EURSGD |
	| EURTRY |
	| EURUSD |
	| EURZAR |
	| FRA40  |
	| GBPAUD |
	| GBPCAD |
	| GBPCHF |
	| GBPJPY |
	| GBPNOK |
	| GBPNZD |
	| GBPSEK |
	| GBPSGD |
	| GBPUSD |
	| GBPZAR |
	| HKDJPY |
	| MXNJPY |
	| NOKJPY |
	| NOKSEK |
	| NQ100  |
	| NZDCAD |
	| NZDCHF |
	| NZDJPY |
	| NZDSGD |
	| NZDUSD |
	| NZDZAR |
	| SEKJPY |
	| SEKNOK |
	| SGDJPY |
	| UK100  |
	| US30   |
	| US500  |
	| USDCAD |
	| USDCHF |
	| USDCNH |
	| USDCZK |
	| USDDKK |
	| USDHKD |
	| USDHUF |
	| USDJPY |
	| USDMXN |
	| USDNOK |
	| USDPLN |
	| USDRUB |
	| USDSEK |
	| USDSGD |
	| USDTRY |
	| USDZAR |
	| XAGUSD |
	| XAUUSD |
	| ZARJPY |

