using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using TestProject1.Global;
using TestProject1.Pages;

namespace TestProject1.Test
{
    public class ShareSkillTest
    {

        [TestFixture, Description("this fixture contains Mars Framework")]

        class User : Global.Base
        {

            [Test, Description("Check if the user is able to add ShareSkill details successfully")]
            public void EnterShareSkill()
            {
                //Create Extent Report
                test = extent.StartTest("Add Share Skill");
                //Add Share Skill
                ShareSkill shareSkillObj = new ShareSkill();
                shareSkillObj.EnterShareSkill();
                shareSkillObj.VerifySkill();
            }


        }
    }
}

