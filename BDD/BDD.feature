Feature: BDD
	Birthday management, which can add entries

@mytag
Scenario: A new birthday
	Given  I have my software Birthday 
	And I succesed login in system
	Then I should add birthday my friend
	When I fill all data in form
	| Name | Familia  | Date       |
	| Igor | Vikrorov | 20.04.2007 |
	And I press add
	Then the result should be 20.04.2007