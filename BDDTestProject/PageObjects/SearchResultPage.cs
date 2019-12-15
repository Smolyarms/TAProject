using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BDDTestProject.PageObjects
{
    class SearchResultPage : HomePage
    {
        public SearchResultPage(IWebDriver driver) : base(driver)
        {
        }

        [FindsBy(How = How.XPath, Using = "//ol[@class='search-results results']//li[@data-result-number='1']")]
        internal IWebElement FirstResult;

        public IWebElement GetResultTitle(IWebElement resultTitle)
        {
            return resultTitle.FindElement(By.XPath(".//h1[@itemprop='headline']/a"));
        }
    }
}
