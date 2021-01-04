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
    public class ReportsHelper
    {
        public ExtentReports extent { get; set; }
        public ExtentHtmlReporter reporter { get; set; }
        public ExtentTest test { get; set; }

        public DateTime currentTime;

        [Fact]
        public void createExtentHtml() 
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");
            var appendTime = DateTime.Now.ToString("yyyy'-'MM'-'dd'T'H'.'mm'.'ss");
            MessageBox.Show(dir + "\\TestExecutionReports" + "\\" + Path.Combine("GeneralInfo", appendTime) + ".html");
            
        }
        public ReportsHelper(string testName) 
        {

            DateTime timeStamp = DateTime.Now;
            string timeNow = timeStamp.ToString("yyyyMMddHHmmss");

            this.extent =  new ExtentReports();
            var dir = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");
            DirectoryInfo di = Directory.CreateDirectory(dir + "\\TestExecutionReports\\" +
                "");
            var htmlReporter = new ExtentHtmlReporter(dir + "\\TestExecutionReports" + "\\" + testName + " " + timeNow + ".html");
            this.extent.AddSystemInfo("Environment", "Carescript Test Automation");
            this.extent.AddSystemInfo("User Name", "Aldrin Sy");
            this.extent.AttachReporter(htmlReporter);
            htmlReporter.LoadConfig(dir + "\\extent-config.xml");
            
        }
    }
}
