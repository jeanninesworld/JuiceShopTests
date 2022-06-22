﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Framework
{
    public class WebDriverFactory
    {
        private IWebDriver _driver;

        public WebDriverFactory() { }
        public IWebDriver OpenBrowser()
        {
            _driver = new ChromeDriver();
            return _driver;
        }



    }
}