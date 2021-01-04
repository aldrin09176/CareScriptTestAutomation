using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareScriptTestAutomation.Resources.PageObjects
{
    class FunctionMenuPage
    {
        WindowsDriver<WindowsElement> driver;
        public FunctionMenuPage(WindowsDriver<WindowsElement> driver)
        {
            this.driver = driver;
        }

        public WindowsElement getAdministrativeMenu()
        {
            return driver.FindElementByXPath("//MenuBar[starts-with(@AutomationId,\"MainMenu\")]/MenuItem[@Name=\"Administrative\"]");
        }

        public void selectTransResearch()
        {
            driver.FindElementByName("Trans Research").Click();


        }

        public void selectOutputQueue()
        {
            driver.FindElementByName("Output Queue").Click();

        }

        public void selectMonitorQueue()
        {
            driver.FindElementByName("Monitor Queue").Click();
        }
    }
}
