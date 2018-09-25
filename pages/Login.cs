
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LatestKeys.Framework;
using LatestKeys.Framework.Extensions;

namespace LatestKeys.Pages
    {
        class Login
        {
            public Login()
            {
                PageFactory.InitElements(DriverBase.driver, this);
            }
            [FindsBy(How = How.XPath, Using = "//*[@id='app']/div/div/div/div/div/form/div[1]/input")]
            private IWebElement Email { get; set; }

            [FindsBy(How = How.XPath, Using = "//*[@id='app']/div/div/div/div/div/form/div[2]/input")]
            private IWebElement Password { get; set; }

            //private int i { get; set; }
            [FindsBy(How = How.XPath, Using = "//*[@id='app']/div/div/div/div/div/form/div[3]/button")]
            private IWebElement loginBtn { get; set; }

            public void LoginSuccess()
            {
                var fileName = @"D:\LatestKeys\LatestKeys\LatestKeys\ExcelData\InputData.xlsx";
                var sheetName = "Login";

                // Populate the data from Excel
                ExcelLibHelpers.PopulateInCollection(fileName, sheetName);
                var Url = ExcelLibHelpers.ReadData(2, "url");

                // open the turn up login page. 
                
                DriverBase.driver.Navigate().GoToUrl(Url);

                // Identify username and password.
                             
         
                Email.WaitForElement(TimeSpan.FromSeconds(2));
                Email.SendKeys(ExcelLibHelpers.ReadData(2, "Email"));

               Password.SendKeys(ExcelLibHelpers.ReadData(2, "Password"));

                //Click the Login Btn
               
                loginBtn.Click();

            }



        }
    }

