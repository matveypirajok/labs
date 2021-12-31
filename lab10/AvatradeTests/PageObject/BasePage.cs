﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvatradeTests.PageObject
{
    public abstract class BasePage
    {
        public IWebDriver driver;
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}