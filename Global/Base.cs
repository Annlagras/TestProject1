
    using TestProject1.Config;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TestProject1.Global.GlobalDefinitions;
using TestProject1.Pages;
using NUnit.Framework;
using AventStack.ExtentReports;

namespace TestProject1.Global
{
 public class Base
    {

        #region To access Path from resource file

        public static int Browser = Int32.Parse(MarsResource.Browser);
        public static String ExcelPath = MarsResource.ExcelPath;
        public static string ScreenshotPath = MarsResource.ScreenShotPath;
        public static string ReportPath = MarsResource.ReportPath;
        public static string SampleWorkPath = MarsResource.SampleWorkPath;
        #endregion

        #region reports
        public static ExtentTest test;
        public static ExtentReports extent;
        #endregion

        #region setup and tear down
        [SetUp]
        public void Inititalize()
        {

            switch (Browser)
            {

                case 1:
                    GlobalDefinitions.driver = new FirefoxDriver();
                    break;
                case 2:
                    GlobalDefinitions.driver = new ChromeDriver();
                    GlobalDefinitions.driver.Manage().Window.Maximize();
                    break;

            }

            //Populate the excel data
            Thread.Sleep(5000);
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "SignIn");
            GlobalDefinitions.driver.Navigate().GoToUrl(GlobalDefinitions.ExcelLib.ReadData(2, "Url"));

            #region Initialise Reports
            extent = new ExtentReports(ReportPath, false, DisplayOrder.NewestFirst);
            extent.LoadConfig(MarsResource.ReportXMLPath);

            #endregion

            if (MarsResource.IsLogin == "true")
            {
                //Create Extent Report
                test = extent.StartTest("SignIn", "Anna");
                //SignIn
                SignIn loginobj = new SignIn();
                loginobj.LoginSteps();
            }
            else
            {
                //Create Extent Report
                test = extent.StartTest("Join", "Anna");
                //Join
                SignUp obj = new SignUp();
                obj.register();
            }

        }


        [TearDown]
        public void TearDown()
        {
            // Screenshot
            String img = SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "C:\\Users\\Monday Designs Admin\\Desktop\\internship\\MarsFramework1\\TestReports");
            test.Log(Status.Info, "Image example: " + img);

            // end test. (Reports)
            extent.EndTest(test);

            // calling Flush writes everything to the log file (Reports)
            extent.Flush();

            // Close the driver :)
            // 
            GlobalDefinitions.driver.Close();
            GlobalDefinitions.driver.Quit();
        }
        #endregion

    }
}

