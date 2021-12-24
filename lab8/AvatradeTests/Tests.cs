using System;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Threading;

namespace AvatradeTests
{
    public class Tests
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        private const string TestEmail = "testikiepamuch@gmail.com";
        private const string TestPassword = "12@3123123Gg";

        [SetUp]
        public void StartPageSetup()
        {
            _driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            _driver.Navigate().GoToUrl("https://capital.com/");
            _driver.Manage().Window.Maximize();

            var logInBtn = _driver.FindElement(By.XPath("//a[@class = 'button-main ln-auto stroke-white']"));
            logInBtn.Click();

            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            var inputEmail = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@name = 'email']")));
            inputEmail.SendKeys(TestEmail);

            var inputPassword = _driver.FindElement(By.XPath("//input[@name = 'password']"));
            inputPassword.SendKeys(TestPassword);

            var submitBtn = _driver.FindElement(By.XPath("//button[@class = 'button-main l_btn']"));
            submitBtn.Click();
        }

        
        [Test]
        public void CreateDealToBuyEURTest()
        {
            string Element = "EUR/USD";

            Thread.Sleep(10000);

            var AccountClick = _driver.FindElement(By.XPath("/html/body/app-root/div/topbar/div/account-info"));
            AccountClick.Click();

            var DemoClick = _driver.FindElement(By.XPath("/html/body/app-root/div/topbar/div/account-info/div/div[3]/div[4]"));
            DemoClick.Click();

            Thread.Sleep(3000);

            var selectCurrency = _driver.FindElement(By.XPath("//div[text()='EUR/USD']"));
            selectCurrency.Click();

            var buyEUR = _driver.FindElement(By.XPath("//button[@class='button-outlined button-outlined--small']"));
            buyEUR.Click();
            
            Thread.Sleep(1000);

            var ImputCount = _driver.FindElement(By.XPath("/html/body/app-root/div/left-side-panel/div[1]/div/div[2]/trade-view/trade-side-panel/div/div/div[3]/trade-deal-ticket/place-order/div/scroll-pane/div[1]/div[1]/input-number2/div/input"));
            ImputCount.Click();

            Thread.Sleep(1000);

            var inputCountEUR = _driver.FindElement(By.XPath("/html/body/app-root/div/left-side-panel/div[1]/div/div[2]/trade-view/trade-side-panel/div/div/div[3]/trade-deal-ticket/place-order/div/scroll-pane/div[1]/div[1]/input-number2/div/input"));
            inputCountEUR.Clear();

            Thread.Sleep(3000);

            var selectCurrencyy = _driver.FindElement(By.XPath("/html/body/app-root/div/left-side-panel/div[1]/div/div[2]/trade-view/trade-side-panel/div/div/div[3]/trade-deal-ticket/place-order/div/div/button"));
            selectCurrencyy.Click();

            Thread.Sleep(3000);

            var buttonPortf = _driver.FindElement(By.XPath("/html/body/app-root/div/left-side-panel/div[2]/floating-left-panel/div[1]/div[4]"));
            buttonPortf.Click();

            Thread.Sleep(3000);

            var searchEUR = _driver.FindElement(By.XPath("//div[text()=' EUR/USD ']")).Text;
            Assert.AreEqual(Element, searchEUR);



        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}