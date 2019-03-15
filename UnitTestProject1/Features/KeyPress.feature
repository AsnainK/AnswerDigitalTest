Feature: Key Presses
	In order to test the application
	As a tester
	I want to be told my key presses

@mytag
Scenario Outline: Key Press
	Given I navigate to the Key Presses Application
	When I press '<Button>' 
	Then I should see '<Text>' presented in the You Pressed field

	Examples:
	
	| Button | Text  |
	| Home   | HOME  |
	| Enter  | ENTER |
	| Up     | UP    |
	| Space  | SPACE |