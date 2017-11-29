Feature: ErrorPageTitle
	
@mytag
Scenario: Checking Error Page title
	Given Click to Error Button
	When Get ErrorPage Title
	Then ErrorPageTitle is "UI Testing Site"