using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using WebAutomationSeleniumTests.SeleniumEasy.Common;
using System.Collections.Generic;

namespace WebAutomationSeleniumTests.SeleniumEasy.PageObjects
{
    sealed class SelectDropdownList
    {
        private IWebDriver Driver { get; set; }
        private IXpathReader XpathReader { get; set; }

        private IWebElement SingleSelectList => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.SelectDropdownList>().SingleSelectList));
        private IWebElement SingleSelectListResult => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.SelectDropdownList>().SingleSelectListResult));
        private IWebElement MultiSelectList => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.SelectDropdownList>().MultiSelectList));
        private IWebElement FirstSelectedButton => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.SelectDropdownList>().FirstSelectedButton));
        private IWebElement GetAllSelectedButton => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.SelectDropdownList>().GetAllSelectedButton));
        private IWebElement MultiSelectListResult => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.SelectDropdownList>().MultiSelectListResult));

        public void SelectSingleSelectList(string value)
        {
            var list = new SelectElement(SingleSelectList);
            list.SelectByValue(value);
        }
        public string GetSingleSelectListResult() => SingleSelectListResult.Text;
        public void SelectMultiSelectList(IReadOnlyList<string> values)
        {
            var selectList = new SelectElement(MultiSelectList);
            foreach(var value in values)
            {
                selectList.SelectByText(value);
            }
        }
        public void ClickFirstSelectedButton() => FirstSelectedButton.Click();
        public void ClickGetAllSelectedButton() => GetAllSelectedButton.Click();
        public string GetMultiSelectListResult() => MultiSelectListResult.Text;
    }
}