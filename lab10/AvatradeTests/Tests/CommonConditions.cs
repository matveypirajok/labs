using AvatradeTests.Driver;
using AvatradeTests.Model;
using AvatradeTests.PageObject;
using AvatradeTests.Service;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvatradeTests.Tests
{
    public abstract class CommonConditions
    {
        public IWebDriver driver;
        public const string Element = "EUR/USD";
        [SetUp]
        public void StartPageSetup()
        {
            User user = CreatorUser.JoiningMyAccountFromProperty();
            driver = DriverInstance.GetInstance();
            driver.Navigate().GoToUrl("https://capital.com/");
            var main = new MainPageObject(driver).
                Entrance().
                Login(user);
        }

        [TearDown]
        public void TearDown()
        {
            DriverInstance.CloseBrowser();
        }
    }
}
