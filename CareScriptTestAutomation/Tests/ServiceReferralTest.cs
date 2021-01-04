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
    public class ServiceReferralTest : Src.Init
    {
        ReportsHelper reportsHelper { get; set; }
        ExtentTest test { get; set; }
        [Fact]
        public void assertAddedReferral()
        {
            reportsHelper = new ReportsHelper("ServiceReferral");
            test = reportsHelper.extent.CreateTest("Service Referral Test");
            this.extent = reportsHelper.extent;

            LoginPageSteps loginPageSteps = new LoginPageSteps(driver, test);
            StatusPanelPageSteps statusPanelPageSteps = new StatusPanelPageSteps(driver, test);
            TelephonyWindowPageSteps telephonyWindowPageSteps = new TelephonyWindowPageSteps(driver, test);
            TransactionWindowPageSteps transactionWindowPageSteps = new TransactionWindowPageSteps(driver, test);
            FunctionMenuPageSteps functionMenuPageSteps = new FunctionMenuPageSteps(driver, test);
            ChildWindowsPageSteps childWindowPageSteps = new ChildWindowsPageSteps(driver, test);

            Commons commons = new Commons(driver, this.test);

            var beforeRecordedTime = commons.getCurrentEasternTime();

            loginPageSteps.loginUsingSeatNo();
            statusPanelPageSteps.selectAdminWork();
            statusPanelPageSteps.selectFacility();
            telephonyWindowPageSteps.telephonyClickRejectAll();
            transactionWindowPageSteps.clickCancel();
            commons.clickYes();
            statusPanelPageSteps.selectCategoryServices();
            statusPanelPageSteps.selectTypeServiceReferral();
            transactionWindowPageSteps.fillServiceReferralForm();
            transactionWindowPageSteps.clickF12EndCall();

            functionMenuPageSteps.selectTransResearch();

            childWindowPageSteps.verifyAddedRecordsInServiceReferral();

            statusPanelPageSteps.logOut();
        }
    }
}
