using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BDDTestProject.PageObjects
{
    class QuestionPage : HomePage
    {
        //private IWebDriver driver;
        public QuestionPage(IWebDriver driver) : base(driver)
        {
        }
        [FindsBy(How = How.XPath, Using = "//textarea[@placeholder='Do you have any questions relating to the election that you'd like us to answer?']")]
        private IWebElement TextArea;
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Name']")]
        private IWebElement NameForm;
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Email address']")]
        private IWebElement EmailForm;
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Age']")]
        private IWebElement AgeForm;
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Postcode']")]
        private IWebElement PostcodeForm;
        [FindsBy(How = How.XPath, Using = "//*[@class='button']")]
        private IWebElement SubmitBtn;
        [FindsBy(How = How.XPath, Using = "//div[@class='input-error-message']")]
        private IWebElement ErrorMessage;
        public void enterQuestion(string text)
        {
            TextArea.SendKeys(text);
        }
        public void enterValidData()
        {
            NameForm.SendKeys("Name");
            EmailForm.SendKeys("email@adress.com");
            AgeForm.SendKeys("24");
            PostcodeForm.SendKeys("0123");
        }
        public void enterWithoutName()
        {
            EmailForm.SendKeys("email@adress.com");
            AgeForm.SendKeys("24");
            PostcodeForm.SendKeys("0123");
        }
        public void enterWithoutEmail()
        {
            NameForm.SendKeys("Name");
            AgeForm.SendKeys("24");
            PostcodeForm.SendKeys("0123");
        }
        public void submit()
        {
            SubmitBtn.Click();
        }
    }
}
