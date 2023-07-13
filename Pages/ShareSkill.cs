using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.Global;
using NUnit.Framework;



namespace TestProject1.Pages
{
    public class ShareSkill
    {
        public ShareSkill()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }
        #region Initialize web elements
        //Click on ShareSkill Button
        [FindsBy(How = How.LinkText, Using = "Share Skill")]
        private IWebElement ShareSkillButton { get; set; }

        //Enter the Title in textbox
        [FindsBy(How = How.Name, Using = "title")]
        private IWebElement Title { get; set; }

        //Enter the Description in textbox
        [FindsBy(How = How.Name, Using = "description")]
        private IWebElement Description { get; set; }

        //Click on Category Dropdown
        [FindsBy(How = How.Name, Using = "categoryId")]
        private IWebElement CategoryDropDown { get; set; }

        //Click on SubCategory Dropdown
        [FindsBy(How = How.Name, Using = "subcategoryId")]
        private IWebElement SubCategoryDropDown { get; set; }

        //Enter Tag names in textbox
        [FindsBy(How = How.XPath, Using = "//input[@value='']")]
        private IWebElement Tags { get; set; }

        //Select the Service type
        [FindsBy(How = How.XPath, Using = "//form/div[5]/div[@class='twelve wide column']/div/div[@class='field']")]
        private IWebElement ServiceTypeOptions { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input")]
        private IWebElement ServicetypeHourly { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input")]
        private IWebElement ServicetypeOneOff { get; set; }

        //Select the Location Type
        [FindsBy(How = How.XPath, Using = "//form/div[6]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement LocationTypeOption { get; set; }

        //Select Onsite
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input")]
        private IWebElement LocationSelOnsite { get; set; }

        //Select Online
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input")]
        private IWebElement LocationSelOnline { get; set; }



        //Click on Start Date dropdown
        [FindsBy(How = How.Name, Using = "startDate")]
        private IWebElement StartDateDropDown { get; set; }

        //Click on End Date dropdown
        [FindsBy(How = How.Name, Using = "endDate")]
        private IWebElement EndDateDropDown { get; set; }

        //Storing the table of available days
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[@class='ui container']/div[@class='listing']/form[@class='ui form']/div[7]/div[2]/div[1]")]
        private IWebElement Days { get; set; }

        //Select days Mon
        [FindsBy(How = How.XPath, Using = "(//input[@name='Available'])[2]")]
        private IWebElement Mon { get; set; }

        //Select days Tuesday
        [FindsBy(How = How.XPath, Using = "(//input[@name='Available'])[3]")]
        private IWebElement Tue { get; set; }

        //Select days Wednesday
        [FindsBy(How = How.XPath, Using = "(//input[@name='Available'])[4]")]
        private IWebElement Wed { get; set; }

        //Select days Thursday
        [FindsBy(How = How.XPath, Using = "(//input[@name='Available'])[5]")]
        private IWebElement Thurs { get; set; }



        //Storing the starttime from drop down
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[2]/input")]
        private IWebElement StartTimeM { get; set; }

        [FindsBy(How = How.XPath, Using = "(//input[@name='StartTime'])[2]")]
        private IWebElement StartTimeDropDownM { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[4]/div[2]/input")]
        private IWebElement StartTimeT { get; set; }

        [FindsBy(How = How.XPath, Using = "(//input[@name='StartTime'])[3]")]
        private IWebElement StartTimeDropDownT { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[5]/div[2]/input")]
        private IWebElement StartTimeW { get; set; }

        [FindsBy(How = How.XPath, Using = "(//input[@name='StartTime'])[4]")]
        private IWebElement StartTimeDropDownW { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[6]/div[2]/input")]
        private IWebElement StartTimeTh { get; set; }

        [FindsBy(How = How.XPath, Using = "(//input[@name='StartTime'])[5]")]
        private IWebElement StartTimeDropDownTh { get; set; }




        //Storing the Endtime from drop down
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[3]/input")]
        private IWebElement EndTimeM { get; set; }

        [FindsBy(How = How.XPath, Using = "(//input[@name='EndTime'])[2]")]
        private IWebElement EndTimeDropDownM { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[4]/div[3]/input")]
        private IWebElement EndTimeT { get; set; }

        [FindsBy(How = How.XPath, Using = "(//input[@name='EndTime'])[3]")]
        private IWebElement EndTimeDropDownT { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[5]/div[3]/input")]
        private IWebElement EndTimeW { get; set; }

        [FindsBy(How = How.XPath, Using = "(//input[@name='EndTime'])[4]")]
        private IWebElement EndTimeDropDownW { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[6]/div[3]/input")]
        private IWebElement EndTimeTh { get; set; }

        [FindsBy(How = How.XPath, Using = "(//input[@name='EndTime'])[5]")]
        private IWebElement EndTimeDropDownTh { get; set; }



        //Click on Skill Trade option
        [FindsBy(How = How.XPath, Using = "//form/div[8]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement SkillTradeOption { get; set; }

        //Enter Skill Exchange
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input")]
        private IWebElement SkillExchange { get; set; }

        //Select credit option
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input")]
        private IWebElement CreditBtn { get; set; }

        //Add credit amount
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/input")]
        private IWebElement CreditAmount { get; set; }

        // Add Work Samples
        [FindsBy(How = How.XPath, Using = "//i[@class='huge plus circle icon padding-25']")]
        private IWebElement FileUpload { get; set; }

        //Click on Active/Hidden option
        [FindsBy(How = How.XPath, Using = "//form/div[10]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement ActiveOption { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[2]/div/input")]
        private IWebElement HiddenOpt { get; set; }

        //Click on Save button
        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        private IWebElement Save { get; set; }

        //Click on Cancel button
        [FindsBy(How = How.XPath, Using = "//input[@value='Cancel']")]
        private IWebElement Cancel { get; set; }

        //Validate share skill details
        //Click on manage listing
        [FindsBy(How = How.XPath, Using = "//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[2]/button[2]")]
        private IWebElement ManageLis { get; set; }

        #endregion

        #region Enter share skill
        //Add share skill details
        public void EnterShareSkill()
        {
            //Populate the excel data

            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");

            try
            {
                #region Navigate to Share Skills Page
                //Click on Share skill button
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "LinkText", "Share Skill", 10000);
                ShareSkillButton.Click();
                #endregion

                #region Enter Title 
                //Enter the Title in textbox
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "Name", "title", 10000);
                Title.Click();
                Title.Clear();
                Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));
                #endregion

                #region Enter Description
                //Enter the Description in textbox
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "Name", "description", 10000);
                Description.Click();
                Description.Clear();
                Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));
                #endregion

                #region Category Drop Down
                //Select catagory from drop down
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "Name", "categoryId", 10000);
                CategoryDropDown.Click();
                new SelectElement(CategoryDropDown).SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "Category"));

                //Select catagory from drop down
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "Name", "subcategoryId", 10000);
                SubCategoryDropDown.Click();
                new SelectElement(SubCategoryDropDown).SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "SubCategory"));
                #endregion

                #region Tags
                //Enter Tag names in textbox
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//input[@value='']", 10000);
                Tags.Click();
                Tags.Clear();
                Tags.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Tags"));
                Tags.SendKeys(Keys.Enter);
                #endregion

                #region Service Type Selection
                //Select service type
                if (GlobalDefinitions.ExcelLib.ReadData(2, "ServiceType") == "Hourly basis service")
                {
                    GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//form/div[5]/div[@class='twelve wide column']/div/div[@class='field']", 10000);
                    ServiceTypeOptions.Click();
                    ServicetypeHourly.Click();
                }
                else if (GlobalDefinitions.ExcelLib.ReadData(2, "ServiceType") == "One-off service")
                {
                    GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//form/div[5]/div[@class='twelve wide column']/div/div[@class='field']", 10000);
                    ServiceTypeOptions.Click();
                    ServicetypeOneOff.Click();
                }
                #endregion

                #region Select Location Type
                //Select the Location Type
                if (GlobalDefinitions.ExcelLib.ReadData(2, "LocationType") == "On-site")
                {
                    GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//form/div[6]/div[@class='twelve wide column']/div/div[@class = 'field']", 10000);
                    LocationTypeOption.Click();
                    LocationSelOnsite.Click();
                }
                else if (GlobalDefinitions.ExcelLib.ReadData(2, "LocationType") == "Online")
                {
                    GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//form/div[6]/div[@class='twelve wide column']/div/div[@class = 'field']", 10000);
                    LocationTypeOption.Click();
                    LocationSelOnline.Click();
                }

                #endregion


                #region Select Available Dates from Calendar
                //Add start date
                StartDateDropDown.Click();
                // StartDateDropDown.Clear();
                StartDateDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Startdate"));

                //Add End date
                EndDateDropDown.Click();
                //EndDateDropDown.Clear();
                EndDateDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Enddate"));


                //Select available days
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//body/div/div/div[@id='service-listing-section']/div[@class='ui container']/div[@class='listing']/form[@class='ui form']/div[7]/div[2]/div[1]", 10000);
                Days.Click();
                Mon.Click();
                Tue.Click();
                Wed.Click();
                Thurs.Click();

                //Select start time and enter the time
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[2]/input", 10000);
                StartTimeM.Click();

                StartTimeDropDownM.Click();

                StartTimeM.SendKeys(DateTime.Parse(GlobalDefinitions.ExcelLib.ReadData(2, "Starttime")).ToString("hh:mmtt"));

                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[4]/div[2]/input", 10000);
                StartTimeT.Click();

                StartTimeDropDownT.Click();

                StartTimeT.SendKeys(DateTime.Parse(GlobalDefinitions.ExcelLib.ReadData(2, "Starttime")).ToString("hh:mmtt"));

                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[5]/div[2]/input", 10000);
                StartTimeW.Click();

                StartTimeDropDownW.Click();

                StartTimeW.SendKeys(DateTime.Parse(GlobalDefinitions.ExcelLib.ReadData(2, "Starttime")).ToString("hh:mmtt"));

                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[6]/div[2]/input", 10000);
                StartTimeTh.Click();

                StartTimeDropDownTh.Click();

                StartTimeTh.SendKeys(DateTime.Parse(GlobalDefinitions.ExcelLib.ReadData(2, "Starttime")).ToString("hh:mmtt"));



                //Select end time from box
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[3]/input", 10000);
                EndTimeM.Click();

                EndTimeDropDownM.Click();

                EndTimeM.SendKeys(DateTime.Parse(GlobalDefinitions.ExcelLib.ReadData(2, "Endtime")).ToString("hh:mmtt"));

                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[4]/div[3]/input", 10000);
                EndTimeT.Click();

                EndTimeDropDownT.Click();

                EndTimeT.SendKeys(DateTime.Parse(GlobalDefinitions.ExcelLib.ReadData(2, "Endtime")).ToString("hh:mmtt"));

                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[5]/div[3]/input", 10000);
                EndTimeW.Click();

                EndTimeDropDownW.Click();

                EndTimeW.SendKeys(DateTime.Parse(GlobalDefinitions.ExcelLib.ReadData(2, "Endtime")).ToString("hh:mmtt"));

                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[6]/div[3]/input", 10000);
                EndTimeTh.Click();

                EndTimeDropDownTh.Click();

                EndTimeTh.SendKeys(DateTime.Parse(GlobalDefinitions.ExcelLib.ReadData(2, "Endtime")).ToString("hh:mmtt"));
                Thread.Sleep(1000);
                #endregion

                #region Select Skill Trade
                //Click on Skill trade option

                if (GlobalDefinitions.ExcelLib.ReadData(2, "SkillTrade") == "Skill-Exchange")
                {
                    GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//form/div[8]/div[@class='twelve wide column']/div/div[@class='field']", 10000);
                    SkillTradeOption.Click();

                    //Add Skill exchange tag
                    GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input", 10000);
                    SkillExchange.Click();
                    SkillExchange.Clear();
                    SkillExchange.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Skill-Exchange"));
                    SkillExchange.SendKeys(Keys.Enter);


                }
                else if (GlobalDefinitions.ExcelLib.ReadData(2, "SkillTrade") == "Credit")
                {

                    GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//form/div[8]/div[@class='twelve wide column']/div/div[@class='field']", 10000);
                    SkillTradeOption.Click();
                    CreditBtn.Click();

                    //Addcredit amount
                    GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/input", 10000);
                    CreditAmount.Click();
                    CreditAmount.Clear();
                    CreditAmount.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "AmountInExchange"));
                    CreditAmount.SendKeys(Keys.Enter);
                }

                #endregion


                #endregion

                #region Select User Status
                //Select option Active or Hidden
                if (GlobalDefinitions.ExcelLib.ReadData(2, "UserStatus") == "Active")
                {
                    GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//form/div[10]/div[@class='twelve wide column']/div/div[@class = 'field']", 10000);
                    ActiveOption.Click();
                }
                else if (GlobalDefinitions.ExcelLib.ReadData(2, "UserStatus") == "Hidden")
                {
                    GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//form/div[10]/div[@class='twelve wide column']/div/div[@class = 'field']", 10000);
                    ActiveOption.Click();
                    HiddenOpt.Click();
                }
                #endregion


                #region Save / Cancel Skill
                // Save or Cancel New Skill

                if (Global.GlobalDefinitions.ExcelLib.ReadData(2, "SaveOrCancel") == "Save")
                {
                    GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//input[@value='Save']", 10000);
                    Save.Click();
                }
                else if (Global.GlobalDefinitions.ExcelLib.ReadData(2, "SaveOrCancel") == "Cancel")
                {
                    Cancel.Click();
                }
                #endregion
            }

            catch (Exception ex)
            {
                Assert.Fail("Test failed to enter Skill details", ex.Message);
            }
        }



        #region Validate share skill
        //Verify Share skill

        public void VerifySkill()
        {

            //Populate the excel data

            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");

            //Verify share skill details

            GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[2]/button[2]", 10000);
            ManageLis.Click();
            GlobalDefinitions.driver.Navigate().Refresh();
            try
            {
                GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, "XPath", "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[2]", 10000);
                var categorycheck = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[2]")).GetAttribute("textContent");
                Assert.That(categorycheck, Is.EqualTo(GlobalDefinitions.ExcelLib.ReadData(2, "Category")));

                GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, "XPath", "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]", 10000);
                var titlecheck = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]")).GetAttribute("textContent");
                Assert.That(titlecheck, Is.EqualTo(GlobalDefinitions.ExcelLib.ReadData(2, "Title")));
                Base.test.Log(AventStack.ExtentReports.Status.Pass, "Share skill added successfully");
            }
            catch (Exception ex)
            {
                Assert.Fail("verify the share skill page failed", ex.Message);
                Base.test.Log(AventStack.ExtentReports.Status.Fail, "Share skill not added");

            }
        }
        #endregion



    }
}
