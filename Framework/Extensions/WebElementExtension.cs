using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatestKeys.Framework.Extensions
{
    public static class WebElementExtension
    {
        // 2 parameters
        public static void WaitForElement(this IWebElement element, TimeSpan Time)
        {
            //var wait = new WebDriverWait(DriverBase.driver, TimeSpan.FromSeconds(10));
            var wait = new WebDriverWait(DriverBase.driver, Time);
            wait.Until(ExpectedConditions.ElementToBeClickable(element));

        }
    }
}