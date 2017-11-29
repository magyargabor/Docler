Feature: FormButtonStatus

@mytag
Scenario: Checking Form Button Status
	Given Click to Form Button
	When Get Form Button Status
	Then Is Form Button Active		
