using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagerApp.src.Service
{
    internal abstract class BaseService
    {
        protected readonly DatabaseService _dbService;
        protected BaseService()
        {
            _dbService = DatabaseService.GetInstance("", "");
        }
    
    }
}
