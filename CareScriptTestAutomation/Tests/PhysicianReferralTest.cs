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
    public class PhysicianReferral : Src.Init
    {
        ReportsHelper reportsHelper { get; set; }
        ExtentTest test { get; set; }
        [Fact]
        public void assertAddedReferral()
        {
            reportsHelper = new ReportsHelper("PhysicianReferral");
            test = reportsHelper.extent.CreateTest("Physician Referral Test");
            this.extent = reportsHelper.extent;

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
            statusPanelPageSteps.selectCategoryServices();
            statusPanelPageSteps.selectTypePhysicianReferral();
            transactionWindowPageSteps.selectHeardSource();
            transactionWindowPageSteps.populateFields();
            transactionWindowPageSteps.clickFirstRecord();
            transactionWindowPageSteps.clickReturn();
            transactionWindowPageSteps.populateReferralFields();
            transactionWindowPageSteps.clickEndReferralBtn();
            transactionWindowPageSteps.clickSendBtn();
            transactionWindowPageSteps.clickF12EndCall();
            functionMenuPageSteps.selectTransResearch();
            childWindowPageSteps.validateAddedRecords("Physician Referral");
            statusPanelPageSteps.logOut(); 
        }
    }
}
