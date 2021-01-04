using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareScriptTestAutomation.Resources.PageObjects
{
    class TelephonyWindowPage
    {
        WindowsDriver<WindowsElement> driver;
        public TelephonyWindowPage(WindowsDriver<WindowsElement> driver)
        {
            this.driver = driver;
        }

        public WindowsElement getRejectAllBtn()
        {
            return driver.FindElementByAccessibilityId("btRejectAll");
        }

        public int getRejectAllBtnCt()
        {
            return driver.FindElementsByAccessibilityId("btRejectAll").Count();
        }
        public WindowsElement getRejectBtn()
        {
            return driver.FindElementByAccessibilityId("btReject");
        }

        public int getRejectBtnCt()
        {
            return driver.FindElementsByAccessibilityId("btReject").Count();
        }
    }
}
