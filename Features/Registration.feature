Feature: Registration
	In order to use the giftrete website's features  
	I want to be able to register 

@mytag
Scenario: Registration
	Given I navigate to the giftrete website
	When I click on create account	
	And I enter my first name 
	And I enter my last name 
	And I enter my email address 
	And I click to select country code
	And I select United Kingdom
	And I enter my phone number 
	And I enter my password 
	And I enter confirm password 
	#And I click on captcha 
	And I click on the register button 
    Then the message "Thank you for signing up! You may now login" should be displayed 

	Scenario: Invalid Registration
	Given I navigate to the giftrete website
	When I click on create account	
	And I enter my first name 
	And I enter my last name 
	And I enter my email address 
	And I click to select country code
	And I select United Kingdom
	And I enter my phone number 
	And I enter my password 
	And I enter incorrect confirm password 
	#And I click on captcha 
	And I click on the register button 
    Then error message "The Confirm Password field does not match the Password field." should be displayed 