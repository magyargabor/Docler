Feature: HomeTextSite
 
@mytag
Scenario: Checking HomePage Site Text
	Given Click to Home Button
	When Searching for Text in "p" tag		
	Then The Text equals with "This site is dedicated to perform some exercises and demonstrate automated web testing."
