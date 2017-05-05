using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Model.Entity { 


    public class Member : Entity
    {
        public string MemberID { get; set; }
        public string MemberName { get; set; }
        public string MemberPhone { get; set; }
        public string MemberPassword { get; set; }
        public string MemberPhoto { get; set; }
        public string SMSCode { get; set; }
        public string SMSCodeAddTime { get; set; }
        public Nullable<int> SMSCodeAddNum { get; set; }
        public string MemberRank { get; set; }
        public string MemberRealName { get; set; }
        public string MemberIDCard { get; set; }
        public Nullable<decimal> MemberAccountBalance { get; set; }
        public string MemberSex { get; set; }
        public Nullable<System.DateTime> MemberBirthday { get; set; }
        public string MemberAddress { get; set; }
        public string MemberZipCode { get; set; }
        public string MemberEmail { get; set; }
        public string WebChatID { get; set; }
        public string MemberQQ { get; set; }
        public string Facebook { get; set; }
        public Nullable<System.DateTime> MemberRegTime { get; set; }
        public Nullable<int> MemberLoginCount { get; set; }
        public Nullable<System.DateTime> MemberLastLoginTime { get; set; }
        public string MemberLastLoginIPv4 { get; set; }
        public string MemberLastLoginIPv6 { get; set; }
        public string MemberStatus { get; set; }
        public string MemberSecurityQuestionOne { get; set; }
        public string MemberSecurityQuestionTwo { get; set; }
        public string MemberSecurityQuestionThree { get; set; }
        public string MemberSecurityAnswerOne { get; set; }
        public string MemberSecurityAnswerTwo { get; set; }
        public string MemberSecurityAnswerThree { get; set; }
        public string Remarks { get; set; }
        public string ThirdPlatformID { get; set; }
        public string IsAuthentication { get; set; }
    }
}
