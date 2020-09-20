using OpenQA.Selenium;

namespace SeleniumTests.SeleniumEasy.PageObjects
{
    sealed class SimpleFormDemo
    {
        private IWebDriver Driver { get; set; }

        private IWebElement EnterMessageInputField => Driver.FindElement(
            By.XPath(@"//form[@id='get-input']//label[contains(text(),'Enter message')]//following-sibling::input"));
        private IWebElement ShowMessageButtom => Driver.FindElement(
            By.XPath(@"//form[@id='get-input']//button"));
        private IWebElement YourMessage => Driver.FindElement(
            By.XPath(@"//div[@id='user-message']//span[@id='display']"));
        private IWebElement EnterAInputField => Driver.FindElement(
            By.XPath(@"//form[@id='gettotal']//input[@id='sum1']"));
        private IWebElement EnterBInputField => Driver.FindElement(
            By.XPath(@"//form[@id='gettotal']//input[@id='sum2']"));
        private IWebElement GetTotalButtom => Driver.FindElement(
            By.XPath(@"//form[@id='gettotal']//button[contains(text(),'Get Total')]"));
        private IWebElement Total => Driver.FindElement(
            By.XPath(@"//form[@id='gettotal']//following-sibling::div//span[@id='displayvalue']"));
        public SimpleFormDemo(IWebDriver driver)
        {
            Driver = driver;
        }
        public void EnterMessage(string text)
        {
            EnterMessageInputField.SendKeys(text);
        }
        public void SubmitMessage()
        {
            ShowMessageButtom.Click();
        }
        public string GetMessage()
        {
            return YourMessage.Text;
        }
        public void EnterValueA(string a)
        {
            EnterAInputField.SendKeys(a);
        }
        public void EnterValueB(string b)
        {
            EnterBInputField.SendKeys(b);
        }
        public void SubmitGetTotalButton()
        {
            GetTotalButtom.Click();
        }
        public string GetTotal()
        {
            return Total.Text;
        }
    }
}