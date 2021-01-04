using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareScriptTestAutomation.Src.TransactionWindow.DataObjects
{
    class Request
    {
        public string AtClass { get; set; }
        public string Dir { get; set; }
        public string Clas { get; set; }
        public string CallerFirst { get; set; }
        public string Last { get; set; }
        public string CallerLast { get; set; }
        public string PatientStatus { get; set; }
        public string Provider { get; set; }
        public string MessageType { get; set; }
        public string Message { get; set; }
        public string CallBackNo { get; set; }
        public string HeardSource { get; set; }
        public string Specialty { get; set; }
        public string Language { get; set; }
        public string ReferralReason { get; set; }
        public string AgentNote { get; set; }
        public string CallbackNoTriage { get; set; }
        public string PresentingProblem { get; set; }
        public string BServiceType { get; set; }
        public string Source { get; set; }
        public string ServiceReferralReason { get; set; }
        public string ServiceReferalAgentNote { get; set; }
    }
}
