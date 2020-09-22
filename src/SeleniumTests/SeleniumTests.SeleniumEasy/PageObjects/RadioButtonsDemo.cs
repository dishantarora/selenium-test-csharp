using OpenQA.Selenium;
using SeleniumTests.SeleniumEasy.Common;

namespace SeleniumTests.SeleniumEasy.PageObjects
{
    sealed class RadioButtonsDemo
    {
        private IWebDriver Driver { get; set; }
        private IXpathReader XpathReader { get; set; }

        private IWebElement SingleMaleRadioButton => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.RadioButtonsDemo>().SingleMaleRadioButton));
        private IWebElement SingleFemaleRadioButton => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.RadioButtonsDemo>().SingleFemaleRadioButton));
        private IWebElement GetCheckedValueButton => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.RadioButtonsDemo>().GetCheckedValueButton));
        private IWebElement ResultOfSingleRadioButtonDemo => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.RadioButtonsDemo>().ResultOfSingleRadioButtonDemo));
        private IWebElement GroupMaleRadioButton => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.RadioButtonsDemo>().GroupMaleRadioButton));
        private IWebElement GroupFemaleRadioButton => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.RadioButtonsDemo>().GroupFemaleRadioButton));
        private IWebElement ZeroTo5AgeButton => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.RadioButtonsDemo>().ZeroTo5AgeButton));
        private IWebElement FiveTo15Button => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.RadioButtonsDemo>().FiveTo15Button));
        private IWebElement FifteenTo50Button => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.RadioButtonsDemo>().FifteenTo50Button));
        private IWebElement GetValuesButton => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.RadioButtonsDemo>().GetValuesButton));
        private IWebElement ResultOfGroupRadioButtonDemo => Driver.FindElement(
            By.XPath(XpathReader.GetValue<Models.RadioButtonsDemo>().ResultOfGroupRadioButtonDemo));

        public RadioButtonsDemo(IWebDriver driver) => Driver = driver;

        public void SelectSingleMaleOption() => SingleMaleRadioButton.Click();
        public void SelectSingleFemalOption() => SingleFemaleRadioButton.Click();
        public void ClickGetCheckedValuesButton() => GetCheckedValueButton.Click();
        public string GetResultOfSingleRadioButtonDemo() => ResultOfSingleRadioButtonDemo.Text;
        public void SelectGroupMaleOption() => GroupMaleRadioButton.Click();
        public void SelectGroupFemaleOption() => GroupFemaleRadioButton.Click();
        public void SelectZeroTo5AgeGroupOption() => ZeroTo5AgeButton.Click();
        public void SelectFiveTo15AgeGroupOption() => FiveTo15Button.Click();
        public void SelectFifteenTo50AgeGroupOption() => FifteenTo50Button.Click();
        public void ClickGetValuesButton() => GetValuesButton.Click();
        public string GetResultsOfGroupRadioButtonDemo() => ResultOfGroupRadioButtonDemo.Text;
    }
}