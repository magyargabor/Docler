Feature: FormHelloPage

@mytag
Scenario Outline: Checking Form Input Values
	Given Click to Form Button		
	When Type <value> to the input field
	And Push Submit Button
	Then Got the <result>
Examples:
	| value   | result         |
	| John    | Hello John!    |
	| Sophia  | Hello Sophia!  |
	| Charlie | Hello Charlie! |
	| Emily   | Hello Emily!   |


