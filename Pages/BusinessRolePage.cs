using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Linq;
namespace AspireTest.Pages
{
    class BusinessRolePage : BasePage
    {
        private IWebElement SubTitle1 => Driver.FindElement(By.XPath("//div[@class='business-role-step-role-selector__option-wrapper']//div[@class='text-weight-bold text-secondary'][1]"));
        private IWebElement SubTitle2 => Driver.FindElement(By.XPath("//div[@class='business-role-step-role-selector__option-wrapper']//div[@class='text-weight-bold text-secondary'][1]"));

        public void VerifyBusinessRolePageDisplay(out bool result)
        {
            WaitForElement(By.XPath("//div[@class='business-role-step-role-selector__option-wrapper']//div[@class='text-weight-bold text-secondary'][1]"));
            string expectedTitle = "I want to open an Aspire account";
            string accualTitle = SubTitle1.Text.ToString().Trim();
            if (SubTitle1.Displayed && expectedTitle == accualTitle)
                result = true;
            else
                result = false; 
        }
    }
}
