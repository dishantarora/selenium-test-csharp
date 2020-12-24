using OpenQA.Selenium;
using WebAutomationSeleniumTests.SeleniumEasy.Common;
using System.Collections.ObjectModel;

namespace WebAutomationSeleniumTests.SeleniumEasy.PageObjects
{
    sealed class CheckboxDemo
    {
        private IWebDriver Driver { get; set; }
        private IXpathReader XpathReader { get; set; }

        private IWebElement SingleCheckbox => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.CheckboxDemo>().SingleCheckbox));
        private IWebElement SuccessMessage => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.CheckboxDemo>().SuccessMessage));
        private ReadOnlyCollection<IWebElement> Options => Driver.FindElements(
            By.XPath(XpathReader.GetValue<Models.CheckboxDemo>().Options));
        private IWebElement CheckAllButton => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.CheckboxDemo>().CheckAllButton));

        public CheckboxDemo(IWebDriver driver,
                            IXpathReader xpathReader)
        {
            Driver = driver;
            XpathReader = xpathReader;
        }

        public void CheckSingleCheckbox() => SingleCheckbox.Click();
        public string GetSuccessMessage() => SuccessMessage.Text;
        public void CheckOptions(int index) => Options[index].Click();
        public void UnCheckAllOptions() => CheckAllButton.Click();
    }
}