Feature: NullReference

Scenario: Reproduce NullReferenceException
	Given I set null value to ScenarioContext
	When I get value from ScenarioContext
	Then NullReferenceException is thrown