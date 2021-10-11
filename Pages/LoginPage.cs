using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
namespace AspireTest.Pages
{
    class LoginPage : BasePage
    {
        private IWebElement TxtUserName => Driver.FindElement(By.XPath("//input[@name='username']"));
        private IWebElement LnkRegrister => Driver.FindElement(By.CssSelector(".login-step-start__register a"));
        private IWebElement BtnNext => Driver.FindElement(By.XPath("//*[@type='submit']"));

        public OTPPage LoginWithTestAccount()
        {
            TxtUserName.SendKeys("+84" + "123456");
            BtnNext.Click();
            return new OTPPage();
        }
        public RegisterPage NavigateToRegisterPage()
        {
            LnkRegrister.Click();
            return new RegisterPage();
        }
    }
}
