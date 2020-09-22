using OpenQA.Selenium;
using SeleniumTests.SeleniumEasy.Common;

namespace SeleniumTests.SeleniumEasy.PageObjects
{
    sealed class SimpleFormDemo
    {
        private IWebDriver Driver { get; set; }
        private IXpathReader XpathReader { get; set; }

        private IWebElement EnterMessageInputField => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.SimpleFormDemo>().EnterMessageInputField));
        private IWebElement ShowMessageButtom => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.SimpleFormDemo>().ShowMessageButtom));
        private IWebElement YourMessage => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.SimpleFormDemo>().ShowMessageButtom));
        private IWebElement EnterAInputField => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.SimpleFormDemo>().ShowMessageButtom));
        private IWebElement EnterBInputField => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.SimpleFormDemo>().ShowMessageButtom));
        private IWebElement GetTotalButtom => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.SimpleFormDemo>().ShowMessageButtom));
        private IWebElement Total => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.SimpleFormDemo>().ShowMessageButtom));

        public SimpleFormDemo(
            IWebDriver driver,
            IXpathReader xpathReader)
        {
            Driver = driver;
            XpathReader = xpathReader;
        }

        public void EnterMessage(string text) => EnterMessageInputField.SendKeys(text);
        public void SubmitMessage() => ShowMessageButtom.Click();
        public string GetMessage() => YourMessage.Text;
        public void EnterValueA(string a) => EnterAInputField.SendKeys(a);
        public void EnterValueB(string b) => EnterBInputField.SendKeys(b);
        public void SubmitGetTotalButton() => GetTotalButtom.Click();
        public string GetTotal() => Total.Text;
    }
}