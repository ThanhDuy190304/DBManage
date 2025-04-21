using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolManagerApp.src.Models;
using Dapper;
using Oracle.ManagedDataAccess.Client;
using SchoolManagerApp.src.utils;

namespace SchoolManagerApp.src.Service
{
    internal class UserService : BaseService<UserRolePrivs>
    {
        // Cài đặt phương thức GetAll
        override
        public async Task<IEnumerable<UserRolePrivs>> GetAll()
        {
            try
            {
                string query = "SELECT * FROM DBA_USERS"; // Lấy tất cả người dùng trong hệ thống
                // Lưu ý: Sử dụng _dbService.Connection để thực thi câu lệnh SQL
                return await _dbService.Connection.QueryAsync<UserRolePrivs>(query);
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex); // Xử lý lỗi Oracle
            }
            catch (Exception ex)
            {
                throw new ServerError("Không thể khởi tạo kết nối: " + ex.Message); // Xử lý lỗi chung
            }
        }

        // Cài đặt phương thức Delete
        override
        public async Task<bool> Delete(string username)
        {
            string query = $"DROP USER {username} CASCADE"; // Xóa user cùng với tất cả đối tượng của user đó
            try
            {
                await _dbService.Connection.ExecuteAsync(query);
                return true; // Trả về true khi xóa thành công
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex); // Đảm bảo xử lý lỗi Oracle
            }
            catch (Exception ex)
            {
                throw new ServerError("Không thể xóa user: " + ex.Message); // Xử lý lỗi chung
            }
        }
        public async Task<bool> CreateUser(string username, string password)
        {
            string createUserQuery = $"CREATE USER {username} IDENTIFIED BY {password}"; // Tạo user mới

            try
            {
                // Tạo user mới
                await _dbService.Connection.ExecuteAsync(createUserQuery);
;


                return true; // Trả về true khi tạo user và cấp quyền thành công
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex); // Xử lý lỗi Oracle
            }
            catch (Exception ex)
            {
                throw new ServerError("Không thể tạo user: " + ex.Message); // Xử lý lỗi chung
            }
        }

        // Cài đặt phương thức UpdateUserPassword
        public async Task<bool> UpdateUserPassword(string username, string newPassword)
        {
            string query = $"ALTER USER {username} IDENTIFIED BY {newPassword}";
            try
            {
                await _dbService.Connection.ExecuteAsync(query);
                return true; // Trả về true khi cập nhật mật khẩu thành công
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex); // Xử lý lỗi Oracle
            }
            catch (Exception ex)
            {
                throw new ServerError("Không thể cập nhật mật khẩu: " + ex.Message); // Xử lý lỗi chung
            }
        }
        public async Task<bool> GrantRoleToUser(string roleName, string username, bool withAdminOption = false)
        {
            // Xây dựng câu lệnh SQL Grant Role
            string grantRoleQuery = $"GRANT {roleName} TO {username}";

            // Nếu có yêu cầu cấp quyền với admin option, thêm 'WITH ADMIN OPTION' vào câu lệnh
            if (withAdminOption)
            {
                grantRoleQuery += " WITH ADMIN OPTION";
            }

            try
            {
                // Thực thi câu lệnh GRANT
                await _dbService.Connection.ExecuteAsync(grantRoleQuery);
                return true; // Trả về true khi gán role cho user thành công
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex); // Xử lý lỗi Oracle
            }
            catch (Exception ex)
            {
                throw new ServerError("Không thể gán role cho user: " + ex.Message); // Xử lý lỗi chung
            }
        }

        public async Task<bool> GrantSystemPrivilegesToUser(string username, List<string> systemPrivileges, bool withAdminOption = false)
        {
            if (systemPrivileges == null || systemPrivileges.Count == 0)
                throw new ArgumentException("Danh sách quyền hệ thống không được rỗng.", nameof(systemPrivileges));

            // Ghép các quyền lại thành chuỗi
            string privilegesString = string.Join(", ", systemPrivileges);

            // Nếu chọn cấp WITH ADMIN OPTION thì thêm vào cuối
            string adminOptionClause = withAdminOption ? " WITH ADMIN OPTION" : "";

            // Câu lệnh GRANT hệ thống
            string grantQuery = $"GRANT {privilegesString} TO {username}{adminOptionClause}";

            try
            {
                await _dbService.Connection.ExecuteAsync(grantQuery);
                return true;
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex);
            }
            catch (Exception ex)
            {
                throw new ServerError($"Không thể cấp quyền hệ thống: {ex.Message}");
            }
        }
        public async Task<List<string>> GetUserPrivileges(string username)
        {
            try
            {
                // Truy vấn quyền hệ thống của user từ DBA_SYS_PRIVS, bao gồm cả quyền "WITH ADMIN OPTION"
                string sysPrivilegesQuery = $@"
        SELECT PRIVILEGE || CASE WHEN ADMIN_OPTION = 'YES' THEN ' WITH ADMIN OPTION' ELSE '' END
        FROM DBA_SYS_PRIVS
        WHERE GRANTEE = '{username}'";

                // Truy vấn quyền đối tượng của user từ DBA_TAB_PRIVS, bao gồm cả tên bảng
                string tabPrivilegesQuery = $@"
        SELECT PRIVILEGE || ' ON ' || TABLE_NAME
        FROM DBA_TAB_PRIVS
        WHERE GRANTEE = '{username}'";

                // Kết hợp kết quả của cả hai truy vấn
                var sysPrivileges = await _dbService.Connection.QueryAsync<string>(sysPrivilegesQuery);
                var tabPrivileges = await _dbService.Connection.QueryAsync<string>(tabPrivilegesQuery);

                // Kết hợp danh sách quyền hệ thống và quyền đối tượng
                var allPrivileges = sysPrivileges.Concat(tabPrivileges).ToList();

                return allPrivileges;
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex); // Xử lý lỗi Oracle
            }
            catch (Exception ex)
            {
                throw new ServerError("Lỗi không xác định khi lấy quyền của user: " + ex.Message); // Xử lý lỗi chung
            }
        }
        public async Task<bool> RevokeRoleFromUser(string roleName, string username)
        {
            string revokeRoleQuery = $"REVOKE {roleName} FROM {username}";
            try
            {
                await _dbService.Connection.ExecuteAsync(revokeRoleQuery);
                return true; // Trả về true khi thu hồi quyền thành công
            }
            catch (OracleException ex)
            {
                throw ErrorMapper.MapOracleException(ex); // Xử lý lỗi Oracle
            }
            catch (Exception ex)
            {
                throw new ServerError("Không thể thu hồi role từ user: " + ex.Message); // Xử lý lỗi chung
            }
        }
        public async Task<bool> RevokePrivilegesFromUser(List<string> privileges, string username, string privilegeType)
        {
            string revokeQuery = string.Empty;

            // Kiểm tra loại quyền (quyền hệ thống hoặc quyền đối tượng)
            if (privilegeType == "SYSTEM")
            {
                // Thu hồi quyền hệ thống từ người dùng
                foreach (var privilege in privileges)
                {
                    revokeQuery = $"REVOKE {privilege} FROM {username}";
                    try
                    {
                        await _dbService.Connection.ExecuteAsync(revokeQuery);
                    }
                    catch (OracleException ex)
                    {
                        throw ErrorMapper.MapOracleException(ex); // Xử lý lỗi Oracle
                    }
                    catch (Exception ex)
                    {
                        throw new ServerError("Không thể thu hồi quyền hệ thống từ user: " + ex.Message); // Xử lý lỗi chung
                    }
                }
            }
            else if (privilegeType == "OBJECT")
            {
                // Thu hồi quyền đối tượng từ người dùng
                foreach (var privilege in privileges)
                {
                    revokeQuery = $"REVOKE {privilege} ON {username}.* FROM {username}";
                    try
                    {
                        await _dbService.Connection.ExecuteAsync(revokeQuery);
                    }
                    catch (OracleException ex)
                    {
                        throw ErrorMapper.MapOracleException(ex); // Xử lý lỗi Oracle
                    }
                    catch (Exception ex)
                    {
                        throw new ServerError("Không thể thu hồi quyền đối tượng từ user: " + ex.Message); // Xử lý lỗi chung
                    }
                }
            }
            else
            {
                throw new ArgumentException("Loại quyền không hợp lệ.");
            }

            return true; // Trả về true khi thu hồi quyền thành công
        }
    }


}

