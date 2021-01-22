using AventStack.ExtentReports;
using CareScriptTestAutomation.Reports;
using CareScriptTestAutomation.Test;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Xunit;

namespace CareScriptTestAutomation.Src
{
    public class Init : IDisposable
    {
        // driver initiation starts here

        public WindowsDriver<WindowsElement> driver;
        public ExtentReports extent { get; set; }
        ExtentTest test { get; set; }

        public Init()
        {

            try
            {
                var winapp = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "\\winappdriver") + "\\WinAppDriver.exe";
                

                System.Diagnostics.Process.Start(winapp);     

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

            Process[] processes = Process.GetProcessesByName("WinAppDriver");
            foreach (Process process in processes)
            {
                process.Kill();
            }
        }
    }
}
