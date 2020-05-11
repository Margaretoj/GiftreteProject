Feature: AccountDetailsEditForm
	In order to manage my account details on the giftrete website
	I want to be able to edit my account details
@mytag
Scenario: Edit Account details From
	Given I navigate to the giftrete website
    When I click on sign in
	And I enter valid email address 
	And I enter valid password 
	And I click on the sign in button
	And I click on the account details tab
	And I click on the edit details
	And I click on title drop down
	And I select title from dropdown box
	And I edit first name 
	And I edit last name 
	And I click and edit date of birth 
	And I edit email address 
	And I click on Phone country code icon
	And I edit Phone number 
	And I edit about text box 
	And I click to select Yes or No for community activity emails
	And I click on submit button
	Then successful notification message is displayed 
	Then I click on close button
	#Then my personal information should be edited successfully