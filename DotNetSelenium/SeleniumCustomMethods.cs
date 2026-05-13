using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetSelenium
{
    public class SeleniumCustomMethods
    {
        public static void Click(IWebDriver driver, By locator)
        {
            driver.FindElement(locator).Click();
        }
        public static void EnterText(IWebDriver driver, By locator, string Text)
        {
            driver.FindElement(locator).Clear();
            driver.FindElement(locator).SendKeys(Text);
        }
        
    }
}
