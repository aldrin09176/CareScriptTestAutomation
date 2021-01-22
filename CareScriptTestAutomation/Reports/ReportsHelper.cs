using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Xunit;

namespace CareScriptTestAutomation.Reports
{
    public static class ReportsHelper
    {
        public static ExtentReports extent { get; set; }
        public static ExtentHtmlReporter reporter { get; set; }
        public static ExtentTest test { get; set; }

        public static DateTime currentTime;
        public static String testName {get;set;}

        public static void createExtentHtml() 
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");
            var appendTime = DateTime.Now.ToString("yyyy'-'MM'-'dd'T'H'.'mm'.'ss");
            MessageBox.Show(dir + "\\TestExecutionReports" + "\\" + Path.Combine("GeneralInfo", appendTime) + ".html");
            
        }
        static ReportsHelper() 
        {

            DateTime timeStamp = DateTime.Now;
            string timeNow = timeStamp.ToString("yyyyMMddHHmmss");

            extent =  new ExtentReports();
            var dir = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");
            DirectoryInfo di = Directory.CreateDirectory(dir + "\\TestExecutionReports\\" +
                "");
            var htmlReporter = new ExtentHtmlReporter(dir + "\\TestExecutionReports" + "\\" + testName + " " + timeNow + ".html");
            extent.AddSystemInfo("Environment", "Carescript Test Automation");
            extent.AddSystemInfo("User Name", "Aldrin Sy");
            extent.AttachReporter(htmlReporter);
            htmlReporter.LoadConfig(dir + "\\extent-config.xml");
            
        }
    }
}
