using AventStack.ExtentReports;
using CareScriptTestAutomation.Resources.PageObjects;
using CareScriptTestAutomation.Src.StatusPanel.DataObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CareScriptTestAutomation.Src.StatusPanel
{
    class StatusPanelPageSteps
    {
        WindowsDriver<WindowsElement> driver;
        string dataObjectPath = @"..\\..\\Resources\\GlobalData.json";
        StatusPanelPage statusPanelPage { get; set; }
        Commons commons { get; set; }
        ExtentTest test { get; set; }
 

        public StatusPanelPageSteps(WindowsDriver<WindowsElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.statusPanelPage = new StatusPanelPage(this.driver);
            this.commons = new Commons(this.driver, test);
            this.test = test;
        }

        public void selectAdminWork()
        {

            try
            {
                this.statusPanelPage.getStatusCmbBox().Click();
                this.statusPanelPage.getAdminWorkOption().Click();
                this.test.Pass("Successfully selected Admin Work");
            }
            catch (Exception ex)
            {
                this.test.Fail("Error with : " + ex.ToString());
            }
             
        }

        public void logOut()
        {
            try
            {
                this.statusPanelPage.getStatusCmbBox().Click();
                this.statusPanelPage.getLogOut().Click();
                this.commons.clickYes();
                System.Threading.Thread.Sleep(5000);
                this.test.Pass("Successfully logged out");
            }
            catch(Exception ex)
            {
                this.test.Fail("Error with : " + ex.ToString());

            }

        }
        public void selectFacility()
        { 
            try
            {
                var data = this.commons.GetJsonData<Data>(dataObjectPath);
                this.statusPanelPage.getFacilityCmbBox().SendKeys(data.At1);
                this.statusPanelPage.getFacilityCmbBox().SendKeys(Keys.Enter);
                this.test.Pass("Successfully selected Facility : " + data.At1);
            }
            catch(Exception ex)
            {
                this.test.Fail("Error with : " + ex.ToString());
            }

        }

        public void selectMessage()
        {
            try
            {
                this.statusPanelPage.getCategoryMessaging().Click();
                this.test.Pass("Successfully selected Message category");
            }
            catch(Exception ex)
            {
                this.test.Fail("Error with : " + ex.ToString());
            }
        }

        public void selectGeneralInfo()
        {
            try
            {
                this.statusPanelPage.getGeneralInfo().SendKeys(Keys.Enter);
                this.test.Pass("Successfully selected General Info");
            }
            catch(Exception ex)
            {
                this.test.Fail("Error with : " + ex.ToString());
            }
            
        }

        public void selectGeneralMessage()
        {
            try
            {
                this.statusPanelPage.getGeneralMessage().SendKeys(Keys.Enter);
                this.test.Pass("Successfully selected General Message");
            }
            catch(Exception ex)
            {
                this.test.Fail("Error with : " + ex.ToString());
            }

        }

        public void selectNewBabyReport()
        {
            try
            {
                this.statusPanelPage.getNewBabyReport().SendKeys(Keys.Enter);
                this.test.Pass("Successfully selected New Baby Report");
            }
            catch (Exception ex)
            {
                this.test.Fail("Error with : " + ex.ToString());
            }
        }

        public void selectCategoryServices()
        {
            try
            {
                this.statusPanelPage.getCategoryServices().SendKeys(Keys.Enter);
                this.test.Pass("Successfully selected Service category");
            }
            catch(Exception ex)
            {
                this.test.Fail("Error with : " + ex.ToString());
            }
        }

        public void selectTypePhysicianReferral()
        {
            try
            {
                this.statusPanelPage.getTypePhysicianReferral().Click();
                this.statusPanelPage.getTypePhysicianReferral().SendKeys(Keys.Enter);
                this.test.Pass("Successfully selected Physician Referral");
            }
            catch(Exception ex)
            {
                this.test.Fail("Error with : " + ex.ToString());
            }

        }
        public void selectTypeTriage()
        {
            try
            {
                this.statusPanelPage.getTriage().Click();
                this.statusPanelPage.getTriage().SendKeys(Keys.Enter);
                this.test.Pass("Successfully selected Triage");
            }
            catch (Exception ex)
            {
                this.test.Fail("Error with : " + ex.ToString());
            }
        }
        public void selectTypeServiceReferral()
        {
            try
            {
                this.statusPanelPage.getServiceReferral().Click();
                this.statusPanelPage.getServiceReferral().SendKeys(Keys.Enter);
                this.test.Pass("Successfully selected Service Referral");
            }
            catch (Exception ex)
            {
                this.test.Fail("Error with : " + ex.ToString());
            }

        }
    }
}
