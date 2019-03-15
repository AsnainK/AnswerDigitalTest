Feature: InfinitScroll
	In order to view the whole page
	As a user
	I want to be able to scroll to the bottom and the top of a page

@mytag
Scenario: Scroll up and down twice
	Given I navigate to the infinite scroll page
	When I scroll to the bottom of the page
	And I scroll to the top of the page
	And I scroll to the bottom of the page
	And I scroll to the top of the page
	Then I should be able to see the infinite scroll 
