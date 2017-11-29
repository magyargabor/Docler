Feature: FormBoxAndButton

@mytag
Scenario: Checking Form Box And Button Is Visible
	Given Click to Form Button	
	When Searching Input Box
	And Searching Submit Button
	Then Box is visible
	And Button is visible
