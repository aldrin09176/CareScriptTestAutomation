using AventStack.ExtentReports;
using CareScriptTestAutomation.Resources.PageObjects;
using CareScriptTestAutomation.Src.ChildWindows;
using CareScriptTestAutomation.Src.StatusPanel.DataObjects;
using CareScriptTestAutomation.Src.TransactionWindow.DataObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Xunit;

namespace CareScriptTestAutomation.Src.StatusPanel
{
    class TransactionWindowPageSteps
    {
        WindowsDriver<WindowsElement> driver;
        string dataObjectPath = @"..\\..\\Resources\\GlobalData.json";
        TransactionWindowPage transactionWindowPage { get; set; }
        Commons commons { get; set; }
        CommonPage commonPage { get; set; }

        TelephonyWindowPage telephonyWindowPage { get; set; }
        ExtentTest test { get; set; }
        ChildWindowsPageSteps childWindowsPageSteps { get; set; }
        ChildWindowsPage childWindowsPage { get; set; }


        public TransactionWindowPageSteps(WindowsDriver<WindowsElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.transactionWindowPage = new TransactionWindowPage(this.driver);
            this.commons = new Commons(this.driver, test);
            this.commonPage = new CommonPage(this.driver);
            this.childWindowsPageSteps = new ChildWindowsPageSteps(this.driver, test);
            this.childWindowsPage = new ChildWindowsPage(this.driver);
            this.telephonyWindowPage = new TelephonyWindowPage(this.driver);
            this.test = test;
        }

        public void enterServices()
        {

            try
            {
                var data = this.commons.GetJsonData<Request>(this.dataObjectPath);
                this.transactionWindowPage.getExternalServices().SendKeys(data.AtClass);
                this.test.Pass("Succesfully entered Services");
            }
            catch (Exception ex)
            {
                this.test.Fail("Error with : " + ex.ToString());
            }


        }

        public void selectReason()
        {
            try
            {
                var data = this.commons.GetJsonData<Request>(dataObjectPath);
                this.transactionWindowPage.getReason().SendKeys(data.Dir);
                this.test.Pass("Successfully selected Reason");
            }
            catch (Exception ex)
            {
                this.test.Fail("Error with : " + ex.ToString());
            }
        }

        public void selectClassification()
        {
            try
            {

                var data = this.commons.GetJsonData<Request>(dataObjectPath);
                this.transactionWindowPage.getBuckets().SendKeys(data.Clas);
                this.test.Pass("Successfully selected Classification");

            }
            catch (Exception ex)
            {
                this.test.Fail("Error with : " + ex.ToString());
            }

        }

        public void clickeEndCall()
        {
            try
            {

                this.transactionWindowPage.getEndBtn().Click();
                this.test.Pass("Successfully sent/ended call");

            }
            catch (Exception ex)
            {
                this.test.Fail("Error with : " + ex.ToString());
            }
            
        }

        public void clickF12EndCall()
        {
            try
            {
                this.transactionWindowPage.getEndCallBtn().Click();
                this.test.Pass("Successfully clicked F12 End Call");
                 
            }
            catch (Exception ex)
            {
                this.test.Fail("Error with : " + ex.ToString());
            }
        }

        public void clickCancel()
        {
            try
            {
                this.transactionWindowPage.getCancelBtn().Click();
                this.test.Pass("Successfully clicked Cancel");


            }
            catch (Exception ex)
            {
                this.test.Fail("Error with : " + ex.ToString());
            }
        }

        public void clickFirstRecord()
        {
            try
            {

                this.transactionWindowPage.getFirstContactSearchRow().Click();
                this.test.Pass("Successfully clicked first record");

            }
            catch (Exception ex)
            {
                this.test.Fail("Error with : " + ex.ToString());
            }
        }

        public void clickReturn()
        {
            try
            {
                this.transactionWindowPage.getReturnBtn().Click();
                this.test.Pass("Successfully clicked Return");
            }
            catch (Exception ex)
            {
                this.test.Fail("Error with : " + ex.ToString());
            }
        }
        public void populateFields()
        {
            try
            {
                var data = this.commons.GetJsonData<Request>(dataObjectPath);

                this.transactionWindowPage.getCallerFirstTxtBox().SendKeys(data.CallerFirst);
                this.transactionWindowPage.getCallerLastTxtBox().SendKeys(data.Last);
                this.transactionWindowPage.getSameChkBox().Click();
                this.test.Pass("Successfully filled up fields");
            }
            catch (Exception ex)
            {
                this.test.Fail("Error with : " + ex.ToString());
            }
        }

        public void populateMoreFields()
        {
            try
            {
                var data = this.commons.GetJsonData<Request>(dataObjectPath);

                this.transactionWindowPage.getPatientStatusCmbBox().SendKeys(data.PatientStatus);
                this.transactionWindowPage.getProviderCmbBox().SendKeys(data.Provider);
                this.transactionWindowPage.getMessageTypeCmbBox().SendKeys(data.MessageType);
                this.transactionWindowPage.getCallBackNoTxtBox().SendKeys(data.CallBackNo);

                this.transactionWindowPage.getMessageTxtBox().Clear();
                this.transactionWindowPage.getMessageTxtBox().SendKeys(data.Message);
                this.test.Pass("Successfully filled up fields");
            }
            catch (Exception ex)
            {
                this.test.Fail("Error with : " + ex.ToString());
            }
            
        }

        public void clickSendMessageBtn()
        {
            try
            {

                this.transactionWindowPage.getSendMessageBtn().Click();
                this.test.Pass("Successfully clicked Send Message");

            }
            catch (Exception ex)
            {
                this.test.Fail("Error with : " + ex.ToString());
            }
        }

        public void selectHeardSource()
        {
            var data = this.commons.GetJsonData<Request>(dataObjectPath);
            this.transactionWindowPage.getHeardSourceCmbBox().SendKeys(data.HeardSource);
        }
        public void clickSendBtn()
        {
            try
            {
                this.transactionWindowPage.getSendBtn().Click();

                try
                {
                    this.commons.clickYes();
                    this.test.Pass("Successfully clicked Send button");
                }

                catch (Exception ex)
                { }

            }
            catch (Exception ex)
            {
                this.test.Fail("Error with : " + ex.ToString());
            }

            
        }

        public void populateReferralFields()
        {
            try
            {
                var data = this.commons.GetJsonData<Request>(dataObjectPath);

                this.transactionWindowPage.getSpecialtyCmbBox().SendKeys(data.Specialty);
                this.transactionWindowPage.getLanguageCmbBox().SendKeys(data.Language);
                this.transactionWindowPage.getSearchBtn().Click();
                this.transactionWindowPage.getFirstDoctor().Click();
                this.transactionWindowPage.getWrapUpTab().Click();
                this.transactionWindowPage.getReferralReasonCmbBox().SendKeys(data.ReferralReason);
                this.transactionWindowPage.getReferralNoteTxtBox().SendKeys(data.AgentNote);
                this.transactionWindowPage.getFirstDoctor().Click();
                this.telephonyWindowPage.getRejectAllBtn().Click();
                this.test.Pass("Successfully filled up referral fields");
            }
            catch (Exception ex)
            {
                this.test.Fail("Error with : " + ex.ToString());
            }
            

        }
        public void clickEndReferralBtn()
        {
            try
            {
                this.transactionWindowPage.getEndReferralBtn().Click();
                this.test.Pass("Successfully clicked End Referral");

            }
            catch (Exception ex)
            {
                this.test.Fail("Error with : " + ex.ToString());
            }
        }
        public void clickSentByAgent()
        {
            try
            {
                this.transactionWindowPage.getSentByAgentBtn().Click();
                this.test.Pass("Successfully clicked Sent By Agent");
            }
            catch (Exception ex)
            {
                this.test.Fail("Error with : " + ex.ToString());
            }
        }
        public string getFirstRecordFromSentByAgent()
        {
            return this.transactionWindowPage.getFirstRowFromSentByAgent().Text;
        }

        public void inputInitialTriageFormDetails()
        {
            try
            {
                var data = this.commons.GetJsonData<Request>(dataObjectPath);
                int ctr = 1;
                this.transactionWindowPage.getTriageCallerFirstTxt().SendKeys(data.CallerFirst);
                this.transactionWindowPage.getTriageCallerLastTxt().SendKeys(data.Last);
                this.transactionWindowPage.getTriageSameChckBox().Click();
                this.transactionWindowPage.getRecordTriage(ctr).Click();
                this.transactionWindowPage.getReturnButtonTriage().Click();

                while (this.transactionWindowPage.getAlreadyQueuedMessage() > 0) 
                {
                    ctr = ctr + 10;

                    if (this.telephonyWindowPage.getRejectBtnCt() > 0 ) {
                        this.telephonyWindowPage.getRejectBtn().Click();
                    }

                    if (this.telephonyWindowPage.getRejectAllBtnCt() > 0) {
                        this.telephonyWindowPage.getRejectAllBtn().Click();
                    }
                    this.commons.clickOK();
                    this.transactionWindowPage.getTriageSameChckBox().Click();
                    this.transactionWindowPage.getRecordTriage(ctr).Click();
                    this.transactionWindowPage.getReturnButtonTriage().Click();
                }
                this.test.Pass("Successfully inputted initial triage patient details");
            }
            catch (Exception ex)
            {
                this.test.Fail("Error with : " + ex.ToString());
            }
        }


        public void inputFinishinDetailsTriage() 
        {
            try
            {
                var data = this.commons.GetJsonData<Request>(dataObjectPath);
                this.transactionWindowPage.getCallbackNoTriage().Clear();
                this.transactionWindowPage.getCallbackNoTriage().SendKeys(data.CallbackNoTriage);
                this.transactionWindowPage.getPresentingProblem().SendKeys(data.PresentingProblem);
                this.transactionWindowPage.getAddToQueueBtn().Click();
                this.test.Pass("Successfully entered all contact details");
            }
            catch (Exception ex)
            {
                this.test.Fail("Error with : " + ex.ToString());
            }
        }
        
        public void clickClinicalCalls()
        {
            try
            {
                this.transactionWindowPage.getClinicalCallsBtn().Click();
                this.test.Pass("Successfully clicked Clinical Calls button");
            }
            catch (Exception ex)
            {
                this.test.Fail("Error with : " + ex.ToString());
            }
        }

        public void selectMSRCreatedEncounter()
        {
            try
            {
                this.transactionWindowPage.getTriageGridTimeHeader().Click();

                ////this.commons.dragElementTo(this.transactionWindowPage.getTriageGridScrollBar(), 0, 80);

                this.transactionWindowPage.getTriageLastRow().Click();
                this.test.Pass("Successfully clicked the last row");
            }
            catch (Exception ex)
            {
                this.test.Fail("Error with : " + ex.ToString());
            }
        }

        public void clickTakeCall()
        {
            try
            {
                this.transactionWindowPage.getTakeCallBtn().Click();
                try
                {
                    this.commons.clickYes();
                }
                catch (Exception ex) 
                {
                }
                this.test.Pass("Successfully clicked Take Call");
            }
            catch (Exception ex)
            {
                this.test.Fail("Error with : " + ex.ToString());
            }
        }
        public void clickStartTriage()
        {
            try
            {
                this.transactionWindowPage.getStartTriageBtn().Click();
                this.test.Pass("Successfully clicked Start Triage");
            }
            catch (Exception ex)
            {
                this.test.Fail("Error with : " + ex.ToString());
            }
        }

        public void clickComplaintGuidelines()
        {
            try
            {
                this.transactionWindowPage.getComplaintGuidelines().Click();
                this.test.Pass("Successfully clicked Complaint Guidelines");
            }
            catch (Exception ex) 
            {
                this.test.Fail("Error with : " + ex.ToString());
            }
        }
        public void enterChiefComplaint()
        {
            try
            {

                var data = this.commons.GetJsonData<Request>(dataObjectPath);
                this.transactionWindowPage.getChiefComplaintTxtBox().Clear();
                this.transactionWindowPage.getChiefComplaintTxtBox().SendKeys(data.PresentingProblem);
                this.test.Pass("Successfully entered Chief Complaint");

            }
            catch (Exception ex)
            {
                this.test.Fail("Error with : " + ex.ToString());
            }
        }

        public void enterBleedingSearchAndGo()
        {
            try
            {

                var data = this.commons.GetJsonData<Request>(dataObjectPath);
                this.transactionWindowPage.getSearchBar().Click();
                this.transactionWindowPage.getSearchBar().Clear();
                this.transactionWindowPage.getSearchBar().SendKeys(data.Bleeding);
                this.transactionWindowPage.getTriageSearchBtn().Click();
                this.transactionWindowPage.itemGoBtn().Click();
                this.test.Pass("Successfully gone through search");

            }
            catch (Exception ex)
            {
                this.test.Fail("Error with : " + ex.ToString());
            }
        }

        public void enterAssessmentValue()
        {
            try
            {

                var data = this.commons.GetJsonData<Request>(dataObjectPath);
                this.transactionWindowPage.getAssessmentPanelBox1().Clear();
                this.transactionWindowPage.getAssessmentPanelBox1().SendKeys(data.Assessment1);
                this.transactionWindowPage.getAssessmentPanelBox2().Clear();
                this.transactionWindowPage.getAssessmentPanelBox2().SendKeys(data.Assessment2);

                this.test.Pass("Successfully entered assessment");

            }
            catch (Exception ex)
            {
                this.test.Fail("Error with : " + ex.ToString());
            }

        }

        public void clickTriageGoBtn()
        {
            try
            {

                this.transactionWindowPage.getTriageGoBtn().Click();
                this.test.Pass("Successfully clicked Triage GO");

            }
            catch (Exception ex)
            {
                this.test.Fail("Error with : " + ex.ToString());
            }

        }

        public void fillServiceReferralForm()
        {
            try
            {

                var data = this.commons.GetJsonData<Request>(dataObjectPath);
                this.transactionWindowPage.getCallerFirstTxtBox().SendKeys(data.CallerFirst);
                this.transactionWindowPage.getCallerLastTxtBox().SendKeys(data.CallerLast);
                this.transactionWindowPage.getSameChkBox().Click();
                this.transactionWindowPage.getFirstRowServiceReferral().Click();
                this.transactionWindowPage.getReturnBtn().Click();
                this.transactionWindowPage.getBServiceTypeCmbBox().SendKeys(data.BServiceType);
                this.transactionWindowPage.getSearchBtn().Click();
                this.transactionWindowPage.getFirstRowServiceReferral().Click();
                this.transactionWindowPage.getWrapUpTab().Click();
                this.transactionWindowPage.getSource().SendKeys(data.Source);
                this.transactionWindowPage.getServiceReferralReason().SendKeys(data.ServiceReferralReason);
                this.transactionWindowPage.getAgentNote().SendKeys(data.ServiceReferalAgentNote);
                this.transactionWindowPage.getEndServiceReferralBtn().Click();
                this.test.Pass("Successfully entered Service Referral data");
            }
            catch (Exception ex)
            {
                this.test.Fail("Error with : " + ex.ToString());
            }

        }

        public void fillNewBabyForm()
        {
            try
            {

                var data = this.commons.GetJsonData<Request>(dataObjectPath);

                this.transactionWindowPage.getMotherTxtBox().SendKeys(data.Mother);
                this.transactionWindowPage.getNewBornTxtBox().SendKeys(data.Newborn);
                this.transactionWindowPage.getProviderCmbBox().SendKeys(data.ProviderNewBaby);
                this.transactionWindowPage.getCallbackNewBaby().SendKeys(data.CallbackNoNewBaby);

                this.transactionWindowPage.getBabyHealthOpt().Click();
                this.transactionWindowPage.getBabyGenderOpt().Click();
                this.transactionWindowPage.getBabyFeedingOpt().Click();

                this.transactionWindowPage.getHospitalCmbBox().SendKeys(data.Hospital);
                this.transactionWindowPage.getConditionTxtBox().SendKeys(data.Condition);
                this.transactionWindowPage.getRmWardTxtBox().SendKeys(data.RmWard);
                this.transactionWindowPage.getDateTxtBox().SendKeys(data.Date);
                this.transactionWindowPage.getTimeTxtBox().SendKeys(data.Time);

                this.transactionWindowPage.getWeightTxtBox().SendKeys(data.Weight);
                this.transactionWindowPage.getWeightUnitOpt().Click();

                this.transactionWindowPage.getCommentTxtBox().SendKeys(data.Comment);

                this.transactionWindowPage.getEndNewBabyBtn().Click();
                this.transactionWindowPage.getOverrideBtn().Click();

                this.transactionWindowPage.getNewBabyProvider().SendKeys(data.ProviderNewBaby2);

                this.transactionWindowPage.getEndNewBabyBtn().Click();
                this.commons.clickYes();

                this.test.Pass("Successfully entered New Baby data");
            }
            catch (Exception ex)
            {
                this.test.Fail("Error with : " + ex.ToString());
            }

        }

        public void verifyAddedNewBabyReport()
        {
            try
            {

                this.clickSentByAgent();
                string expected = "New Baby Report";
                string actual = this.transactionWindowPage.getFirstBabyRecord().Text;
                var result = this.commons.assertEqualString(expected, actual.Trim());

                try
                {
                    Assert.True(result);
                    this.test.Pass("Data is verified existent in the records");
               
                }
                catch (Exception ex)
                {
                    this.test.Fail("Data is not existing in the records");
                }
                this.transactionWindowPage.getReturnBtn().Click();

            }
            catch (Exception ex)
            {
                this.test.Fail("Error with : " + ex.ToString());
            }
        }
  
    }
}
