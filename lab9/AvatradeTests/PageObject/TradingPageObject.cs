using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvatradeTests.PageObject
{
    public class TradingPageObject
    {
        private IWebDriver _webDriver;
        private By SearchItem = By.XPath("//div[text()='EUR/JPY']");
        private By AddItem = By.XPath("//button[@class='button-outlined button-outlined--small']");
        private By Confirm = By.XPath("/html/body/app-root/div/left-side-panel/div[1]/div/div[2]/trade-view/trade-side-panel/div/div/div[3]/trade-deal-ticket/place-order/div/div/button");
        public TradingPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        public TradingPageObject TradeTest()
        {
            System.Threading.Thread.Sleep(4000);
            _webDriver.FindElement(SearchItem).Click();
            System.Threading.Thread.Sleep(1000);
            _webDriver.FindElement(AddItem).Click();
            System.Threading.Thread.Sleep(3000);
            _webDriver.FindElement(Confirm).Click();
            return new TradingPageObject(_webDriver);
        }
    }
}
