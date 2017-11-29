Feature: HomeButtonStatus

@mytag
Scenario: Checking Home Button Status
	Given Click to Home Button
	When Get Home Button Status
	Then Is Home Button Active
