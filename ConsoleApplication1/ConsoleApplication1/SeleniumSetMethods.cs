using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ConsoleApplication1
{
    class SeleniumSetMethods
    {
        //Enter Text
        public static void EnterText(IWebDriver driver, string element , string value, string elementtype)
        {
            if (elementtype == "Id") 
                driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementtype == "Name")
                driver.FindElement(By.Name(element)).SendKeys(value);
        }
        // Click into checkbox
        public static void Click(IWebDriver driver, string element, string value, string elementtype)
        {
            if (elementtype == "Id")
                driver.FindElement(By.Id(element)).Click();
            if (elementtype == "Name")
                driver.FindElement(By.Name(element)).Click();
        }
    }
}
