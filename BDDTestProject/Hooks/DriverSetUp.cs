using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BDDTestProject
{
    [Binding]
    public class DriverSetUp
    {
        private IObjectContainer objectContainer;
        public IWebDriver driver;

        public DriverSetUp(IObjectContainer objectContainer)
        {
            this.objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver(Environment.CurrentDirectory);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            objectContainer.RegisterInstanceAs(driver);
        }
    }
}
