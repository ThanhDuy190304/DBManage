using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagerApp.src.Models
{
    public class FGAAuditRecord
    {
        public string DB_USER { get; set; }
        public DateTime TIMESTAMP { get; set; }
        public string OBJECT_SCHEMA { get; set; }
        public string OBJECT_NAME { get; set; }
        public string POLICY_NAME { get; set; }
        public string SQL_TEXT { get; set; }
        public decimal SCN { get; set; }
        public string STATEMENT_TYPE { get; set; }
    }
}
