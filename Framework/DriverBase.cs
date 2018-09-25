using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatestKeys.Framework
{
    public static class DriverBase
    {
        public static IWebDriver driver;
       // private static string screenShotPath;

       public static void Capture(this IWebDriver driver, string screenShotName)
        {
            string executingAssemblyPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string trunkedPath = executingAssemblyPath.Replace(@"\bin\Debug\LatestKeys.exe", "");

            //Console.WriteLine("E path " + executingAssemblyPath);
            //Console.WriteLine("trunk path" + trunkedPath);
            var screenShotPath = trunkedPath + @"\Screenshots\";
            // Create Folder
            Directory.CreateDirectory(screenShotPath);
            var finalpath = screenShotPath + screenShotName + ".png";

            //take screenshot
            Screenshot screeshot = ((ITakesScreenshot)DriverBase.driver).GetScreenshot();
            //save screeshot
            screeshot.SaveAsFile(finalpath);
        }
    }

}
