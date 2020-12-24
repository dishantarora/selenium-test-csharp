using OpenQA.Selenium;
using WebAutomationSeleniumTests.SeleniumEasy.Common;

namespace WebAutomationSeleniumTests.SeleniumEasy.PageObjects
{
    sealed class AjaxFormSubmit
    {
        private IWebDriver Driver { get; set; }
        private IXpathReader XpathReader { get; set; }
        private IWebElement Name => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.AjaxFormSubmit>().Name));
        private IWebElement Comment => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.AjaxFormSubmit>().Comment));
        private IWebElement SubmitButton => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.AjaxFormSubmit>().SubmitButton));
        private IWebElement FormStatus => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.AjaxFormSubmit>().FormStatus));
        public AjaxFormSubmit(IWebDriver driver,IXpathReader xpathReader)
        {
            Driver = driver;
            XpathReader = xpathReader;
        }
        public void FillName(string value) => Name.SendKeys(value);
        public void FillComment(string value) => Comment.SendKeys(value);
        public void ClickSubmitButton() => SubmitButton.Click();
        public string GetFormStatus() => FormStatus.Text;
    }
}