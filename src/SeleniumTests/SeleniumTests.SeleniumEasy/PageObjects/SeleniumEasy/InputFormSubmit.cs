using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using WebAutomationSeleniumTests.SeleniumEasy.Common;

namespace WebAutomationSeleniumTests.SeleniumEasy.PageObjects
{
    sealed class InputFormSubmit
    {
        private IWebDriver Driver { get; set; }
        private IXpathReader XpathReader { get; set; }
        private IWebElement FirstName => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.InputFormSubmit>().FirstName));
        private IWebElement LastName => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.InputFormSubmit>().LastName));
        private IWebElement Email => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.InputFormSubmit>().Email));
        private IWebElement PhoneNumber => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.InputFormSubmit>().PhoneNuber));
        private IWebElement Address => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.InputFormSubmit>().Address));
        private IWebElement City => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.InputFormSubmit>().City));
        private IWebElement State => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.InputFormSubmit>().State));
        private IWebElement ZipCode => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.InputFormSubmit>().ZipCode));
        private IWebElement WebsiteOrDomainName => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.InputFormSubmit>().WebsiteOrDomainName));
        private IWebElement YesOptionForHosting => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.InputFormSubmit>().YesOptionForHosting));
        private IWebElement NoOptionForHosting => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.InputFormSubmit>().NoOptionForHosting));
        private IWebElement ProjectDescription => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.InputFormSubmit>().ProjectDescription));
        private IWebElement SendButton => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.InputFormSubmit>().SendButton));
        public InputFormSubmit(IWebDriver driver, IXpathReader xpathReader)
        {
            Driver = driver;
            XpathReader = xpathReader;
        }
        public void FillFirstName(string value) => FirstName.SendKeys(value);
        public void FillLastName(string value) => LastName.SendKeys(value);
        public void FillEmail(string value) => Email.SendKeys(value);
        public void FillPhoneNumber(string value) => PhoneNumber.SendKeys(value);
        public void FillAddress(string value) => Address.SendKeys(value);
        public void FillCity(string value) => City.SendKeys(value);
        public void SelectState(string value)
        {
            var stateDropdown = new SelectElement(State);
            stateDropdown.SelectByText(value);
        }
        public void FillZipCode(string value) => ZipCode.SendKeys(value);
        public void FillWebsiteOrDomainName(string value) => WebsiteOrDomainName.SendKeys(value);
        public void SelectYesOptionForHosting() => YesOptionForHosting.Click();
        public void SelectNoOptionForHosting() => NoOptionForHosting.Click();
        public void FillProjectDescription(string value) => ProjectDescription.SendKeys(value);
        public void ClickSendButton() => SendButton.Click();
    }
}