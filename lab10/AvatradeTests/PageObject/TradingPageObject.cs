using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvatradeTests.PageObject
{
    public class TradingPageObject : BasePage
    {
        private By SearchItem = By.XPath("//div[text()='EUR/USD']");
        private By AddItem = By.XPath("//button[@class='button-outlined button-outlined--small']");
        private By Confirm = By.XPath("/html/body/app-root/div/left-side-panel/div[1]/div/div[2]/trade-view/trade-side-panel/div/div/div[3]/trade-deal-ticket/place-order/div/div/button");
        private By AccountClick = By.XPath("/html/body/app-root/div/topbar/div/account-info");
        private By DemoClick = By.XPath("/html/body/app-root/div/topbar/div/account-info/div/div[3]/div[4]");
        private By ImputCount = By.XPath("/html/body/app-root/div/left-side-panel/div[1]/div/div[2]/trade-view/trade-side-panel/div/div/div[3]/trade-deal-ticket/place-order/div/scroll-pane/div[1]/div[1]/input-number2/div/input");
        private By inputCountEUR = By.XPath("/html/body/app-root/div/left-side-panel/div[1]/div/div[2]/trade-view/trade-side-panel/div/div/div[3]/trade-deal-ticket/place-order/div/scroll-pane/div[1]/div[1]/input-number2/div/input");//очитска поля с количеством clear
        private By buttonPortf = By.XPath("/html/body/app-root/div/left-side-panel/div[2]/floating-left-panel/div[1]/div[4]"); //переход в портфолио
        private By searchEUR = By.XPath("//div[text()=' EUR/USD ']"); // поиск для ассерта

        public TradingPageObject(IWebDriver webDriver) : base(webDriver) { }
        public PortfolioPage TradeTest()
        {
            System.Threading.Thread.Sleep(10000);
            driver.FindElement(AccountClick).Click();

            driver.FindElement(DemoClick).Click();

            System.Threading.Thread.Sleep(7000);
            driver.FindElement(SearchItem).Click();

            System.Threading.Thread.Sleep(1000);

            driver.FindElement(AddItem).Click();
            System.Threading.Thread.Sleep(1000);

            driver.FindElement(inputCountEUR).Clear();


            System.Threading.Thread.Sleep(3000);
            driver.FindElement(Confirm).Click();

            System.Threading.Thread.Sleep(1000);
            driver.FindElement(buttonPortf).Click();

            return new PortfolioPage(driver);
        }
    }
}
