using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using LatestKeys.Framework;
using LatestKeys.Pages;


namespace LatestKeys
{
    class Program
    {
        static void Main(string[] args)
        { }

        [SetUp]
        public void SetupBeforeTest()
        {
            // launch a browser
            DriverBase.driver = new ChromeDriver();
        }
        [TearDown]
        public void AfterEachTest()
        {
           DriverBase.driver.Capture("tearDown");
            //Close the browser.
         // DriverBase.driver.Close();
        }

        [Test]
        public void LoginValidate()
        {
            var insta = new Login();
            insta.LoginSuccess();
        }

        

        [Test]
        public void RegisterValidate()
        {
            var Rpage = new Register();
            Rpage.Navigateregister();
            Rpage.register();
        }

       
            

        }
    }
