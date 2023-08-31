Feature: SauceDemo

A short summary of the feature

@CT-0001
Scenario: Login Test_CT0001
	Given I have access to login page
	When I make a login using this data
		| Login         | Password     |
		| standard_user | secret_sauce |
	Then I have access to home page
