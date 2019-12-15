using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BDDTestProject.PageObjects
{
    class HomePage
    {
        protected IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//a[@href = 'https://www.bbc.com/news']")]
        private IWebElement newsButton;

        [FindsBy(How = How.Id, Using = "orb-search-q")]
        private IWebElement searchForm;

        public HomePage GoToBBC()
        {
            driver.Navigate().GoToUrl("https://www.bbc.com");
            return new HomePage(driver);
        }
        public NewsPage GoToNewsPage()
        {
            newsButton.Click();
            return new NewsPage(driver);
        }
        public SearchResultPage Search(string text)
        {
            searchForm.SendKeys(text + Keys.Enter);
            return new SearchResultPage(driver);
        }
    }
}
