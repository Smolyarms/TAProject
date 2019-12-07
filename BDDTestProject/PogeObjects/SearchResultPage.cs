using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BDDTestProject.PogeObjects
{
    class SearchResultPage
    {
        private IWebDriver driver;
        public SearchResultPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//ol[@class='search-results results']//li[@data-result-number='1']")]
        internal IWebElement FirstResult;

        public IWebElement GetResultTitle(IWebElement resultTitle)
        {
            return resultTitle.FindElement(By.XPath(".//h1[@itemprop='headline']/a"));
        }
    }
}
