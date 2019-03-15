Feature: Account Log In 

	In order to manage my account
	As an account holder
	I want to be able to log in and out of my account

@mytag
Scenario: Succesful Log In
	Given I am on the Form Authentication page
	And I enter my username "tomsmith"
	And I enter my password "SuperSecretPassword!"
	When I press Login
	Then I should be logged in to my account

Scenario: Unsuccesful Log In
	Given I am on the Form Authentication page
	And I enter my username "incorrectusername"
	And I enter my password "SuperSecretPassword!"
	When I press Login
	Then I should be told my username is invalid

Scenario: Log Out
	Given I am logged in to my account
	When I click the Log Out button
	Then I should be succesfully logged out of my account
