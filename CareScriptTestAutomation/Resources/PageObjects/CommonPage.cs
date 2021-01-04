using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareScriptTestAutomation.Resources.PageObjects
{
    class CommonPage
    {
        WindowsDriver<WindowsElement> driver;
        public CommonPage(WindowsDriver<WindowsElement> driver)
        {
            this.driver = driver;
        }

        public WindowsElement getYesBtn()
        {
            return driver.FindElementByName("Yes");
        }

        public WindowsElement getOKBtn()
        {
            return driver.FindElementByName("OK");
        }
    }
}
