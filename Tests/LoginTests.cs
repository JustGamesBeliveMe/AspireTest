using AspireTest.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace AspireTest
{
     class LoginTests : BasePage
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
        public void VerifyUserIsAbleToLoginAspire()
        {
            //Given user navigate to login page 

            //When user login with valid account
            var OTPPage = new LoginPage().LoginWithTestAccount();

            //And pass the OTP verifition
            var BusinessRolePage = OTPPage.PassOTP();

            //Then user can see BusinessRolePage display
            BusinessRolePage.VerifyBusinessRolePageDisplay(out bool result);
            Assert.IsTrue(result);
        }

        [TearDown]
        public void close_Browser()
        {
            Driver.Quit();
        }
    }
}