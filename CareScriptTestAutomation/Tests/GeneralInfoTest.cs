using AventStack.ExtentReports;
using CareScriptTestAutomation.Reports;
using CareScriptTestAutomation.Src;
using CareScriptTestAutomation.Src.ChildWindows;
using CareScriptTestAutomation.Src.FunctionMenu;
using CareScriptTestAutomation.Src.GeneralInfo;
using CareScriptTestAutomation.Src.StatusPanel;
using CareScriptTestAutomation.Src.TelephonyWindow;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Xunit;

namespace CareScriptTestAutomation.Test
{
    [Collection("Sequential")]
    public class GeneralInfoTest : Src.Init
    { 
        ExtentTest test { get; set; }

        [Fact]
        public void asserAddedNewInfo() 
        {
            test = ReportsHelper.extent.CreateTest("General Info Test");
            this.extent = ReportsHelper.extent;

            LoginPageSteps loginPageSteps = new LoginPageSteps(driver, test);
            StatusPanelPageSteps statusPanelPageSteps = new StatusPanelPageSteps(driver, test);
            TelephonyWindowPageSteps telephonyWindowPageSteps = new TelephonyWindowPageSteps(driver, test);
            TransactionWindowPageSteps transactionWindowPageSteps = new TransactionWindowPageSteps(driver, test);
            FunctionMenuPageSteps functionMenuPageSteps = new FunctionMenuPageSteps(driver, test);
            ChildWindowsPageSteps childWindowPageSteps = new ChildWindowsPageSteps(driver, test);

            Commons commons = new Commons(driver, this.test);

            loginPageSteps.loginUsingSeatNo();
            statusPanelPageSteps.selectAdminWork();
            statusPanelPageSteps.selectFacility();
            telephonyWindowPageSteps.telephonyClickRejectAll();
            transactionWindowPageSteps.enterServices();
            transactionWindowPageSteps.selectReason();
            transactionWindowPageSteps.selectClassification();
            transactionWindowPageSteps.clickeEndCall();
            transactionWindowPageSteps.clickF12EndCall();
            functionMenuPageSteps.selectTransResearch();
            childWindowPageSteps.validateAddedRecords("General Info");
            statusPanelPageSteps.logOut();

        }
    }
}
