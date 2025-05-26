using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagerApp.src.Models
{
    public class StandardAuditRecord
    {
        public string OS_USERNAME { get; set; }
        public string USERNAME { get; set; }
        public string USERHOST { get; set; }
        public DateTime TIMESTAMP { get; set; }
        public string ObjectOwner { get; set; }
        public string ObjectName { get; set; }
        public string ACTION_NAME { get; set; }
        public string SQL_TEXT { get; set; }
    }
}
