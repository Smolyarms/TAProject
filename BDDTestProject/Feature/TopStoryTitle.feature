Feature: Top story title
	

@mytag
Scenario: Compare first story title
	Given I open BBC news page
	And  open news page
	When I get top title text
	Then the result should be <result>

	Examples: 
	| result                                              |
	| Protests erupt across India over citizenship law    |

