using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagerApp.src.Models
{
    public class DBA_AUDIT_SESSION
    {
        public string OS_USERNAME { get; set; }
        public string USERNAME { get; set; }
        public string USERHOST { get; set; }
        public string TERMINAL { get; set; }
        public DateTimeOffset TIMESTAMP { get; set; }
        public string ACTION_NAME { get; set; }
        public DateTimeOffset LOGOFF_TIME { get; set; }
        public decimal LOGOFF_LREAD { get; set; }
        public decimal LOGOFF_PREAD { get; set; }
        public decimal LOGOFF_LWRITE { get; set; }
        public string LOGOFF_DLOCK { get; set; }
        public decimal SESSIONID { get; set; }
        public decimal RETURNCODE { get; set; }
        public string CLIENT_ID { get; set; }
        public decimal? SESSION_CPU { get; set; }
        public DateTimeOffset EXTENDED_TIMESTAMP { get; set; }
        public decimal? PROXY_SESSIONID { get; set; }
        public string GLOBAL_UID { get; set; }
        public decimal INSTANCE_NUMBER { get; set; }
        public string OS_PROCESS { get; set; }
    }
}
