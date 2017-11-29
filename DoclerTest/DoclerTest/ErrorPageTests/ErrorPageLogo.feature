Feature: ErrorPageLogo

@mytag
Scenario: Checking Error Page Logo
	Given Click to Error Button
	When Searching for logo on Error Page
	Then ErrorPageLogo is visible on screen	