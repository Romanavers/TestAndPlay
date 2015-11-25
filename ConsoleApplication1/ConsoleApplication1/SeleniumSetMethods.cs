using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Constraints;
using OpenQA.Selenium;

namespace ConsoleApplication1
{
    class SeleniumSetMethods
    {
        //Enter Text
        public static void EnterText(IWebDriver driver, string element , string value, Func<string, By> F)
        {
            var by = F.Invoke(element);
            var pageelement = driver.FindElement(by);
            pageelement.SendKeys(value);
        }
        // Click into checkbox
        public static void Click(IWebDriver  driver, string element, string value, string elementtype)
        {
            if (elementtype == "Id")
                driver.FindElement(By.Id(element)).Click();
            if (elementtype == "Name")
                driver.FindElement(By.Name(element)).Click();
        }
    }
}
