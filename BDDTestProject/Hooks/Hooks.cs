using BDDTestProject.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BDDTestProject
{
    [Binding]
    public sealed class Hooks
    {
        public IWebDriver driver;

        public Hooks (IWebDriver driver)
        {
            this.driver = driver;
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
    }
}
