using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareScriptTestAutomation.Resources.PageObjects
{
    class LoginPage
    {
        WindowsDriver<WindowsElement> driver;
        public LoginPage(WindowsDriver<WindowsElement> driver)
        {
            this.driver = driver;
        }

        public WindowsElement getSeatComboBox()
        {
            return driver.FindElementByAccessibilityId("dcbSeats");
        }

        public WindowsElement getInformationOkButton()
        {
            return driver.FindElementByAccessibilityId("cmdInfoOK");
        }
    }
}
