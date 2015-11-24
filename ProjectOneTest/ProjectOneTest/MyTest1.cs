using System;
using ProjectOneTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support;
 
namespace ProjectOneTest
{
    [TestClass]
    public class MyTest1
    {
        IWebDriver driver;

        [TestMethod]
        public void VerifyTitle()
        {
            //write test
            var title = driver.Title;
            Assert.AreEqual("Products | Done The Deal", title);
        }
        [TestInitialize]
        public void Setup()
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://donethedeal.com");
            //start browser and open URL
        }
        [TestCleanup]
        public void CleanupTest()
        {
            //Close Browser
            driver.Quit();
        }
    }

}
