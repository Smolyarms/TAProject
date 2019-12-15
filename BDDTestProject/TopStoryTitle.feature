Feature: Top story title
	

@mytag
Scenario: Assert first story title
	Given I open BBC news page
	And  open news page
	When I get top title text
	Then the result should be <result>

	Examples: 
	| result                                              |
	| "UK government reviews terrorists' prison release"  |
