using BlueOcean20.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Xml.Serialization;

namespace BlueOcean20.PageObjects
{
    class AccountDetailsFormPage
    {
        IWebDriver driver;
        IWebElement clickOnSignIn => driver.FindElement(By.XPath("/html/body/section[1]/nav/div/div[1]/a[3]"));
        IWebElement enterValidEmailAddress => driver.FindElement(By.XPath("//*[@id='user_email']"));
        IWebElement enterValidPassword => driver.FindElement(By.XPath("//*[@id='user_password']"));
        IWebElement clickOnSignInButton => driver.FindElement(By.XPath("//*[@id='btn_signin']"));
        IWebElement clickOnAccountDetailsTab => driver.FindElement(By.XPath("//*[@id='content']/div/div/div/div/div/div[1]/ul/a[2]"));
        IWebElement clickOnEditDetails => driver.FindElement(By.XPath("//*[@id='lnk_edit_personal']"));
        IWebElement clickOnTitleDropDown => driver.FindElement(By.XPath("//*[@id='name_prefix']"));
        IWebElement selectTitle => driver.FindElement(By.XPath("//*[@id='name_prefix']/option[3]"));
        IWebElement editFirstName => driver.FindElement(By.XPath("//*[@id='first_name']"));
        IWebElement editLastName => driver.FindElement(By.XPath("//*[@id='last_name']"));
        IWebElement clickAndEditDateOfBirth => driver.FindElement(By.XPath("//*[@id='dateofbirth']"));
        IWebElement editEmailAddress => driver.FindElement(By.XPath("//*[@id='email']"));
        IWebElement clickOnPhoneCountryIcon => driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/div/div/div[1]/div/div/div/div/form[1]/div[6]/div/div/div"));
        IWebElement selectNewCountry => driver.FindElement(By.XPath("//*[@id='iti - item - ng']/div/div"));
        IWebElement editPhoneNumber => driver.FindElement(By.XPath("//*[@id='mobile']"));
        IWebElement editAboutTextBox => driver.FindElement(By.XPath("//*[@id='about']"));
        IWebElement selectNo => driver.FindElement(By.XPath("//*[@id='content']/div/div/div/div/div/div[1]/div/div/div/div/form[1]/div[8]/div[2]/label[2]"));
        IWebElement submitButton => driver.FindElement(By.XPath("//*[@id='btn_save_details']"));
        IWebElement alertMessage => driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/div/div/div[5]/div/div[2]/a"));

        public void AlertMessage()
        {
            alertMessage.Click();
 
        }
        public void SubmitButton()
        {
            submitButton.Click();
        }

        public void SelectNo()
        {
            selectNo.Click();
        }
        public void EditAboutTextBox()
        {
            editAboutTextBox.SendKeys("Testing testing 123");
        }

        public void EditPhoneNumber()
        {
            editPhoneNumber.Clear();
            editPhoneNumber.SendKeys("7951196345");

        }
        public void SelectNewCountry()
        {
            selectNewCountry.Click();
        }


        public void ClickOnPhoneCountryIcon()
        {
            clickOnPhoneCountryIcon.Click();
        }
        public void EditEmailAddress()
        {
            editEmailAddress.Clear();
            editEmailAddress.SendKeys("adenike51@gmail.co.uk");
        }


        public void ClickAndEditDateOfBirth()
        {
            clickAndEditDateOfBirth.Click();
            clickAndEditDateOfBirth.SendKeys("May 25, 2020");
        }
        public void EditLastName()
        {
            editLastName.Clear();
            editLastName.SendKeys("John");
        }
        public void EditFirstName()
        {
            editFirstName.Clear();
            editFirstName.SendKeys("Sandra");
        }
        public void SelectTitle()
        {
            selectTitle.Click();
          
        }

        public void ClickOnTitleDropDown()
        {
            clickOnTitleDropDown.Click();
        }
        public void ClickOnEditDetails()
        {
            clickOnEditDetails.Click();
        }
        public void ClickOnAccountDetailsTab()
        {
            clickOnAccountDetailsTab.Click();
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


        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://www.qa.giftrete.com/");
        }

        public AccountDetailsFormPage()
        {
            driver = Hook.driver;
        }
    }
}
