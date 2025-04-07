namespace Mercuryfire.API
{
    public class ACPDReadRequest
    {
        public string ACPD_SID { get; set; }
        public string ACPD_LoginID { get; set; }
        public string ACPD_Email { get; set; }
        public int? ACPD_Status { get; set; }
    }
}
