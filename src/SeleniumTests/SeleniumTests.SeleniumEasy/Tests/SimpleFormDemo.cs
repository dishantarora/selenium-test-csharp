using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SeleniumTests.SeleniumEasy.PageObjects;
using System;

namespace SeleniumTests.SeleniumEasy.Tests
{
    [TestFixture]
    public class SimpleFromDemo
    {
        private IWebDriver Driver { get; set; }

        [SetUp]
        public void Setup()
        {
            Driver = new FirefoxDriver(@"C:\Users\disha\OneDrive\Documents\Web Drivers");
            Driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/");
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().PageLoad = new TimeSpan(0, 5, 0);
            Driver.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 1, 0);
        }
        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
        [Test]
        public void EnsureSingleInputFieldWorks()
        {
            HomePage homepage = new HomePage(Driver);
            homepage.GoToInputFormsTabOnNavigationBar();
            homepage.SelectSimpleFormDemoItemFromDropDownList();
            SimpleFormDemo simpleFormDemoPage = new SimpleFormDemo(Driver);
            simpleFormDemoPage.EnterMessage("sample message");
            simpleFormDemoPage.SubmitMessage();
            var message = simpleFormDemoPage.GetMessage();
            Assert.AreEqual("sample message", message, "Passed");
        }
        [Test]
        public void EnsureTwoInputFieldWorks()
        {
            HomePage homepage = new HomePage(Driver);
            homepage.GoToInputFormsTabOnNavigationBar();
            homepage.SelectSimpleFormDemoItemFromDropDownList();
            SimpleFormDemo simpleFormDemoPage = new SimpleFormDemo(Driver);
            simpleFormDemoPage.EnterValueA("10");
            simpleFormDemoPage.EnterValueB("20");
            simpleFormDemoPage.SubmitGetTotalButton();
            var total = simpleFormDemoPage.GetTotal();
            Assert.AreEqual("30", total, "Passed");
        }
    }
}