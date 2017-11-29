Feature: HomeTextWelcome
 
@mytag
Scenario: Checking HomePage Welcome Text
	Given Click to Home Button		
	When Searching for Text in "h1" tag		
	Then The Text equals with "Welcome to the Docler Holding QA Department"
