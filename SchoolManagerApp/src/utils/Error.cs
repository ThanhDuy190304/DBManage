using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagerApp.src.utils
{
    internal class BaseError : Exception
    {
        public BaseError(string message) : base(message) { }
    }

    internal class NotFoundError : BaseError
    {
        public NotFoundError(string message = "Không tìm thấy.") : base(message) { }
    }

    internal class ServerError : BaseError
    {
        public ServerError(string message = "Lỗi server.") : base(message) { }
    }

    internal class ConflictError : BaseError
    {
        public ConflictError(string message = "Tài nguyên đã tồn tại.") : base(message) { }
    }
    internal class InvalidDataError : BaseError
    {
        public InvalidDataError(string message = "Dữ liệu được cung cấp không hợp lệ") : base(message) { }
    }
    internal class PermissionDeniedError : BaseError
    {
        public PermissionDeniedError(string message = "Bạn không có quyền thực hiện thao tác này.") : base(message) { }
    }


}
