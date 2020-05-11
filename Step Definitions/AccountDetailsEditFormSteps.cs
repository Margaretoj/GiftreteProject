using BlueOcean20.PageObjects;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace BlueOcean20.Step_Definitions
{
    [Binding]
    public class AccountDetailsEditFormSteps
    {
        AccountDetailsFormPage accountDetailsFormPage;

        public AccountDetailsEditFormSteps()
        {
            accountDetailsFormPage = new AccountDetailsFormPage();
        }


        [When(@"I click on the account details tab")]
        public void WhenIClickOnTheAccountDetailsTab()
        {
            accountDetailsFormPage.ClickOnAccountDetailsTab();
        }
        
        [When(@"I click on the edit details")]
        public void WhenIClickOnTheEditDetails()
        {
            accountDetailsFormPage.ClickOnEditDetails();
        }
        
        [When(@"I click on title drop down")]
        public void WhenIClickOnTitleDropDown()
        {
            accountDetailsFormPage.ClickOnTitleDropDown();
        }
        
        [When(@"I select title from dropdown box")]
        public void WhenISelectTitleFromDropdownBox()
        {
            accountDetailsFormPage.SelectTitle();
        }
        
        [When(@"I edit first name")]
        public void WhenIEditFirstName()
        {
            accountDetailsFormPage.EditFirstName();
        }
        
        [When(@"I edit last name")]
        public void WhenIEditLastName()
        {
            accountDetailsFormPage.EditLastName();
        }
        
        [When(@"I click and edit date of birth")]
        public void WhenIClickOnCalender()
        {
            accountDetailsFormPage.ClickAndEditDateOfBirth();
        }
        
 
        [When(@"I edit email address")]
        public void WhenIEditEmailAddress()
        {
            accountDetailsFormPage.EditEmailAddress();
        }
        
        [When(@"I click on Phone country code icon")]
        public void WhenIClickOnPhoneCountryCodeIcon()
        {
            accountDetailsFormPage.ClickOnPhoneCountryIcon();
        }
        
        [When(@"I edit Phone number")]
        public void WhenIEditPhoneNumber()
        {
            accountDetailsFormPage.EditPhoneNumber();
        }
        
        [When(@"I edit about text box")]
        public void WhenIEditAboutTextBox()
        {
            accountDetailsFormPage.EditAboutTextBox();
        }
        
        [When(@"I click to select Yes or No for community activity emails")]
        public void WhenIClickToSelectYesOrNoForCommunityActivityEmails()
        {
            accountDetailsFormPage.SelectNo();
        }
        
        [When(@"I click on submit button")]
        public void WhenIClickOnSubmitButton()
        {
            accountDetailsFormPage.SubmitButton();
        }

        [Then(@"successful notification alert is displayed")]
        public void ThenSuccessfulNotificationAlertIsDisplayed()
        {
            accountDetailsFormPage.AlertMessage();
        }


        [Then(@"my personal information should be edited successfully")]
        public void ThenMyPersonalInformationShouldBeEditedSuccessfully()
        {
            
        }
    }
}
