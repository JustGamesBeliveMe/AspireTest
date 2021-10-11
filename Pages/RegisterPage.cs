using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using AspireTest.Pages;
namespace AspireTest.Pages
{
    class RegisterPage : BasePage
    {
        private IWebElement TxtFullName => Driver.FindElement(By.XPath("//input[@name='full_name']"));
        private IWebElement TxtPreferredName => Driver.FindElement(By.XPath("//input[@name='preferred_name']"));
        private IWebElement TxtEmail => Driver.FindElement(By.XPath("//input[@name='email']"));
        private IWebElement TxtPhone => Driver.FindElement(By.XPath("//input[@name='phone']"));
        private IWebElement LsContry => Driver.FindElement(By.XPath("//div[@class='q-img__content absolute-full']"));
        private IWebElement LsSearch => Driver.FindElement(By.XPath("//input[@type='search']"));
        private IWebElement ChxAgree => Driver.FindElement(By.XPath("//div[@class='q-checkbox__bg absolute']"));
        private IWebElement BtnContinue => Driver.FindElement(By.XPath("//span[@class='q-btn__wrapper col row q-anchor--skip']/span"));
        private By Message => By.XPath("//div[@class='q-card']//div[@class='text-subtitle1 text-weight-bold']");
        private IWebElement PopupMessage => Driver.FindElement(By.XPath("//div[@class='q-card']//div[@class='text-subtitle1 text-weight-bold']"));

        private IWebElement LoginButton => Driver.FindElement(By.XPath("//div[@class='q-card']//a[@type='button']"));

        public RegisterPage EnterDetailsToRegisterForm()
        {
            TxtFullName.SendKeys("Auto fullname");
            TxtPreferredName.SendKeys("Auto prefername");
            TxtEmail.SendKeys("Autoemail@test.com");
            CommonAction.SelectListValue(LsContry, "Viet Nam (+84)");
            TxtPhone.SendKeys("123456");
            CommonAction.SelectListValue(LsSearch, "Google");
            ChxAgree.Click();
            BtnContinue.Click();
            return this;
        }

        public void VerifyRetrictedPopupDisplay(out bool result)
        {
            WaitForElement(Message);
            string expectedMessage = "Account exists, try login instead!";
            string accutalMessage = PopupMessage.Text.ToString().Trim();
            if (accutalMessage == expectedMessage
                 && LoginButton.Displayed)
            {
                result = true;
            }
            else 
            {
                result = false;
                Console.WriteLine("Message "+ accutalMessage + " doesn't martch with expected message " + expectedMessage);
            }
        }
    }
}
