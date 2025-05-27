using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagerApp.src.Models
{
    public class DBA_POLICIES
    {
        public string OBJECT_OWNER { get; set; }
        public string OBJECT_NAME { get; set; }
        public string POLICY_GROUP { get; set; }
        public string POLICY_NAME { get; set; }
        public string PACKAGE { get; set; }
        public string PF_OWNER { get; set; }
        public string FUNCTION { get; set; }
        public string SEL { get; set; }
        public string INS { get; set; }
        public string UPD { get; set; }
        public string DEL { get; set; }
        public string IDX { get; set; }
        public string CHK_OPTION { get; set; }
        public string ENABLE { get; set; }
        public string STATIC_POLICY { get; set; }
        public string POLICY_TYPE { get; set; }
        public string LONG_PREDICATE { get; set; }
        public string COMMON { get; set; }
        public string INHERITED { get; set; }
    }

}
