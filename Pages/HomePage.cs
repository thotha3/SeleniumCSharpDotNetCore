using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.Pages
{
    class HomePage : DriverHelper
    {
        private IWebDriver Driver;
        IWebElement lnkLogin => Driver.FindElement(By.LinkText("Login"));
        IWebElement lnkLogout => Driver.FindElement(By.LinkText("Log off"));

        public HomePage(IWebDriver Driver)
        {
            this.Driver = Driver;
        }
        
        public void ClickLogin() => lnkLogin.Click();

        public bool IsLogOffExist() => lnkLogout.Displayed;

        public void ClickLogoff() => lnkLogout.Click();
    }
}
