Feature: FormPageLogo

@mytag
Scenario: Checking Form Page Logo
	Given Click to Form Button
	When Searching for logo on Form Page
	Then FormPageLogo is visible on Screen