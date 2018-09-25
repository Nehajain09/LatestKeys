using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LatestKeys.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace LatestKeys.Pages
{
    public class Register
    {
        internal Register()
        {
            PageFactory.InitElements(DriverBase.driver, this);

        }
        //Click on Register Link
        [FindsBy(How = How.XPath, Using = "//*[@id='app']/div/div/div/div/div/form/div[3]/a")]
        private IWebElement RegisterLink { get; set; }

        //Enter FirstName
        [FindsBy(How = How.XPath, Using = "//*[@id='app']/div/div/div/div/div/form/div[1]/input")]
        private IWebElement FirstName { get; set; }

        //Enter LastName
        [FindsBy(How = How.XPath, Using = "//*[@id='app']/div/div/div/div/div/form/div[2]/input")]
        private IWebElement LastName { get; set; }

        //click on UserName
        [FindsBy(How = How.XPath, Using = "//*[@id='app']/div/div/div/div/div/form/div[3]/input")]
        private IWebElement Email { get; set; }

        //Click on Password
        [FindsBy(How = How.XPath, Using = "//*[@id='app']/div/div/div/div/div/form/div[4]/input")]
        private IWebElement Password { get; set; }

        

        //Click on Register Button
        [FindsBy(How = How.XPath, Using = "//*[@id='app']/div/div/div/div/div/form/div[5]/button")]
        private IWebElement Registerbutton { get; set; }

        public void Navigateregister()
        {
            var fileName = @"D:\LatestKeys\LatestKeys\LatestKeys\ExcelData\InputData.xlsx";
            var sheetName = "Login";
            ExcelLibHelpers.PopulateInCollection(fileName, sheetName);
            var Url = ExcelLibHelpers.ReadData(2, "url");
            DriverBase.driver.Navigate().GoToUrl(Url);
        }
        public void Commonsteps()
        {
            System.Threading.Thread.Sleep(5000);
            RegisterLink.Click();
        }

        internal void register()
        {

            var fileName1 = @"D:\LatestKeys\LatestKeys\LatestKeys\ExcelData\InputData.xlsx";
            var sheetName = "Register";
            ExcelLibHelpers.PopulateInCollection(fileName1,sheetName);
            Commonsteps();

            //Read FirstName
            FirstName.SendKeys(ExcelLibHelpers.ReadData(2, "FirstName"));

            //Read LastName
            LastName.SendKeys(ExcelLibHelpers.ReadData(2, "LastName"));

            //Read Email
            Email.SendKeys(ExcelLibHelpers.ReadData(2, "Email"));
            //Register.WaitForElement(TimeSpan.FromSeconds(2));

            //Read Password
            Password.SendKeys(ExcelLibHelpers.ReadData(2, "Password"));

            
            Thread.Sleep(2000);
            
            //Click on Signup
            Registerbutton.Click();
        }
    }
}
