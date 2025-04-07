﻿namespace Mercuryfire.API
{
    public class ACPDDeleteRequest
    {
        public string ACPD_SID { get; set; }
        public string ACPD_Cname { get; set; }
        public string ACPD_Ename { get; set; }
        public string ACPD_Sname { get; set; }
        public string ACPD_Email { get; set; }
        public byte ACPD_Status { get; set; }
        public bool ACPD_Stop { get; set; }
        public string ACPD_StopMemo { get; set; }
        public string ACPD_LoginPWD { get; set; }
        public string ACPD_Memo { get; set; }
        public string ACPD_UPDID { get; set; }
    }
}
