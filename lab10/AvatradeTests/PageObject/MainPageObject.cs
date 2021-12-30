using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvatradeTests.PageObject
{
    public class MainPageObject : BasePage
    {
        private By EntranceBtn = By.XPath("//a[@class = 'button-main ln-auto stroke-white']");
       

        public MainPageObject(IWebDriver webDriver) : base(webDriver) { }
        public AuthorizationPageObject Entrance()
        {
            driver.FindElement(EntranceBtn).Click();
            return new AuthorizationPageObject(driver);
        }
    }
}
