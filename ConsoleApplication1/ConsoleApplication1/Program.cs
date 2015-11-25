using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;


namespace ConsoleApplication1
{
    class ChromeLaunch
    {
        IWebDriver driver = new ChromeDriver(@"E:\Projects\chromedriver_win32");
        static void Main(string[] args)
        {
        }
        [SetUp]
        public void Initialize()
        { 
            driver.Navigate().GoToUrl("https://support.software.dell.com/appassure/kb");
            Console.WriteLine("first output"); 
        }
        [Test]
        public void ExecuteText()
        {

            //EnterText(element, value, type)
            SeleniumSetMethods.EnterText(driver, "txtKbAutoCompleteKeyword", "test", By.Id);
            //click
            
            

        }
        [TearDown]
        public void CleanUp()
        {
            //driver.Close();
            Console.WriteLine("third output");
        }
    }
}
