using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BDDTestProject.PogeObjects
{
    class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            //driver.Navigate().GoToUrl("https://www.bbc.com");
            PageFactory.InitElements(driver, this);
        }
        public HomePage GoToBBC()
        {
            driver.Navigate().GoToUrl("https://www.bbc.com");
            return new HomePage(driver);
        }

        [FindsBy(How = How.XPath, Using = "//a[@href = 'https://www.bbc.com/news']")]
        private IWebElement newsButton;
        public NewsPage GoToNewsPage()
        {
            newsButton.Click();
            return new NewsPage(driver);
        }

        [FindsBy(How = How.Id, Using = "orb-search-q")]
        private IWebElement searchForm;
        public SearchResultPage search(string text)
        {
            searchForm.SendKeys(text + Keys.Enter);
            return new SearchResultPage(driver);
        }
    }
}
