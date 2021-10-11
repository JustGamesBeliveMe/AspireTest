using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspireTest
{
    public class CommonAction : BasePage
    {
        public static void SelectListValue(IWebElement list, string selectValue)
        {
            list.Click();
            //var roleList = list.GetAttribute("role");
            IWebElement liOption = Driver.FindElement(By.XPath($"//div[@role='listbox']//div[text()='{selectValue}']"));
            liOption.Click();
        }
    }
}
