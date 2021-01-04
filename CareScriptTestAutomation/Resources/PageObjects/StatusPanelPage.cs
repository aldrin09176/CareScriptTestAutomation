using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareScriptTestAutomation.Resources.PageObjects
{
    class StatusPanelPage
    {
        WindowsDriver<WindowsElement> driver;
        public StatusPanelPage(WindowsDriver<WindowsElement> driver)
        {
            this.driver = driver;
        }
        
        public WindowsElement getStatusCmbBox()
        {
            System.Threading.Thread.Sleep(5000);
            return driver.FindElementByAccessibilityId("dcbAgentManualStatus");
        }

        public WindowsElement getAdminWorkOption()
        {
            return driver.FindElementByXPath("//ListItem[6]");
        }

        public WindowsElement getLogOut()
        {
            return driver.FindElementByXPath("//ListItem[14]");
        }

        public WindowsElement getFacilityCmbBox()
        {
            return driver.FindElementByAccessibilityId("dcbFacility");
        }

        public WindowsElement getCategoryMessaging()
        {
            return driver.FindElementByName("M-Messaging");
        }

        public WindowsElement getCategoryServices()
        {
            return driver.FindElementByName("S-Services");
        }

        public WindowsElement getGeneralInfo()
        {
            return driver.FindElementByName("I-General Info");
        }
        public WindowsElement getGeneralMessage()
        {
            return driver.FindElementByName("G-General Message               ");
        }

        public WindowsElement getTypePhysicianReferral()
        {
            return driver.FindElementByName("E-Physician Referral            ");
        }

        public WindowsElement getTriage()
        {
            return driver.FindElementByName("K-Triage Intake                 ");
        }

        public WindowsElement getServiceReferral()
        {
            return driver.FindElementByName("O-Service Referral              ");
        }
    }
}
