using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagerApp.src.Models
{
    public class UserRolePrivs
    {
        public string USERNAME { get; set; }
        public string GRANTED_ROLE { get; set; }
        public string ADMIN_OPTION { get; set; }
        public string DELEGATE_OPTION { get; set; }
        public string DEFAULT_ROLE { get; set; }
        public string OS_GRANTED { get; set; }
        public string COMMON { get; set; }
        public string INHERITED { get; set; }
    }
}
