Feature: FormButtonNavigate

@mytag
Scenario: Checking Form Button Navigation
	Given Click to Form Button
	When Get FormPage URL
	Then I am on Form Page		