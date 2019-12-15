using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDDTestProject.PageObjects
{
    class NewsPage : HomePage
    {
        public NewsPage(IWebDriver driver) : base(driver)
        {
        }
        [FindsBy(How = How.XPath, Using = "//div[contains(@data-entityid,'container-top-stories#')]")]
        private IList<IWebElement> TopStories;

        [FindsBy(How = How.ClassName, Using = "nw-c-nav__wide-morebutton nw-c-nav__wide-morebutton__closed")]
        private IWebElement BtnMore;

        [FindsBy(How = How.XPath, Using = "//a[@href = '/news/have_your_say']")]
        private IWebElement HaveYourSay;

        [FindsBy(How = How.XPath, Using = "//a[@href = '/news/uk-politics-49577632']")]
        private IWebElement SendUsYourQ;
        public IWebElement GetFirstStory()
        {
            IWebElement firstStory = TopStories.First();
            return firstStory;
        }
        public IList<IWebElement> GetSecondaryStories()
        {
            IList<IWebElement> secondaryStories = TopStories.Skip(1).Take(5).ToList();
            return secondaryStories;
        }
        public IWebElement GetItemTitle(IWebElement ItemTitle)
        {
            return ItemTitle.FindElement(By.XPath(".//h3"));
        }
        public IWebElement GetItemCategory(IWebElement ItemCategory)
        {
            return ItemCategory.FindElement(By.XPath(".//a[@class = 'gs-c-section-link gs-c-section-link--truncate nw-c-section-link nw-o-link nw-o-link--no-visited-state']/span"));
        }
        public QuestionPage GoToQuestionPage()
        {
            BtnMore.Click();
            HaveYourSay.Click();
            SendUsYourQ.Click();
            return new QuestionPage(driver);
        }
    }
}
