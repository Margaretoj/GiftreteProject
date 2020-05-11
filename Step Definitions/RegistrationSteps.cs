using BlueOcean20.PageOjects;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace BlueOcean20.Step_Definitions
{
    [Binding]
    public class RegistrationSteps
    {
        RegistrationPage registrationPage;

        public RegistrationSteps()
        {
            registrationPage = new RegistrationPage();
        }
        [Given(@"I navigate to the giftrete website")]
        public void GivenINavigateToTheGiftreteWebsite()
        {
            registrationPage.NavigateToWebsite();
        }
        
        [When(@"I click on create account")]
        public void WhenIClickOnCreateAccount()
        {
            registrationPage.ClickOnCreateAccount();
        }
        
        [When(@"I enter my first name")]
        public void WhenIEnterMyFirstName()
        {
            registrationPage.EnterFirstName();
        }
        
        [When(@"I enter my last name")]
        public void WhenIEnterMyLastName()
        {
            registrationPage.EnterLastName();
        }
        
        [When(@"I enter my email address")]
        public void WhenIEnterMyEmailAddress()
        {
            registrationPage.EnterEmailAddress();
        }
        
        [When(@"I click to select country code")]
        public void WhenIClickToSelectCountryCode()
        {
            registrationPage.SelectCountryCode();
        }

        [When(@"I select United Kingdom")]
        public void WhenISelectUnitedKingdom()
        {
            registrationPage.SelectUnitedKingdom();
        }

        [When(@"I enter my phone number")]
        public void WhenIEnterMyPhoneNumber()
        {
            registrationPage.EnterPhoneNumber();
        }
        
        [When(@"I enter my password")]
        public void WhenIEnterMyPassword()
        {
            registrationPage.EnterPassword();
        }
        
        [When(@"I enter confirm password")]
        public void WhenIEnterConfirmPassword()
        {
            registrationPage.EnterConfirmPassword();
        }

        [When(@"I enter incorrect confirm password")]
        public void WhenIEnterIncorrectConfirmPassword()
        {
            registrationPage.EnterIncorrectConfirmPassword();
        }

        [When(@"I click on captcha")]
        public void WhenIClickOnCaptcha()
        {
            registrationPage.ClickOnCaptcha();
        }
        
        [When(@"I click on the register button")]
        public void WhenIClickOnTheRegisterButton()
        {
            registrationPage.ClickOnRegisterButton();
        }
               
        [Then(@"the message ""(.*)"" should be displayed")]
        public void ThenTheMessageShouldBeDisplayed(string successfulRegistrationMessage)
        {
            Assert.AreEqual(successfulRegistrationMessage, registrationPage.GetTextForRegistration());
        }

        [Then(@"error message ""(.*)"" should be displayed")]
        public void ThenErrorMessageShouldBeDisplayed(string errorMessage)
        {
            Assert.AreEqual(errorMessage, registrationPage.GetTextforInvalidConfirmPasswordMessage());
        }


    }
}
