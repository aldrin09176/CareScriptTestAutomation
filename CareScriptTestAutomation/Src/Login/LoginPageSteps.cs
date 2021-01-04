using AventStack.ExtentReports;
using CareScriptTestAutomation.Resources;
using CareScriptTestAutomation.Resources.PageObjects;
using CareScriptTestAutomation.Test;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareScriptTestAutomation.Src.GeneralInfo 
{
    class LoginPageSteps
    {
        WindowsDriver<WindowsElement> driver;
        string dataObjectPath = @"..\\..\\Secrets\\accounts.json";
        Commons commons { get; set; }
        LoginPage loginPage { get; set; }
        ExtentTest test { get; set; }
        
        public LoginPageSteps(WindowsDriver<WindowsElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.commons = new Commons(driver, test);
            this.loginPage = new LoginPage(driver);
            this.test = test;
        }

        public void loginUsingSeatNo()
        {
            try
            {
                var data = this.commons.GetJsonData<Data>(dataObjectPath);
                this.loginPage.getSeatComboBox().SendKeys(data.SeatNo);
                this.loginPage.getInformationOkButton().Click();
                try
                {
                    this.driver.FindElementByName("Yes").Click();
                    
                }
                catch (Exception ex)
                {
                    
                }
                this.test.Pass("Successful Login using Seat No : " + data.SeatNo);

            }
            catch (Exception ex)
            {
                test.Fail("Error with : " + ex.ToString());
            }
        }
    }
}
