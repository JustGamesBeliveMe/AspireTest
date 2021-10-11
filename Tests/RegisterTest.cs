using AspireTest.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace AspireTest
{
     class RegisterTest : BasePage
    {
        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.Navigate().GoToUrl("https://feature-qa-automation.customer-frontend.staging.aspireapp.com/");
        }

        [Test]
        public void VerifyUserIsNOTAbleToRegristerWithSameAccount()
        {
            //Given user navigate to Register Page
            var registerPage = new LoginPage().NavigateToRegisterPage();

            //When user enter details to RegisterForm
            registerPage.EnterDetailsToRegisterForm();

            //Then user can see Retricted duplicate popup display
            registerPage.VerifyRetrictedPopupDisplay(out bool result);
            Assert.IsTrue(result);
        }

        [TearDown]
        public void close_Browser()
        {
            Driver.Quit();
        }
    }
}