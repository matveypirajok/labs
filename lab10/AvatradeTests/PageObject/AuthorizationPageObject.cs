using AvatradeTests.Model;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvatradeTests.PageObject
{
    public class AuthorizationPageObject : BasePage
    {
        private By LoginInput = By.XPath("//input[@name = 'email']");
        private By PasswordInput = By.XPath("//input[@name = 'password']");
        private By LoginBtn = By.XPath("//button[@class = 'button-main l_btn']");
        public AuthorizationPageObject(IWebDriver webDriver) : base(webDriver) { }
        public TradingPageObject Login(User user)
        {
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(LoginInput).SendKeys(user.Username);
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(PasswordInput).SendKeys(user.Password);
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(LoginBtn).Click();
            return new TradingPageObject(driver);
        }
    }
}
