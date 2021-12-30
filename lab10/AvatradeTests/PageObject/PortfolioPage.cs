using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvatradeTests.PageObject
{
    public class PortfolioPage : BasePage
    {
        public PortfolioPage(IWebDriver driver) : base(driver) { }
        public string SearchEur()
        {
            System.Threading.Thread.Sleep(1000);
            return driver.FindElement(By.XPath("//div[text()=' EUR/USD ']")).Text;
        }
    }
}
