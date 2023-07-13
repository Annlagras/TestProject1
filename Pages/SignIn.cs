using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.Global;

namespace TestProject1.Pages
{
    public class SignIn
    {
        public SignIn()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        
        }

        #region  Initialize Web Elements 
        //Finding the Sign Link
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Sign')]")]
        private IWebElement SignIntab { get; set; }

        // Finding the Email Field
        [FindsBy(How = How.Name, Using = "email")]
        private IWebElement Email { get; set; }

        //Finding the Password Field
        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement Password { get; set; }

        //Finding the Login Button
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Login')]")]
        private IWebElement LoginBtn { get; set; }

        #endregion

        #region Loginsteps
        public void LoginSteps()
        {
            //Populate the excel data

            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "SignIn");

            //Click on SignIn
            SignIntab.Click();

            //Enter Username
            Email.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Username"));

            //Enter Password
            Password.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Password"));

            //Click login
            LoginBtn.Click();
            try
            {
                GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, "XPath", "//*[contains(text(),'Ishaan Sandeep')]", 10000);
                // check login is successfull
                var loginCheck = "test";
                loginCheck = GlobalDefinitions.driver.FindElement(By.XPath("//*[contains(text(),'Ishaan Sandeep')]")).GetAttribute("innerText");

                Assert.That(loginCheck == "Ishaan Sandeep");
                Base.test.Log(AventStack.ExtentReports.Status.Pass, "Login Passed");

            }
            catch (Exception ex)
            {
                Assert.Fail("Test failed at login step", ex.Message);
                Base.test.Log( "Login failed");

            }


        }
        #endregion

    }
}
