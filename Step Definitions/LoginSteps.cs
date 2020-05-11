using BlueOcean20.PageObjects;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace BlueOcean20.Step_Definitions
{
    [Binding]
    public class LoginSteps
        
    {
        LoginPage loginPage;

        public LoginSteps()
        {
          loginPage = new LoginPage();
        }


        [When(@"I click on sign in")]
        public void WhenIClickOnSignIn()
        {
            loginPage.ClickOnSignIn();
        }
        
        [When(@"I enter valid email address")]
        public void WhenIEnterValidEmailAddress()
        {
            loginPage.EnterValidEmailAddress();
        }
        
        [When(@"I enter valid password")]
        public void WhenIEnterValidPassword()
        {
            loginPage.EnterValidPassord();
        }
        
        [When(@"I click on the sign in button")]
        public void WhenIClickOnTheSignInButton()
        {
            loginPage.ClickOnSignInButton();
        }
               
        [Then(@"I should be logged in and dashboard page should be displayed")]
        public void ThenIShouldBeLoggedInAndDashboardPageShouldBeDisplayed()
        {
            Assert.True(loginPage.DashboardPageElementDisplayed());
        }

        [When(@"I enter incorrect password")]
        public void WhenIEnterIncorrectPassword()
        {
            loginPage.IncorrectPassword();
        }

        [Then(@"I should not be logged in and message ""(.*)"" should be displayed")]
        public void ThenIShouldNotBeLoggedInAndMessageShouldBeDisplayed(string errorMessage)
        {
            Assert.AreEqual(errorMessage, loginPage.GetErrorMessage());
        }


    }
}
