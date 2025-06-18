using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
SYNOPSIS: Lớp BaseService đóng vai trò là lớp cơ sở cho các service khác, cung cấp kết nối database chung.
FUNCTIONS: Constructor BaseService(): Khởi tạo instance của DatabaseService để sử dụng chung.
GLOBAL VARIABLES:
_dbService: Đối tượng DatabaseService dùng chung cho các service kế thừa.
*/
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
