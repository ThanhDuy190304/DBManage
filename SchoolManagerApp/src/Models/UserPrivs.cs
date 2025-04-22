using System;

namespace SchoolManagerApp.src.Models
{
    public class UserPrivs
    {
        public string USERNAME { get; set; }
        public string ROLE { get; set; }
        public string SYSTEM_PRIVILEGES { get; set; }
        public string OBJECT_PRIVILEGES { get; set; }
        public DateTime ACCOUNT_CREATED { get; set; }
        public string ACCOUNT_STATUS { get; set; }
    }
}
