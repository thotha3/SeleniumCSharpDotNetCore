using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestProject.Pages;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProject
{
    public class Tests : DriverHelper
    {
        public static IWebDriver Driver;

        [SetUp]
        public void Setup()
        {
           
        }

        [Test]
        public void LoginTest()
        {
            Driver = getChromeDriver();
            Driver.Navigate().GoToUrl("http://eaapp.somee.com/");

            HomePage homePage = new HomePage(Driver);
            LoginPage loginPage = new LoginPage(Driver);

            homePage.ClickLogin();
            loginPage.EnterUserNameAndPassword("admin", "password");
            loginPage.ClickLogin();
            Assert.That(homePage.IsLogOffExist(), Is.True, "Log off button is NOT displayed");
            homePage.ClickLogoff();
            
        }

        [TearDown]
        public void cleanUp()
        {
            Driver.Close();
        }
    }
}