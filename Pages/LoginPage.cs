using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.Pages
{
    class LoginPage : DriverHelper
    {
        private IWebDriver Driver;
        IWebElement txtUserName => Driver.FindElement(By.Name("UserName"));
        IWebElement txtPassword => Driver.FindElement(By.Name("Password"));
        IWebElement btnLogin => Driver.FindElement(By.CssSelector("#loginForm > form > div:nth-child(5) > div > input"));

        public LoginPage(IWebDriver Driver)
        {
            this.Driver = Driver;
        }

        public void EnterUserNameAndPassword(String userName, String password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
        }

        public void ClickLogin()
        {
            btnLogin.Click();
        }
    }
}
