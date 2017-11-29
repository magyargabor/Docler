Feature: HomePageLogo

@mytag
Scenario: Checking Home Page Logo
	Given Click to Home Button	
	When Searching for logo on Home Page
	Then HomePageLogo is visible on screen	