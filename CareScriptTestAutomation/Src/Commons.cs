using AventStack.ExtentReports;
using CareScriptTestAutomation.Resources.PageObjects;
using Newtonsoft.Json;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CareScriptTestAutomation.Src
{
    class Commons
    {
        private WindowsDriver<WindowsElement> driver;
        private CommonPage commonPage { get; set; }

        public ExtentTest test { get; set; }

        public Commons(WindowsDriver<WindowsElement> driver, ExtentTest test)
        {
            this.driver = driver;
 
            this.commonPage = new CommonPage(driver);
            this.test = test;
        }

        
        public T GetJsonData<T>(string path)
        {
            JsonSerializer serializer = new JsonSerializer();
            T data = (T)serializer.Deserialize(File.OpenText(path), typeof(T));
            return data;
        }

        public void implicitWait(int seconds = 10)
        {
            this.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(seconds);
        }

        public DateTime getCurrentEasternTime()
        {
            var timeUtc = new DateTime();

            TimeZoneInfo easternZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            DateTime easternTime = TimeZoneInfo.ConvertTimeFromUtc(timeUtc, easternZone);

            return easternTime;
        }
        public DateTime getCurrentTime()
        {
            DateTime localTimeNow = DateTime.Today;
            return localTimeNow;
        }

        public void clickYes()
        {
            try
            {
                this.commonPage.getYesBtn().Click();
                this.test.Pass("Successfully clicked Yes from pop up");
            }
            catch (Exception ex)
            {
                this.test.Warning("Yes button not existing : " + ex.ToString());
            }
        }

        public void clickOK()
        {
            try
            {
                this.commonPage.getOKBtn().Click();
                this.test.Pass("Successfully clicked OK from pop up");
            }
            catch (Exception ex)
            {
                this.test.Warning("OK button not existing : " + ex.ToString());
            }
        }
        public Boolean isNotSameTime(DateTime lastEasternTime, String lastRecordedTime)
        {
            DateTime _lastRecordedTime = Convert.ToDateTime(lastRecordedTime);
            int result = DateTime.Compare(lastEasternTime, _lastRecordedTime);

            if (result < 0)
            {
                this.test.Pass("Record has been added");
                return true;
                
            }
            else
            {
                this.test.Fail("There was no error added");
                return false;
            }
        }

        public bool isSuccessfulClickAndCatch(WindowsElement element)
        {
            try
            {
                element.Click();
                return true;
            }
            catch (Exception ex)
            { return false; }
        }
        public void dragElementTo(WindowsElement element, int x, int y)
        {
            Actions action = new Actions(this.driver);
            action.ClickAndHold(element).MoveByOffset(x, y).Release().Perform();
        }
        public Boolean assertEqualString(string expected, string actual)
        {
            try
            {
                Assert.Equal(expected, actual);
                return true;
            }
            catch (Exception ex) 
            {
                return false;
            }
        }
    }
}
