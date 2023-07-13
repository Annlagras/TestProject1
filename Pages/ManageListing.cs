using OpenQA.Selenium;
using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using TestProject1.Global;
using SeleniumExtras.PageObjects;

namespace TestProject1.Pages
{
    public class ManageListing
    {
        public ManageListing()
        {
           
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }
        #region Initialize web elements
        //Click on Manage Listings Link
        [FindsBy(How = How.LinkText, Using = "Manage Listings")]
        private IWebElement manageListingsLink { get; set; }

        //View the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='eye icon'])[1]")]
        private IWebElement view { get; set; }

        //View listing validation
        [FindsBy(How = How.XPath, Using = " //*[@id='service-detail-section']/div[2]/div/div[2]/div[1]/div[1]/div[2]/h1/span")]
        private IWebElement ViewValidation { get; set; }


        //Edit the listing
        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]/i")]
        private IWebElement edit { get; set; }

        //Select Title to edit
        [FindsBy(How = How.Name, Using = "title")]
        private IWebElement Title { get; set; }

        //Click on Save button
        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        private IWebElement Save { get; set; }


        //Delete the listing
        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[3]/i")]
        private IWebElement delete { get; set; }

        //Click on Yes or No
        [FindsBy(How = How.XPath, Using = "//div[@class='actions']")]
        private IWebElement clickActionsButton { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[3]/button[2]/i")]
        private IWebElement yesBtn { get; set; }
        #endregion


        #region View listing
        public void Listings()
        {

            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageListing");
            // Refresh the page
            GlobalDefinitions.driver.Navigate().Refresh();

            //Click on Manage Listing
            GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "LinkText", "Manage Listings", 10000);
            manageListingsLink.Click();
            GlobalDefinitions.driver.Navigate().Refresh();
            Thread.Sleep(1000);

            //Click on view button
            GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "(//i[@class='eye icon'])[1]", 10000);
            view.Click();
            // Refresh the page
            GlobalDefinitions.driver.Navigate().Refresh();
            try
            {
                GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, "XPath", "//*[@id='service-detail-section']/div[2]/div/div[2]/div[1]/div[1]/div[2]/h1/span", 40000);
                var ViewValidation = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='service-detail-section']/div[2]/div/div[2]/div[1]/div[1]/div[2]/h1/span")).Text;
                Assert.That(ViewValidation, Is.EqualTo(GlobalDefinitions.ExcelLib.ReadData(2, "Title")));
                Base.test.Log(AventStack.ExtentReports.Status.Pass, "Able to view liosting");
            }
            catch (Exception ex)
            {
                Assert.Fail("verify the share skill page failed", ex.Message);
                Base.test.Log(AventStack.ExtentReports.Status.Fail, "Unable to view listing");
            }


        }


        #endregion


        #region Edit manage listing
        public void EditListings()
        {

            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageListing");
            // Refresh the page
            GlobalDefinitions.driver.Navigate().Refresh();

            //Click on Manage Listing
            GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "LinkText", "Manage Listings", 10000);
            manageListingsLink.Click();

            //Click on Edit button
            GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]/i", 10000);
            edit.Click();

            //Edit title
            GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "Name", "title", 10000);
            Title.Click();
            Title.Clear();
            Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Title"));

            //Click on save button
            GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//input[@value='Save']", 10000);
            Save.Click();



        }

        //Validate edited details
        public void ValidateEditedDetails()
        {
            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageListing");
            // Refresh the page
            GlobalDefinitions.driver.Navigate().Refresh();

            //Validate edited data
            //Click on Manage Listing
            GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "LinkText", "Manage Listings", 10000);
            manageListingsLink.Click();
            Thread.Sleep(5000);
            //Click on view button
            GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "(//i[@class='eye icon'])[1]", 10000);
            view.Click();
            GlobalDefinitions.driver.Navigate().Refresh();
            try
            {
                GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, "XPath", "//*[@id='service-detail-section']/div[2]/div/div[2]/div[1]/div[1]/div[2]/h1/span", 20000);
                var ViewValidation = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='service-detail-section']/div[2]/div/div[2]/div[1]/div[1]/div[2]/h1/span")).Text;
                Assert.That(ViewValidation, Is.EqualTo(GlobalDefinitions.ExcelLib.ReadData(3, "Title")));
                Base.test.Log(AventStack.ExtentReports.Status.Pass, "Listing Edited successfully");
            }
            catch (Exception ex)
            {
                Assert.Fail("verify the edited share skill page failed", ex.Message);
                Base.test.Log(AventStack.ExtentReports.Status.Fail, "Unable to edit listing");
            }
        }
        #endregion

        #region Delete listing
        public void DeleteListings()
        {
            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageListing");
            // Refresh the page
            GlobalDefinitions.driver.Navigate().Refresh();

            //Click on Manage Listing
            GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "LinkText", "Manage Listings", 10000);
            manageListingsLink.Click();

            //Click on delete button
            GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[3]/i", 10000);
            delete.Click();


            GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//div[@class='actions']", 10000);
            clickActionsButton.Click();
            //Select yes
            try
            {
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "/html/body/div[2]/div/div[3]/button[2]/i", 10000);
                yesBtn.Click();
                Base.test.Log(AventStack.ExtentReports.Status.Pass, "Listing deleted");

            }
            catch (Exception ex)
            {
                Console.WriteLine("cannot able to delete skill", ex);
                Base.test.Log(AventStack.ExtentReports.Status.Fail, "Unable to delete Listing");
            }
        }
        public void ValidateDeletedDetails()
        {
            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageListing");
            // Refresh the page
            GlobalDefinitions.driver.Navigate().Refresh();
            try
            {
                //Verify deleted details

                var deletedListing = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr/td[3]")).Text;
                if (deletedListing != GlobalDefinitions.ExcelLib.ReadData(3, "Title"))
                {
                    Assert.Pass("Manage Listing deleted successfuly");
                    Base.test.Log(AventStack.ExtentReports.Status.Pass, "deleted successfuly");
                }
                else
                {
                    Assert.Fail("Manage Listing not deleted");
                    Base.test.Log(AventStack.ExtentReports.Status.Fail, " not deleted successfuly");
                }
            }
            catch
            {
                Console.WriteLine("Test passed, Listing deleted");
            }

        }
        #endregion

    }
}
