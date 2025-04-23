using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagerApp.src.Service
{
    internal abstract class BaseService<T>
    {
        protected readonly DatabaseService _dbService;
        protected BaseService()
        {
            _dbService = DatabaseService.GetInstance("", "");
        }
        public abstract Task<IEnumerable<T>> GetAll();
        public abstract Task<bool> Delete(string id);
    }
}
