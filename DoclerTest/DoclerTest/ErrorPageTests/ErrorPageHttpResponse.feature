Feature: ErrorPageHttpResponse
	
@mytag
Scenario: Checking Error Page Http Response
	Given Click to Error Button
	When Get ErrorPage Http Response Code
	Then Code is 404