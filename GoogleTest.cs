using NUnit.Framework;
using OpenQA.Selenium;
using firstautomationproject.Drivers;
using OpenQA.Selenium.Chrome;
using System.Runtime.ExceptionServices;
using OpenQA.Selenium.DevTools.V135.DOM;
using OpenQA.Selenium.DevTools.V135.Runtime;

namespace firstautomationproject.Tests
{
    public class GoogleTest
    {
        IWebDriver? driver;

        [SetUp]
        public void StartBrowser()
        {
            driver = DriverSetup.GetChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            
        }

        [Test]
        public void GoogleSearchTest()
        {
            driver.Navigate().GoToUrl("https://www.bing.com/"); // Go to Bing

            Thread.Sleep(6000);
            Assert.That(driver.Url, Is.EqualTo("https://www.bing.com/"));
            Assert.That(driver.Title, Is.EqualTo("Search - Microsoft Bing"));


        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Quit();
        }
    }
}