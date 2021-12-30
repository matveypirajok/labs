using System;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using AvatradeTests.PageObject;
using AvatradeTests.Tests;

namespace AvatradeTests.Tests
{
    public class Tests : CommonConditions
    {
        [Test]
        public void AddProm()
        {
            var trade = new TradingPageObject(driver).
                TradeTest();

            string EUR = new PortfolioPage(driver)
                .SearchEur();
            Assert.AreEqual(Element, EUR);

        }
    }
}