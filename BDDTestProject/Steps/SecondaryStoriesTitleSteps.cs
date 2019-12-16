using BDDTestProject.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BDDTestProject.Steps
{
    [Binding]
    public class SecondaryStoriesTitleSteps
    {
        private HomePage home => new HomePage(driver);
        private NewsPage news;
        private IWebDriver driver;
        private PageContext scenarioContext;

        public SecondaryStoriesTitleSteps(IWebDriver driver, PageContext scenarioContext)
        {
            this.driver = driver;
            this.scenarioContext = scenarioContext;
        }
       

        [When(@"I get secondary titles text")]
        public void WhenIGetSecondaryTitlesText()
        {
            List<string> actual = new List<string>();
            IList<IWebElement> secondaryStories = news.GetSecondaryStories();
            foreach (var i in secondaryStories)
            {
                var title = news.GetItemTitle(i);
                actual.Add(title.Text);
            }
            scenarioContext.secondaryTitles.AddRange(actual);
        }
        
        [Then(@"titles should be SecondaryTitles")]
        public void ThenTitlesShouldBeSecondaryTitles(Table table)
        {
            var actual = scenarioContext.secondaryTitles;
            var expected = table.Rows.Select(r => r[0]).ToList();
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
