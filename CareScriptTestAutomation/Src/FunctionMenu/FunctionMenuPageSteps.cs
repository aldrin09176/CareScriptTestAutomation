using AventStack.ExtentReports;
using CareScriptTestAutomation.Resources.PageObjects;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareScriptTestAutomation.Src.FunctionMenu
{
    class FunctionMenuPageSteps
    {
        WindowsDriver<WindowsElement> driver;
        FunctionMenuPage functionMenuPage { get; set; }
        ExtentTest test;

        public FunctionMenuPageSteps(WindowsDriver<WindowsElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.functionMenuPage = new FunctionMenuPage(this.driver);
            this.test = test;
        }

        public void selectTransResearch()
        {
            try
            {
                this.functionMenuPage.getAdministrativeMenu().Click();
                this.functionMenuPage.selectTransResearch();
                this.test.Pass("Successfully selected Trans Research");
            }
            catch (Exception ex)
            {
                this.test.Fail("Error with : " + ex.ToString());
            }
        }
        public void selectMonitorQueue()
        {
            try
            {
                this.functionMenuPage.getAdministrativeMenu().Click();
                this.functionMenuPage.selectMonitorQueue();
                this.test.Pass("Successfully selected Monitor Queue");
            }
            catch (Exception ex)
            {
                this.test.Fail("Error with : " + ex.ToString());
            }
        }
        public void selectOutputQueue()
        {
            try
            {
                this.functionMenuPage.getAdministrativeMenu().Click();
                this.functionMenuPage.selectOutputQueue();
                this.test.Pass("Successfully selected Output Queue");
            }
            catch (Exception ex)
            {
                this.test.Fail("Error with : " + ex.ToString());
            }

        }

    }
}
