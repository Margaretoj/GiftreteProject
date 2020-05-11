  using BlueOcean20.Hooks;
using BlueOcean20.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueOcean20.PageOjects
{
    public class RegistrationPage
    {
        IWebDriver driver;

        Wait wait = new Wait();

        IWebElement clickOnCreateAccount => driver.FindElement(By.XPath("/html/body/section[1]/nav/div/div[1]/a[2]"));
        IWebElement enterFirstName => driver.FindElement(By.XPath("//*[@id='first_name']"));
        IWebElement enterLastName => driver.FindElement(By.XPath("//*[@id='last_name']"));
        IWebElement enterEmailAddress => driver.FindElement(By.XPath("//*[@id='email']"));
        IWebElement selectCountryCode => driver.FindElement(By.XPath("//*[@id='nav-register']/form/div[4]/div/div/div"));
        IWebElement selectUnitedKingdom => driver.FindElement(By.XPath("//*[@id='iti-item-gb']/div/div"));
        IWebElement enterPhoneNumber => driver.FindElement(By.XPath("//*[@id='mobile']"));
        IWebElement enterPassword=> driver.FindElement(By.XPath("//*[@id='password']"));
        IWebElement enterConfirmPassword => driver.FindElement(By.XPath("//*[@id='confirm_password']"));
        IWebElement enterIncorrectConfirmPassword => driver.FindElement(By.XPath("//*[@id='confirm_password']"));
        IWebElement clickOnCaptcha => driver.FindElement(By.XPath("//*[@id='recaptcha - anchor']/div[1]"));
        IWebElement clickOnRegisterButton => driver.FindElement(By.XPath("//*[@id='btn_register']"));
        IWebElement successfulRegistrationMessage => driver.FindElement(By.XPath("//*[@id='suc_id']"));
        IWebElement invalidConfirmPasswordMessage => driver.FindElement(By.XPath("//*[@id='dng_msg']"));

        public string GetTextforInvalidConfirmPasswordMessage()
        {
            return wait.WaitForElement(driver, invalidConfirmPasswordMessage).Text;
        }
        public void EnterIncorrectConfirmPassword()
        {
            enterIncorrectConfirmPassword.SendKeys("google");
        }

        public string GetTextForRegistration()

        {
           // return successfulRegistrationMessage.Text:
            return wait.WaitForElement(driver, successfulRegistrationMessage).Text;
        }

        public void ClickOnRegisterButton()
        { 
            clickOnRegisterButton.Click();
        }

        public void ClickOnCaptcha()
        {
            clickOnCaptcha.Click();
        }

        public void EnterConfirmPassword()
        {
            enterConfirmPassword.SendKeys("telegram1");
        }

        public void EnterPassword()
        {
            enterPassword.SendKeys("telegram1");
        }

        public void EnterPhoneNumber()
        {
            enterPhoneNumber.SendKeys("07951106345");
        }
        public void SelectUnitedKingdom()
        {
            selectUnitedKingdom.Click();
        }
        public void SelectCountryCode()
        {
            selectCountryCode.Click();
        }

        public void EnterEmailAddress()
        {
           // enterEmailAddress.SendKeys("oyin23@gmail.com");
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            enterEmailAddress.SendKeys("username"+ randomInt + "@gmail.com");
        }

        public void EnterLastName()
        {
            enterLastName.SendKeys("jonny");
        }

        public void EnterFirstName()
        {
            enterFirstName.SendKeys("deji");

        }
        public void ClickOnCreateAccount()
        {
            clickOnCreateAccount.Click();
        }


        public void NavigateToWebsite()

        {
            driver.Navigate().GoToUrl("https://www.qa.giftrete.com/");
        }

        public RegistrationPage()
        { 
            driver = Hook.driver;
        }
        
    }
}
