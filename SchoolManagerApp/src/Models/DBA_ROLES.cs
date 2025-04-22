using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagerApp.src.Models
{
    public class DBA_ROLES
    {
        public string ROLE { get; set; }                   
        public string ROLE_ID { get; set; }                    
        public string PASSWORD_REQUIRED { get; set; }        
        public string AUTHENTICATION_TYPE { get; set; }      
        public string COMMON { get; set; }                  
        public string ORACLE_MAINTAINED { get; set; }      
        public string INHERITED { get; set; }              
        public string IMPLICIT { get; set; }               
        public string EXTERNAL_NAME { get; set; }          
    }
}
