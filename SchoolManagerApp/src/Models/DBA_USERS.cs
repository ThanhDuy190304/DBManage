using System;

namespace SchoolManagerApp.src.Models
{
    public class DBA_USERS
    {
        public string USERNAME { get; set; }
        public string ACCOUNT_STATUS { get; set; }
        public DateTime ACCOUNT_CREATED { get; set; }
        public string SYSTEM_PRIVILEGES { get; set; }
        public string OBJECT_PRIVILEGES { get; set; }
        public string ROLES { get; set; }
    }

}
