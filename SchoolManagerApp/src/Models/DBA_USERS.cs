using System;

namespace SchoolManagerApp.src.Models
{
    public class DBA_USERS
    {
        public string USERNAME { get; set; }

        public string USER_ID { get; set; }

        public string CREATED { get; set; }

        public DateTimeOffset EXPIRY_DAY { get; set; }

        public DateTimeOffset LAST_LOGIN { get; set; }

        public DateTimeOffset PASSWORD_CHANGE_DATE { get; set; }

        public string AUTHENTICATION_TYPE { get; set; }

        public string ACCOUNT_STATUS { get; set; }

    }
}
