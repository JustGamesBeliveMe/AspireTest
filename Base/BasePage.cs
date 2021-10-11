using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AspireTest
{
    public class BasePage
    {
        public static IWebDriver Driver { get; set; }
        public static WebDriverWait wait => new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

        public static void WaitForElement(By by) 
        {
            WebDriverWait Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
        }
    }
}
