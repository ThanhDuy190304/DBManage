using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagerApp.src.Service
{
    internal class BaseService
    {
        public interface IBaseService<T> where T : class
        {
            Task<IEnumerable<T>> GetAllAsync();
            Task<T> CreateAsync(T entity);
            Task<bool> DeleteAsync(int id);
        }
    }
}
