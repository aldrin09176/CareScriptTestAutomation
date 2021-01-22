using AventStack.ExtentReports;
using CareScriptTestAutomation.Reports;
using CareScriptTestAutomation.Src;
using CareScriptTestAutomation.Src.ChildWindows;
using CareScriptTestAutomation.Src.FunctionMenu;
using CareScriptTestAutomation.Src.GeneralInfo;
using CareScriptTestAutomation.Src.StatusPanel;
using CareScriptTestAutomation.Src.TelephonyWindow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CareScriptTestAutomation.Tests
{
    [Collection("Sequential")]
    public class TriageWorkflowTest : Src.Init
    {
        ExtentTest test { get; set; }
        [Fact]
        public void asMSR()
        {
            var testName = "Triage Workflow as MSR";
            test = ReportsHelper.extent.CreateTest(testName);
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
            transactionWindowPageSteps.clickCancel();
            commons.clickYes();
            statusPanelPageSteps.selectTypeTriage();
            transactionWindowPageSteps.inputInitialTriageFormDetails();
            commons.clickOK();
            transactionWindowPageSteps.inputFinishinDetailsTriage();
            telephonyWindowPageSteps.telephonyClickRejectAll();
            transactionWindowPageSteps.clickF12EndCall();
            statusPanelPageSteps.logOut();
        }
        [Fact]
        public void asNurse()
        {
            var testName = "Triage Workflow as MSR";
            test = ReportsHelper.extent.CreateTest(testName);
            this.extent = ReportsHelper.extent;

            LoginPageSteps loginPageSteps = new LoginPageSteps(driver, test);
            StatusPanelPageSteps statusPanelPageSteps = new StatusPanelPageSteps(driver, test);
            TelephonyWindowPageSteps telephonyWindowPageSteps = new TelephonyWindowPageSteps(driver, test);
            TransactionWindowPageSteps transactionWindowPageSteps = new TransactionWindowPageSteps(driver, test);
            FunctionMenuPageSteps functionMenuPageSteps = new FunctionMenuPageSteps(driver, test);
            ChildWindowsPageSteps childWindowPageSteps = new ChildWindowsPageSteps(driver, test);

            loginPageSteps.loginUsingSeatNo();
            statusPanelPageSteps.selectAdminWork();
            functionMenuPageSteps.selectMonitorQueue();
            transactionWindowPageSteps.clickClinicalCalls();
            transactionWindowPageSteps.selectMSRCreatedEncounter();
            transactionWindowPageSteps.clickTakeCall();
            transactionWindowPageSteps.clickStartTriage();
            transactionWindowPageSteps.clickComplaintGuidelines();
            transactionWindowPageSteps.enterChiefComplaint();
            transactionWindowPageSteps.enterBleedingSearchAndGo();
            transactionWindowPageSteps.enterAssessmentValue();
            transactionWindowPageSteps.clickTriageGoBtn();
        }
    }
}
