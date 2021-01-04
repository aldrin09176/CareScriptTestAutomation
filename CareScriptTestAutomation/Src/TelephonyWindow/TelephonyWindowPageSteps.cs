using AventStack.ExtentReports;
using CareScriptTestAutomation.Resources.PageObjects;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareScriptTestAutomation.Src.TelephonyWindow
{
    class TelephonyWindowPageSteps
    {
        WindowsDriver<WindowsElement> driver { get; set; }
        TelephonyWindowPage telephonyWindowPage { get; set; }
        ExtentTest test { get; set; }

        public TelephonyWindowPageSteps(WindowsDriver<WindowsElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.telephonyWindowPage = new TelephonyWindowPage(this.driver);
            this.test = test;
        }
        public void telephonyClickRejectAll()
        {
            try
            { 
                this.telephonyWindowPage.getRejectAllBtn().Click();
                this.test.Pass("Successfully clicked Reject All");
            }
            catch (Exception ex)
            {
                this.test.Fail("Error with : " + ex.ToString());
            }
            
        }
    }
}
