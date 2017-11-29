Feature: FormPageTitle
	
@mytag
Scenario: Checking Form Page title
	Given Click to Form Button
	When Get FormPage Title
	Then FormPageTitle is "UI Testing Site"	