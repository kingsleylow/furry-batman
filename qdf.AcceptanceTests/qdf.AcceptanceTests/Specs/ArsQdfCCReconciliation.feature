﻿Feature: Deal Reconciliation
In Order to have faith in the QDF data 
As a quant user
I want a reconciliation of ARS QDF against CC

Background:Load data
	Given I have already loaded QDF deal data
	| startTime | endTime |
	| -5D       | +4D     |
	And I have already loaded CCTool data
#	And I have already aggregated the QdfDeal Data and CcToolData by day

#Scenario: Book A Deals for server C1 in symbol EURUSD in QDF should equal CC from 5 minutes ago
#	Given I have QDF Deal Data
#	| server | symbol | startTime | endTime |
#	| C1     | EURUSD | -3D       | +2D     |
#	#Given I have QDF Deal Data
#	#| server | symbol | 
#	#| C1     | EURUSD |  
#		And I have CC data
#	When I compare QDF and CC data
#	Then the data should match
@Broken
Scenario: Book A Deals for server C1 in symbol EURUSD in QDF should equal CC from 5 minutes ago
	#When I compare QDF and CC data

#Scenario: Book A Deals for server C1 in symbol EURUSD in QDF should equal CC from 5 minutes ago
#	Given I have QDF Deal Data
#	| server | symbol | startTime | endTime |
#	| C1     | EURUSD | -3D       | +2D     |
#	#Given I have QDF Deal Data
#	#| server | symbol | 
#	#| C1     | EURUSD |  
#		And I have CC data
#	When I compare QDF and CC data
#	Then the data should match