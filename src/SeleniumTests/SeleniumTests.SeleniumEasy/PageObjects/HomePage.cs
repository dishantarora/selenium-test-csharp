using OpenQA.Selenium;

namespace SeleniumTests.SeleniumEasy.PageObjects
{
    sealed class HomePage
    {
        #region Web Driver
        private IWebDriver Driver { get; set; }
        #endregion

        #region Lightbox
        private IWebElement Lightbox => Driver.FindElement(By.XPath(@"//div[@id='at-cv-lightbox']"));
        private IWebElement LightBoxCloseIcon => Driver.FindElement(By.XPath(@"//a[@id='at-cv-lightbox-close']"));
        #endregion

        #region Input Forms
        private IWebElement InputFormsTab => Driver.FindElement(
            By.XPath(@"//div[@id='navbar-brand-centered']//ul//li//a[contains(text(),'Input Forms')]"));
        private IWebElement SimpleFormDemo => Driver.FindElement(
            By.XPath(@"//div[@id='navbar-brand-centered']//ul//li//a[contains(text(),'Input Forms')]//following-sibling::ul//li//a[contains(text(),'Simple Form Demo')]"));
        private IWebElement CheckboxDemo => Driver.FindElement(
            By.XPath(@"//div[@id='navbar-brand-centered']//ul//li//a[contains(text(),'Input Forms')]//following-sibling::ul//li//a[contains(text(),'Checkbox Demo')]"));
        private IWebElement RadioButtonsDemo => Driver.FindElement(
            By.XPath(@"//div[@id='navbar-brand-centered']//ul//li//a[contains(text(),'Input Forms')]//following-sibling::ul//li//a[contains(text(),'Radio Buttons Demo')]"));
        private IWebElement DropdownList => Driver.FindElement(
            By.XPath(@"//div[@id='navbar-brand-centered']//ul//li//a[contains(text(),'Input Forms')]//following-sibling::ul//li//a[contains(text(),'Select Dropdown List')]"));
        private IWebElement InputFormSubmit => Driver.FindElement(
            By.XPath(@"//div[@id='navbar-brand-centered']//ul//li//a[contains(text(),'Input Forms')]//following-sibling::ul//li//a[contains(text(),'Input Form Submit')]"));
        private IWebElement AjaxFormSubmit => Driver.FindElement(
            By.XPath(@"//div[@id='navbar-brand-centered']//ul//li//a[contains(text(),'Input Forms')]//following-sibling::ul//li//a[contains(text(),'Ajax Form Submit')]"));
        private IWebElement JQuerySelectDropdown => Driver.FindElement(
            By.XPath(@"//div[@id='navbar-brand-centered']//ul//li//a[contains(text(),'Input Forms')]//following-sibling::ul//li//a[contains(text(),'JQuery Select Dropdown')]"));

        #endregion

        public HomePage(IWebDriver driver)
        {
            Driver = driver;
            if (Lightbox.Displayed)
            {
                LightBoxCloseIcon.Click();
            }
        }
        public void GoToInputFormsTabOnNavigationBar()
        {
            InputFormsTab.Click();
        }
        public void SelectSimpleFormDemoItemFromDropDownList()
        {
            SimpleFormDemo.Click();
        }
        public void SelectCheckboxDemoItemFromDropDownList()
        {
            CheckboxDemo.Click();
        }
        public void SelectRadioButtonsDemoItemFromDropDownList()
        {
            RadioButtonsDemo.Click();
        }
        public void SelectDropdownListItemFromDropDownList()
        {
            DropdownList.Click();
        }
        public void SelectInputFormSubmitItemFromDropDownList()
        {
            InputFormSubmit.Click();
        }
        public void SelectAjaxFormSubmitItemFromDropDownList()
        {
            AjaxFormSubmit.Click();
        }
        public void SelectJQuerySelectDropdownItemFromDropDownList()
        {
            JQuerySelectDropdown.Click();
        }
    }
}