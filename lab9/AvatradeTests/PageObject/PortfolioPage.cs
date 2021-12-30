using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvatradeTests.PageObject
{
    public class PortfolioPage
    {
        public IWebDriver webdriver;
        public PortfolioPage(IWebDriver driver)
        {
            webdriver = driver;
        }
        public string SearchEur()
        {
            System.Threading.Thread.Sleep(1000);
            return webdriver.FindElement(By.XPath("//div[text()=' EUR/USD ']")).Text;
        }
    }
}
