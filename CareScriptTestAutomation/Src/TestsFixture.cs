using AventStack.ExtentReports;
using CareScriptTestAutomation.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareScriptTestAutomation.Src
{
    public class TestsFixture : IDisposable
    {
        public ReportsHelper reportsHelper { get; set; }
        public ExtentTest test { get; set; }
        public TestsFixture()
        {
            reportsHelper = new ReportsHelper("Workflow");

        }
        public void Dispose()
        {
            reportsHelper.extent.Flush();
        }
    }
}
