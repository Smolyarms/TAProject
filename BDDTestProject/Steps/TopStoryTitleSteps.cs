using BDDTestProject.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace BDDTestProject
{
    [Binding]
    public class TopStoryTitleSteps
    {
        private HomePage home => new HomePage(driver);
        private NewsPage news;
        private IWebDriver driver;
        private PageContext scenarioContext;

        public TopStoryTitleSteps (IWebDriver driver, PageContext scenarioContext)
        {
            this.driver = driver;
            this.scenarioContext = scenarioContext;
        }

        [Given(@"I open BBC news page")]
        public void GivenIOpenBBCNewsPage()
        {
            home.GoToBBC();
        }
        
        [Given(@"open news page")]
        public void GivenOpenNewsPage()
        {
            news = home.GoToNewsPage();
        }
        
        [When(@"I get top title text")]
        public void WhenIGetTopTitleText()
        {
            var firstTitle = news.GetFirstStory();
            scenarioContext.title = news.GetItemTitle(firstTitle).Text;
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(string p0)
        {
            string expected = p0;
            string actual = scenarioContext.title;
            Assert.AreEqual(expected, actual);
        }
    }
}
