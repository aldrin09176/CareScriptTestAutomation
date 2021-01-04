using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CareScriptTestAutomation.Resources.PageObjects
{
    class TransactionWindowPage
    {
        WindowsDriver<WindowsElement> driver;
        public TransactionWindowPage(WindowsDriver<WindowsElement> driver)
        {
            this.driver = driver;
        }
        public WindowsElement getExternalServices()
        {
            return driver.FindElementByAccessibilityId("dcbExternalServices");
        }
        public WindowsElement getReason()
        {
            return driver.FindElementByAccessibilityId("dcbGenInfoReason");
        }

        public WindowsElement getBuckets()
        {
            return driver.FindElementByAccessibilityId("dcbBuckets");
        }
        
        public WindowsElement getEndBtn()
        {
            return driver.FindElementByAccessibilityId("bteND");
        }

        public WindowsElement getEndCallBtn()
        {
            return driver.FindElementByAccessibilityId("btEndCall");
        }   

        public WindowsElement getCancelBtn()
        {
            return driver.FindElementByAccessibilityId("btCancel");
        }

        public WindowsElement getCallerFirstTxtBox()
        {
            return driver.FindElementByAccessibilityId("txtCallerFirst");
        }
        public WindowsElement getCallerLastTxtBox()
        {
            return driver.FindElementByAccessibilityId("txtCallerLast");
        }

        public WindowsElement getSameChkBox()
        {
            return driver.FindElementByName("Same");
        }
        public WindowsElement getHeardSourceCmbBox()
        {
            return driver.FindElementByAccessibilityId("_dcbHeardSource_1");
        }

        public WindowsElement getFirstContactSearchRow()
        {
            return driver.FindElementByName("LastName Row 0, Not sorted.");
        }

        public WindowsElement getReturnBtn()
        {
            return driver.FindElementByName("Return");
        }
        public WindowsElement getPatientStatusCmbBox()
        {
            return driver.FindElementByAccessibilityId("dcbCodesCallSource");
        }

        public WindowsElement getProviderCmbBox()
        {
            return driver.FindElementByAccessibilityId("dcbProvider");

        }
        public WindowsElement getMessageTypeCmbBox()
        {
            return driver.FindElementByAccessibilityId("dcbCodesMessageTypes");
        }

        public WindowsElement getCallBackNoTxtBox()
        {
            return driver.FindElementByAccessibilityId("mskCallBackPhone");
        }
        public WindowsElement getMessageTxtBox()
        {
            return driver.FindElementByClassName("TextBox");
        }

        public WindowsElement getSendMessageBtn()
        {
            return driver.FindElementByAccessibilityId("btEnd");
        }

        public WindowsElement getSendBtn()
        {
            return driver.FindElementByName("Send");
        }

        public WindowsElement getOverrideBtn()
        {
            return driver.FindElementByName("Override");
        }

        public WindowsElement getSpecialtyCmbBox()
        {
            return driver.FindElementByAccessibilityId("dcbSpecialty");
        }

        public WindowsElement getLanguageCmbBox()
        {
            return driver.FindElementByAccessibilityId("dcbLanguage");
        }
        public WindowsElement getWrapUpTab()
        {
            return driver.FindElementByName("Wrap Up");
        }

        public WindowsElement getReferralReasonCmbBox()
        {
            return driver.FindElementByAccessibilityId("dcbReferralReason");
        }
        public WindowsElement getReferralNoteTxtBox()
        {
            return driver.FindElementByAccessibilityId("txtReferralNote");
        }
        public WindowsElement getFirstDoctor()
        {
            return driver.FindElementByName("Row 0");
        }

        public WindowsElement getSearchBtn()
        {
            return driver.FindElementByAccessibilityId("btSearch");
        }

        public WindowsElement getEndReferralBtn()
        {
            return driver.FindElementByAccessibilityId("btEnd");
        }
        public WindowsElement getSentByAgentBtn()
        {
            return driver.FindElementByAccessibilityId("btAgt");
        }
        public WindowsElement getFirstRowFromSentByAgent()
        {
            return driver.FindElementByName("UpdateTime Row 0, Not sorted.");
        }

        public WindowsElement getTriageCallerFirstTxt()
        {
            return driver.FindElementByAccessibilityId("trxDetail_CallerFirstName");
        }
        public WindowsElement getTriageCallerLastTxt()
        {
            return driver.FindElementByAccessibilityId("trxDetail_CallerLastName");
        }
        public WindowsElement getTriageSameChckBox()
        {
            return driver.FindElementByAccessibilityId("triageIntake_CallerIsPatient");
        }
        public WindowsElement getRecordTriage(int ctr)
        {
            return driver.FindElementByXPath("//Table[@AutomationId='SearchResultsTable']/DataItem[position()=" + ctr + "]");
        }
        public WindowsElement getReturnButtonTriage()
        {
            return driver.FindElementByAccessibilityId("ReturnButton");
        }
        public WindowsElement getCallbackNoTriage()
        {
            return driver.FindElementByAccessibilityId("triageIntake_CallbackNumber");
        }
        public WindowsElement getPresentingProblem()
        {
            return driver.FindElementByAccessibilityId("triageIntake_PresentingProblem");
        }
        public WindowsElement getAddToQueueBtn()
        {
            return driver.FindElementByAccessibilityId("AddToQueueButton");
        }
        public int isContactSearchFormExists()
        {
            var msg = driver.FindElementsByName("Contact Search").Count();

            return msg;
        }

        public WindowsElement getContactFirstTxtBox()
        {
            return driver.FindElementByName("ContactFirst");
        }
        public WindowsElement getContactLastTxtBox()
        {
            return driver.FindElementByName("ContactLast");
        }

        public WindowsElement getTriageSearchBtn()
        {
            return driver.FindElementByName("Search");
        }
        public WindowsElement getReturnBtnFromTriageContactSearch()
        {
            return driver.FindElementByName("Return");
        }
        public int getAlreadyQueuedMessage()
        {
            return driver.FindElementsByName("This patient has a record in the input queue already. Please cancel this transaction and use the contact callback transaction or choose a new patient.").Count();
        }

        public int getRowTriageCount()
        {
            return driver.FindElementsByXPath("//Table[@AutomationId='dbgTrxSearch']/Custom[contains(@Name, 'Row')]").Count();
        }

        public WindowsElement getClinicalCallsBtn()
        {
            return driver.FindElementByAccessibilityId("btInQueue");
        }

        public WindowsElement getTriageTimeLastRow()
        {
            var count = this.getRowTriageCount();

            return driver.FindElementByName("Time Entered Row " + (count - 2).ToString() + ", Not sorted.");
        }

        public WindowsElement getTriageProbLastRow()
        {
            var count = this.getRowTriageCount();

            return driver.FindElementByName("Prob Row " + (count - 2).ToString() + ", Not sorted.");
        }

        public WindowsElement getTriageLastRow()
        {
            var count = this.getRowTriageCount();

            return driver.FindElementByName("Row " + (count - 2).ToString());
        }

        public WindowsElement getTriageGridTimeHeader()
        {
            return driver.FindElementByXPath("//Table[@AutomationId='dbgTrxSearch']/Custom/Header[5]");
        }
        public WindowsElement getTriageGridScrollBar()
        {
            return driver.FindElementByXPath("//Table[@AutomationId='dbgTrxSearch']/ScrollBar[@Name='Vertical Scroll Bar']/Thumb[@Name='Position']");
        }

        public WindowsElement getTakeCallBtn()
        {
            return driver.FindElementByAccessibilityId("btTakeCall");
        }
        public WindowsElement getStartTriageBtn()
        {
            return driver.FindElementByAccessibilityId("btStartTriage");
        }

        public WindowsElement getComplaintGuidelines()
        {
            return driver.FindElementByName("Guideline selection by Keyword(s), by Anatomy, or Alphabetic");
        }

        public WindowsElement getChiefComplaintTxtBox()
        {
            return driver.FindElementByXPath("//Pane[@Name='Untitled']/Table[2]/DataItem[1]/Edit");
        }

        public WindowsElement getFirstRowServiceReferral()
        {
            return driver.FindElementByName("Row 0");
        }
        public WindowsElement getBServiceTypeCmbBox()
        {
            return driver.FindElementByAccessibilityId("dcbCategorys");
        }
        public WindowsElement getSource() 
        {
            return driver.FindElementByAccessibilityId("dcbHowHeard");
        }
        public WindowsElement getServiceReferralReason() 
        {
            return driver.FindElementByAccessibilityId("dcbReferralReason");
        }
        public WindowsElement getAgentNote() 
        {
            return driver.FindElementByAccessibilityId("txtAgentNote");
        }
        public WindowsElement getEndServiceReferralBtn() 
        {
            return driver.FindElementByAccessibilityId("cmdDoneSearch");
        }
    }
}
