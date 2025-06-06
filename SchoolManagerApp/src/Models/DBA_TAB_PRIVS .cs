﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagerApp.src.Models
{
    public class DBA_TAB_PRIVS
    {
        public string GRANTEE { get; set; }
        public string OWNER { get; set; }
        public string TABLE_NAME { get; set; }
        public string GRANTOR { get; set; }
        public string PRIVILEGE { get; set; }
        public string GRANTABLE { get; set; }
        public string HIERARCHY { get; set; }
        public string INHERITED { get; set; }
        public string COMMON { get; set; }
        public string TYPE { get; set; }
    }
}
