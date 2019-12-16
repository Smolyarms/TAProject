Feature: Secondary Stories Title
	

@mytest_2
Scenario Outline: Compare secondary stories title
	Given I open BBC news page
	And  open news page
	When I get secondary titles text
	Then titles should be SecondaryTitles
	| SecondaryTitles                                    |
	| London Bridge attack victim had 'lust for life'    |
	| China due to introduce face scans for mobile users |
	| Malta businessman charged over journalist murder   |
	| Dance, pray, love: Being gay in Cambodia           |
	| Cosmic Crisp: New apple that 'lasts for a year'    |
