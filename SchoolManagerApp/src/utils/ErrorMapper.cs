using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagerApp.src.utils
{
    internal class ErrorMapper
    {
        public static BaseError MapOracleException(OracleException ex)
        {
            switch (ex.Number)
            {
                case 1:
                    return new ConflictError("Dữ liệu đã tồn tại (trùng khóa)."); // ORA-00001

                case 942:
                    return new NotFoundError("Bảng hoặc view không tồn tại."); // ORA-00942

                case 1017:
                    return new InvalidDataError("Sai tên người dùng hoặc mật khẩu."); // ORA-01017

                case 28000:
                    return new BaseError("Tài khoản bị khóa, vui lòng liên hệ admin."); // ORA-28000

                case 01950:
                    return new PermissionDeniedError("Bạn không có quyền thực hiện thao tác này"); // ORA-01950

                case 12541:
                    return new ServerError("Không thể kết nối đến cơ sở dữ liệu (ORA-12541)."); // No listener

                default:
                    return new ServerError($"Lỗi Oracle ({ex.Number}): {ex.Message}");
            }
        }
    }
}
