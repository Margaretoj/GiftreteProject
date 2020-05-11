using BlueOcean20.Hooks;
using BlueOcean20.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueOcean20.PageObjects
{
    class LoginPage

    {
        IWebDriver driver;

        Wait wait = new Wait();

        IWebElement clickOnSignIn => driver.FindElement(By.XPath("/html/body/section[1]/nav/div/div[1]/a[3]"));
        IWebElement enterValidEmailAddress => driver.FindElement(By.XPath("//*[@id='user_email']"));
        IWebElement enterValidPassword => driver.FindElement(By.XPath("//*[@id='user_password']"));
        IWebElement clickOnSignInButton => driver.FindElement(By.XPath("//*[@id='btn_signin']"));
        IWebElement dashboardPageElementDisplayed => driver.FindElement(By.XPath("//*[@id='content']/div/div/div/div/div/div[1]/div[1]/div/div[2]/h2/span"));
        IWebElement incorrectLoginPassword => driver.FindElement(By.XPath("//*[@id='user_password']"));
        IWebElement errorMessageDisplayed => driver.FindElement(By.XPath("//*[@id='dng_msg_t']"));

        public string GetErrorMessage()
        {
            return wait.WaitForElement(driver,errorMessageDisplayed).Text;

        }
        public void IncorrectPassword()
        {
            incorrectLoginPassword.SendKeys("best");
        }

        public bool DashboardPageElementDisplayed()
        {
            return dashboardPageElementDisplayed.Displayed;
        }
        public void ClickOnSignIn()
        {
            clickOnSignIn.Click();
        }

        public void EnterValidEmailAddress()
        {
            enterValidEmailAddress.SendKeys("adenike51@gmail.com");
        }

        public void EnterValidPassord()
        {
            enterValidPassword.SendKeys("chocolate1");
        }

        public void ClickOnSignInButton()
        {
            clickOnSignInButton.Click();
        }

        public LoginPage()
        {
            driver = Hook.driver;
        }
       
        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://www.qa.giftrete.com/");
        }
    }
}
