using AventStack.ExtentReports;
using CareScriptTestAutomation.Resources.PageObjects;
using CareScriptTestAutomation.Test;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Xunit;

namespace CareScriptTestAutomation.Src.ChildWindows
{
    class ChildWindowsPageSteps
    {
        WindowsDriver<WindowsElement> driver;
        ChildWindowsPage childWindowsPage { get; set; }
        string dataObjectPath = @"..\\..\\Resources\\GlobalData.json";
        string lastAddedRecordTime;
        Commons commons { get; set; }
        ExtentTest test;
        public ChildWindowsPageSteps(WindowsDriver<WindowsElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.childWindowsPage = new ChildWindowsPage(this.driver);
            this.commons = new Commons(this.driver, test);
            this.test = test;
        }

        public void clickAgent()
        {
           
            try
            {
                this.switchToTransResearchWindow();
                this.childWindowsPage.getAgentBtn().Click();
                this.test.Pass("Successfully clicked Agent");
            }
            catch (Exception ex)
            {
                this.test.Fail("Error with : " + ex.ToString());
            }
        }
        public void switchToTransResearchWindow()
        {
            try
            {

                var current = this.childWindowsPage.getCurrentWindowHandle();
                var allWindowHandles = this.childWindowsPage.getWindowHandles();
                childWindowsPage.switchTo(allWindowHandles, 0);
                this.test.Pass("Successfully switched to Trans Research window");

            }
            catch (Exception ex)
            {
                this.test.Fail("Error with : " + ex.ToString());
            }
            
        }

        public void typeAgentandReturn()
        {
            try
            {
                var data = this.commons.GetJsonData<Agent>(dataObjectPath);
                this.childWindowsPage.getAgentSelectionCmbBox().SendKeys(data.Aldrin);
                this.childWindowsPage.getReturnBtn().Click();
                this.test.Pass("Successfully typed the agent and returned.");
            }
            catch (Exception ex)
            {
                this.test.Fail("Error with : " + ex.ToString());
            }

        }

        public void validateAddedRecords(string expected)
        {
            var data = this.commons.GetJsonData<Agent>(dataObjectPath);

            var current = this.childWindowsPage.getCurrentWindowHandle();
            var allWindowHandles = this.childWindowsPage.getWindowHandles();
            this.childWindowsPage.switchTo(allWindowHandles, 0);
            this.clickAgent();

            this.childWindowsPage.switchTo(allWindowHandles, 1);
            this.typeAgentandReturn();

            this.childWindowsPage.switchTo(allWindowHandles, 0);
            this.childWindowsPage.getGetCallsbtn().Click();

            this.clickTimeColumn();

            try
            {
                this.commons.dragElementTo(this.childWindowsPage.getUpperGridScrollBar(), 0, 80);
            }
            catch (Exception ex)
            { }

            this.clickServiceReferralUpperGridLastRow();

            //MessageBox.Show(this.childWindowsPage.getLowerGridRowCount().ToString());

            var actual = this.childWindowsPage.getLowerGridLastRowText().Trim();
            var result = this.commons.assertEqualString(expected, actual);

            try
            {
                Assert.True(result);
                this.test.Pass("Data is verified existent in the records");
            }
            catch (Exception ex)
            {
                this.test.Fail("Data is not existing in the records");
            }
            this.childWindowsPage.getCloseBtn().Click();
            this.driver.SwitchTo().Window(current);

        }

        public void verifyAddedRecordsInServiceReferral()
        {

            var data = this.commons.GetJsonData<Agent>(dataObjectPath);

            var current = this.childWindowsPage.getCurrentWindowHandle();
            var allWindowHandles = this.childWindowsPage.getWindowHandles();
            this.childWindowsPage.switchTo(allWindowHandles, 0);
            this.clickAgent();

            this.childWindowsPage.switchTo(allWindowHandles, 1);
            this.typeAgentandReturn();

            this.childWindowsPage.switchTo(allWindowHandles, 0);
            this.childWindowsPage.getGetCallsbtn().Click();
            this.clickTimeColumn();

            try
            {
                this.commons.dragElementTo(this.childWindowsPage.getUpperGridScrollBar(), 0, 80);
            }
            catch (Exception ex) 
            {}
            
            this.clickServiceReferralUpperGridLastRow();

            var expected = "Service Referral";
            var actual = this.childWindowsPage.getServiceReferralDetaStr().Trim();
            var result = this.commons.assertEqualString(expected, actual);

            try
            {
                Assert.True(result);
                this.test.Pass("Data is verified existent in the records");
            }
            catch (Exception ex)
            {
                this.test.Fail("Data is not existing in the records");
            }
            
            this.childWindowsPage.getCloseBtn().Click();

            this.driver.SwitchTo().Window(current);

        }
        public void clickServiceReferralUpperGridLastRow()
        {
            try
            {
                this.childWindowsPage.getServiceReferralUpperGridLastRow().Click();

                this.test.Pass("Successfully clicked last row");
            }
            catch (Exception ex)
            {
                this.test.Fail("Error with : " + ex.ToString());
            }
        }
        public void clickTimeColumn() 
        {
            try 
            {
                this.childWindowsPage.getServiceReferralTimeColumn().Click();
                this.test.Pass("Successfully clicked Time column");
            }
            catch (Exception ex)
            {
                this.test.Fail("Error with : " + ex.ToString());
            }
            
        }
    }
}
