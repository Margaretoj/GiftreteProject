Feature: Login
	In order to access my Dashboard an the giftrete website 
	I want to be able to Log in

@mytag
Scenario: Login
	Given I navigate to the giftrete website
    When I click on sign in
	And I enter valid email address 
	And I enter valid password 
	And I click on the sign in button
	Then I should be logged in and dashboard page should be displayed



Scenario: Invalid Login
	Given I navigate to the giftrete website
    When I click on sign in
	And I enter valid email address 
	And I enter incorrect password 
	And I click on the sign in button
	Then I should not be logged in and message "Your login credentials are invalid. Please try again." should be displayed