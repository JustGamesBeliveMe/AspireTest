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
    class OTPPage : BasePage
    {
        public BusinessRolePage PassOTP() 
        {
            By XPath = By.XPath("//div[@class='digit-input aspire-field']/div");
            WaitForElement(XPath);
            IWebElement OTPfield = Driver.FindElement(By.XPath("//input"));
            OTPfield.SendKeys("1");
            OTPfield.SendKeys("2");
            OTPfield.SendKeys("3");
            OTPfield.SendKeys("4");
            return new BusinessRolePage();
        }
    }
}
