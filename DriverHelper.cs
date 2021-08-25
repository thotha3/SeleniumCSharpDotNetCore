using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProject
{
    public class DriverHelper
    {
        private static IWebDriver Driver;
        
        protected static IWebDriver getChromeDriver() 
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig(), "91.0.4472.101");
            Driver = new ChromeDriver();

            return Driver;
        }
    }
}
