using AventStack.ExtentReports;
using CareScriptTestAutomation.Test;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CareScriptTestAutomation.Src
{
    public class Init : IDisposable
    {
        // driver initiation starts here

        public WindowsDriver<WindowsElement> driver;
        public ExtentReports extent { get; set; }

        public Init()
        {
            // Potential snippet for starting the driver here : 
            // StartDriver();
            try
            {
               
                AppiumOptions desiredCapabilities = new AppiumOptions();
                desiredCapabilities.AddAdditionalCapability("app", @"C:\Program Files\CareScripts\Acceptance\Current\CareScripts.exe");
                desiredCapabilities.AddAdditionalCapability("CS-DevTest-A01", "WindowsPC");
                driver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), desiredCapabilities);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                driver.Manage().Window.Maximize();


            }
            catch (Exception ex) {
                Console.WriteLine("App not started. With exception : " + ex.ToString());
                return;
            }
        }

        public void Dispose()
        {
            this.extent.Flush();
        }
    }
}
