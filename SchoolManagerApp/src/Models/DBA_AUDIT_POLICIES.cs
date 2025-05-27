using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagerApp.src.Models
{
    public class DBA_AUDIT_POLICIES
    {
        public string OBJECT_SCHEMA { get; set; }
        public string OBJECT_NAME { get; set; }
        public string POLICY_OWNER { get; set; }
        public string POLICY_NAME { get; set; }
        public string POLICY_TEXT { get; set; }
        public string POLICY_COLUMNS { get; set; }
        public string PF_SCHEMA { get; set; }
        public string PF_PACKAGE { get; set; }
        public string PF_FUNCTION { get; set; }
        public string ENABLED { get; set; }

        public string SEL { get; set; }
        public string INS { get; set; }
        public string UPD { get; set; }
        public string DEL { get; set; }

        public string AUDIT_TRAIL { get; set; }
        public string POLICY_COLUMN_OPTIONS { get; set; }
        public string COMMON { get; set; }
        public string INHERITED { get; set; }
    }

}
