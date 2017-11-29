Feature: HomeButtonNavigate

@mytag
Scenario: Checking Home Button Navigation
	Given Click to Home Button
	When Get HomePage URL
	Then I am on Home Page		
