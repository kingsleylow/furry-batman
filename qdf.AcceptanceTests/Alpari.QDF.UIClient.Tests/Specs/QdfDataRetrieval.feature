﻿@UKUSQDF_60 @ClientSideFiltering @TeardownRedisConnection
Feature: QdfDataRetrieval
	In order to access deal data in Redis QDF
	As a QDF Analyst
	I want a UI to retrieve and filter deal data

# expected results based on data generated by https://stash.corp.alpari.com/projects/GRU/repos/qdf.acceptancetests/browse/qdf.AcceptanceTests/qdf.AcceptanceTests/Specs/SelfTests/RedisConnectionSelfTests.feature
# as at https://stash.corp.alpari.com/projects/GRU/repos/qdf.acceptancetests/commits/0d6c19d790dcb3f057236efbf5c65f5cbbbdf0d7
# June 2nd 2014, and amended for subsequent data reloads

Scenario: Filter deals by date
	Given I have the following search criteria for qdf deals
	 | ConvertedStartTime   | ConvertedEndTime     |
	 | 05/05/2014  12:45:42 | 05/05/2014  12:49:51 |
	When I retrieve the qdf deal data
	Then no retrieved deal will have a timestamp outside "05/05/2014  12:45:42" to "05/05/2014  12:49:51"
	And the count of retrieved deals will be 113

Scenario: Filter deals by server
	Given I have the following search criteria for qdf deals
	 | Server    | ConvertedStartTime   | ConvertedEndTime     |
	 | Mt4Micro2 | 05/05/2014  12:45:42 | 05/05/2014  12:49:51 |
	When I retrieve the qdf deal data
	Then all retrieved deals will have be for server "Mt4Micro2"
	And the count of retrieved deals will be 13

Scenario: Filter deals by multiple servers
	Given I have the following search criteria for qdf deals
	 | Servers                          | ConvertedStartTime   | ConvertedEndTime     |
	 | Mt4Micro2,Mt4Classic1,Mt4Market1 | 05/05/2014  12:45:42 | 05/05/2014  12:49:51 |
	When I retrieve the qdf deal data
	Then the deals retrieved for each server will have the following counts
	| Server      | Count |
	| Mt4Micro2   | 13    |
	| Mt4Classic1 | 2     |
	| Mt4Market1  | 2     |
	And the count of retrieved deals will be 17

Scenario: Filter deals by symbol
	Given I have the following search criteria for qdf deals
	 | Symbol | ConvertedStartTime   | ConvertedEndTime     |
	 | EURUSD | 05/05/2014  12:45:42 | 05/05/2014  12:49:51 |
	When I retrieve the qdf deal data
	Then all retrieved deals will have be for symbol "EURUSD"
	And the count of retrieved deals will be 33

Scenario: Filter deals by multiple symbols
	Given I have the following search criteria for qdf deals
	 | Symbol               | ConvertedStartTime   | ConvertedEndTime     |
	 | EURUSD,NZDUSD,AUDNZD | 05/05/2014  12:45:42 | 05/05/2014  12:49:51 |
	When I retrieve the qdf deal data
	Then the deals retrieved for each symbol will have the following counts
	| Symbol | Count |
	| EURUSD | 33    |
	| NZDUSD | 4     |
	| AUDNZD | 1     |
	And the count of retrieved deals will be 38

Scenario: Filter deals by book A
	Given I have the following search criteria for qdf deals
	 | Book | ConvertedStartTime   | ConvertedEndTime     |
	 | A    | 05/05/2014  12:45:42 | 05/05/2014  12:49:51 |
	When I retrieve the qdf deal data
	Then all retrieved deals will have be for book "A"
	And the count of retrieved deals will be 33

Scenario: Filter deals by book B
	Given I have the following search criteria for qdf deals
	 | Book | ConvertedStartTime   | ConvertedEndTime     |
	 | B    | 05/05/2014  12:45:42 | 05/05/2014  12:49:51 |
	When I retrieve the qdf deal data
	Then all retrieved deals will have be for book "B"
	And the count of retrieved deals will be 80

Scenario: Filter deals by book symbol and server
	Given I have the following search criteria for qdf deals
	 | Book | Symbol | Server      | ConvertedStartTime   | ConvertedEndTime     |
	 | B    | EURUSD | Mt4Classic2 | 05/05/2014  12:45:42 | 05/05/2014  12:49:51 |
	When I retrieve the qdf deal data
	Then all retrieved deals will have be for book "B"
	And all retrieved deals will have be for symbol "EURUSD"
	And all retrieved deals will have be for server "Mt4Classic2"
	And the count of retrieved deals will be 4

Scenario: Filter deals by multiple symbols and servers
	Given I have the following search criteria for qdf deals
	 | Symbol               | Servers                       | ConvertedStartTime   | ConvertedEndTime     |
	 | EURUSD,GBPUSD,AUDJPY | Currenex,Mt5Pro,Mt4JapaneseC1 | 05/05/2014  12:45:42 | 05/05/2014  12:49:51 |
	When I retrieve the qdf deal data
	Then the deals retrieved for each symbol will have the following counts
	| Symbol | Count |
	| EURUSD | 16    |
	| GBPUSD | 2     |
	| AUDJPY | 1     |
	Then the deals retrieved for each server will have the following counts
	| Server        | Count |
	| Mt4JapaneseC1 | 12    |
	| Currenex      | 5     |
	| Mt5Pro        | 2     |
	And the count of retrieved deals will be 19

Scenario: Filter deals by multiple symbols and servers and B Book
	Given I have the following search criteria for qdf deals
	 | Book | Symbol                      | Servers                       | ConvertedStartTime   | ConvertedEndTime     |
	 | B    | EURUSD,GBPUSD,AUDJPY,USDCHF | Currenex,Mt5Pro,Mt4JapaneseC1 | 05/05/2014  12:45:42 | 05/05/2014  12:49:51 |
	When I retrieve the qdf deal data
	Then the deals retrieved for each symbol will have the following counts
	| Symbol | Count |
	| EURUSD | 16    |
	| GBPUSD | 2     |
	| AUDJPY | 1     |
	| USDCHF | 2     |
	Then the deals retrieved for each server will have the following counts
	| Server        | Count |
	| Mt4JapaneseC1 | 12    |
	| Currenex      | 5     |
	| Mt5Pro        | 4     |
	And the count of retrieved deals will be 21

Scenario: Filter deals by multiple symbols and servers and A Book
	Given I have the following search criteria for qdf deals
	 | Book | Symbol                      | Servers                       | ConvertedStartTime   | ConvertedEndTime     |
	 | A    | EURUSD,GBPUSD,AUDJPY,USDCHF | Currenex,Mt5Pro,Mt4JapaneseC1 | 05/05/2014  12:45:42 | 05/05/2014  12:49:51 |
	When I retrieve the qdf deal data
	Then the deals retrieved for each symbol will have the following counts
	| Symbol | Count |
	| USDCHF | 2     |
	Then the deals retrieved for each server will have the following counts
	| Server        | Count |
	| Mt5Pro        | 2     |
	And the count of retrieved deals will be 2