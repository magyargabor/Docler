Feature: HomePageTitle

@mytag
Scenario: Checking Home Page title
	Given Click to Home Button
	When Get HomePage Title 
	Then HomePageTitle is "UI Testing Site" 	