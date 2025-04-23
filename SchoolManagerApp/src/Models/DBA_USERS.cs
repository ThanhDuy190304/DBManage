using System;

namespace SchoolManagerApp.src.Models
{
    public class DBA_USERS
    {
        public string USERNAME { get; set; }

        public string USER_ID { get; set; }

        public string CREATED { get; set; }

        public DateTimeOffset LAST_LOGIN { get; set; }

        public string PASSWORD { get; set; }
    }
}
