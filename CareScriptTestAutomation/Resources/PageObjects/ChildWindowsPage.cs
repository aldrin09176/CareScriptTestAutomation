using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareScriptTestAutomation.Resources.PageObjects
{
    class ChildWindowsPage
    {
        WindowsDriver<WindowsElement> driver;
        public ChildWindowsPage(WindowsDriver<WindowsElement> driver)
        {
            this.driver = driver;
        }

        public ReadOnlyCollection<string> getWindowHandles()
        {
            return driver.WindowHandles;
        }
        public string getCurrentWindowHandle()
        {
            return driver.CurrentWindowHandle;
        }

        public void switchTo(ReadOnlyCollection<string> windowHandle, int index)
        {
            driver.SwitchTo().Window(windowHandle[index]);
        }

        public WindowsElement getAgentBtn()
        {
            return driver.FindElementByAccessibilityId("btAgent");
        }

        public WindowsElement getAgentSelectionCmbBox()
        {
            return driver.FindElementByAccessibilityId("dcbAgent");
        }
        public WindowsElement getReturnBtn()
        {
            return driver.FindElementByAccessibilityId("btReturn");
        }

        public WindowsElement getGetCallsbtn()
        {
            return driver.FindElementByAccessibilityId("btGetTrans");
        }

        public WindowsElement getFirstRow()
        { 
            return driver.FindElementByName("Time Row 0, Not sorted.");
        }

        public WindowsElement getCloseBtn()
        {
            return driver.FindElementByAccessibilityId("Close");
        }

        public WindowsElement getServiceReferralTimeColumn() 
        {
            return driver.FindElementByName("Time");
        }
        public WindowsElement getUpperGridScrollBar()
        {
            return driver.FindElementByXPath("//ScrollBar[@Name='Vertical Scroll Bar']/Thumb[@Name=\'Position']");
        }
        public WindowsElement getServiceReferralUpperGridLastRow()
        {
            int ct = this.getServiceReferralLastRowCount() - 2;
            return driver.FindElementByName("Row " + ct.ToString());
        }
        public int getServiceReferralLastRowCount()
        {
            return driver.FindElementsByXPath("//Table[@AutomationId='dbgTrxMaster']/Custom[contains(@Name, 'Row')]").Count();
        }
        public int getLowerGridRowCount()
        {
            return driver.FindElementsByXPath("//Table[@AutomationId='dbgTrans']/Custom[contains(@Name, 'Row')]").Count();
        }

        public string getLowerGridLastRowText() 
        {
            int ct = this.getLowerGridRowCount() - 2;
   
            return driver.FindElementByName("Trans Type Row " + ct.ToString() + ", Not sorted.").Text;
        }
        public string getServiceReferralDetaStr()
        {
            return driver.FindElementByName("Trans Type Row 1, Not sorted.").Text;
        }
        public string getGeneralInfoDetaStr()
        {
            return driver.FindElementByName("Trans Type Row 0, Not sorted.").Text;
        }

        public WindowsElement getFirstRowNewBaby()
        {
            return driver.FindElementByName("Row 0");
        }
        public WindowsElement getNewBabyOverrideReason() 
        {
            return driver.FindElementByAccessibilityId("dcbOverRideReason");
        }
    }
}
