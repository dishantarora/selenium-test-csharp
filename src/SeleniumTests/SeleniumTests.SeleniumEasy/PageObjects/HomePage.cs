using OpenQA.Selenium;
using SeleniumTests.SeleniumEasy.Common;

namespace SeleniumTests.SeleniumEasy.PageObjects
{
    sealed class HomePage
    {
        private IWebDriver Driver { get; set; }
        private IXpathReader XpathReader { get; set; }

        #region Lightbox
        private IWebElement Lightbox => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.HomePage>().LightBox));
        private IWebElement LightBoxCloseIcon => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.HomePage>().LightBoxCloseIcon));
        #endregion

        #region Input Forms
        private IWebElement InputFormsTab => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.HomePage>().InputFormsTab));
        private IWebElement SimpleFormDemo => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.HomePage>().SimpleFormDemo));
        private IWebElement CheckboxDemo => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.HomePage>().CheckboxDemo));
        private IWebElement RadioButtonsDemo => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.HomePage>().RadioButtonsDemo));
        private IWebElement DropdownList => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.HomePage>().DropdownList));
        private IWebElement InputFormSubmit => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.HomePage>().InputFormSubmit));
        private IWebElement AjaxFormSubmit => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.HomePage>().AjaxFormSubmit));
        private IWebElement JQuerySelectDropdown => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.HomePage>().JQuerySelectDropdown));

        #endregion

        public HomePage(IWebDriver driver)
        {
            Driver = driver;
            if (Lightbox.Displayed)
            {
                LightBoxCloseIcon.Click();
            }
        }
        public void GoToInputFormsTabOnNavigationBar() => InputFormsTab.Click();
        public void SelectSimpleFormDemoItemFromDropDownList() => SimpleFormDemo.Click();
        public void SelectCheckboxDemoItemFromDropDownList() => CheckboxDemo.Click();
        public void SelectRadioButtonsDemoItemFromDropDownList() => RadioButtonsDemo.Click();
        public void SelectDropdownListItemFromDropDownList() => DropdownList.Click();
        public void SelectInputFormSubmitItemFromDropDownList() => InputFormSubmit.Click();
        public void SelectAjaxFormSubmitItemFromDropDownList() => AjaxFormSubmit.Click();
        public void SelectJQuerySelectDropdownItemFromDropDownList() => JQuerySelectDropdown.Click();
    }
}