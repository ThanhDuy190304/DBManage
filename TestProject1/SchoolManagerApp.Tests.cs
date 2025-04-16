// --- TẤT CẢ using PHẢI ĐẶT LÊN ĐẦU TIÊN ---
using NUnit.Framework;             // using cho NUnit
using SchoolManagerApp.src.Models; // using để thấy lớp User, MockUser (đã được đơn giản hóa)
using SchoolManagerApp.src.Service; // using để thấy lớp UserService (đã được cập nhật)
using SchoolManagerApp.src.Service.Interfaces; // using để thấy IUserService (đã được cập nhật)
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic; // Cần thiết cho List<User>
using System;                     // Cần cho ArgumentException,...

// --- SAU ĐÓ MỚI ĐẾN ASSEMBLY ATTRIBUTES (NẾU CÓ) ---
// [assembly: Parallelize(Scope = ExecutionScope.MethodLevel)]

// --- CUỐI CÙNG LÀ NAMESPACE VÀ CÁC KHAI BÁO KHÁC ---
namespace SchoolManagerApp.Tests
{
    [TestFixture] // Đánh dấu đây là một lớp chứa các test case cho NUnit
    public class UserServiceTests
    {
        private IUserService _userService; // Sử dụng Interface để dễ Mocking
        private List<User> _initialMockUsers; // Lưu trữ dữ liệu mock ban đầu (với User đơn giản)

        [SetUp] // Phương thức này sẽ chạy TRƯỚC MỖI test case trong lớp này
        public void Setup()
        {
            // Tạo một instance MỚI của UserService cho mỗi test
            // Điều này đảm bảo các test không ảnh hưởng lẫn nhau
            _userService = new UserService(); // Giả sử UserService hoạt động với User đơn giản

            // Lấy dữ liệu mock gốc MỚI (với User đơn giản) cho mỗi test
            _initialMockUsers = MockUser.GetMockUsers().ToList(); // Giả sử GetMockUsers trả về List<User> đơn giản
        }

        // --- Test cho GetAllAsync ---
        [Test]
        public async Task GetAllAsync_WhenCalled_ReturnsAllMockUsers()
        {
            // Arrange (Đã thực hiện trong Setup)
            // Đảm bảo _initialMockUsers có dữ liệu từ MockUser đơn giản hóa

            // Act
            var result = await _userService.GetAllAsync();
            var resultList = result.ToList();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(_initialMockUsers.Count, resultList.Count); // So sánh số lượng
            // Kiểm tra xem tất cả Id từ mock ban đầu có tồn tại trong kết quả không
            CollectionAssert.AreEquivalent(_initialMockUsers.Select(u => u.Id), resultList.Select(u => u.Id));
            // (Tùy chọn) Kiểm tra sâu hơn một vài thuộc tính nếu cần
            if (_initialMockUsers.Any() && resultList.Any())
            {
                var firstMock = _initialMockUsers.First();
                var firstResult = resultList.FirstOrDefault(u => u.Id == firstMock.Id);
                Assert.IsNotNull(firstResult);
                Assert.AreEqual(firstMock.Username, firstResult.Username);
                Assert.AreEqual(firstMock.Email, firstResult.Email);
            }
        }

        // --- Test cho CreateAsync ---
        [Test]
        public async Task CreateAsync_WhenCalledWithValidNewUser_AddsUserAndReturnsItWithId()
        {
            // Arrange
            var newUser = new User
            {
                // Id sẽ được gán bởi service
                Username = "new.user",          // Username mới, chưa tồn tại
                Email = "new.user@example.com" // Email mới, chưa tồn tại
            };
            int initialCount = (await _userService.GetAllAsync()).Count(); // Lấy count từ service hiện tại
            int maxInitialId = 0;
            if (initialCount > 0)
            {
                maxInitialId = (await _userService.GetAllAsync()).Max(u => u.Id);
            }


            // Act
            var createdUser = await _userService.CreateAsync(newUser);
            var allUsersAfterCreate = (await _userService.GetAllAsync()).ToList();

            // Assert
            Assert.IsNotNull(createdUser);
            Assert.AreEqual(newUser.Username, createdUser.Username); // Kiểm tra Username
            Assert.AreEqual(newUser.Email, createdUser.Email);       // Kiểm tra Email
            Assert.AreEqual(maxInitialId + 1, createdUser.Id);     // Kiểm tra Id được gán đúng

            Assert.AreEqual(initialCount + 1, allUsersAfterCreate.Count); // Tổng số user tăng lên 1
            // Kiểm tra user mới có thực sự nằm trong danh sách trả về không
            var addedUserInList = allUsersAfterCreate.FirstOrDefault(u => u.Id == createdUser.Id);
            Assert.IsNotNull(addedUserInList);
            Assert.AreEqual(newUser.Username, addedUserInList.Username); // Kiểm tra lại dữ liệu trong list
            Assert.AreEqual(newUser.Email, addedUserInList.Email);       // Kiểm tra lại dữ liệu trong list
        }

        [Test]
        public void CreateAsync_WhenUsernameExists_ThrowsArgumentException()
        {
            // Arrange
            // Lấy một user đã tồn tại từ service (để đảm bảo test độc lập với mock data ban đầu)
            var existingUser = _userService.GetAllAsync().Result.FirstOrDefault();
            Assert.IsNotNull(existingUser, "Need at least one user in the service for this test.");

            var newUserWithExistingUsername = new User
            {
                Username = existingUser.Username,      // Sử dụng Username đã tồn tại
                Email = "unique.email@example.com" // Email phải khác
            };

            // Act & Assert
            var ex = Assert.ThrowsAsync<ArgumentException>(async () => await _userService.CreateAsync(newUserWithExistingUsername));
            Assert.That(ex.Message, Does.Contain($"Username '{existingUser.Username}' already exists"));
        }

        [Test]
        public void CreateAsync_WhenEmailExists_ThrowsArgumentException()
        {
            // Arrange
            var existingUser = _userService.GetAllAsync().Result.FirstOrDefault();
            Assert.IsNotNull(existingUser, "Need at least one user in the service for this test.");

            var newUserWithExistingEmail = new User
            {
                Username = "UniqueUsername", // Username phải khác
                Email = existingUser.Email       // Sử dụng Email đã tồn tại
            };

            // Act & Assert
            var ex = Assert.ThrowsAsync<ArgumentException>(async () => await _userService.CreateAsync(newUserWithExistingEmail));
            Assert.That(ex.Message, Does.Contain($"Email '{existingUser.Email}' already exists"));
        }

        // --- Test cho DeleteAsync ---
        [Test]
        public async Task DeleteAsync_WhenUserExists_RemovesUserAndReturnsTrue()
        {
            // Arrange
            var usersBeforeDelete = (await _userService.GetAllAsync()).ToList();
            Assert.IsTrue(usersBeforeDelete.Any(), "Need at least one user in the service for this test.");
            int initialServiceCount = usersBeforeDelete.Count;
            int idToDelete = usersBeforeDelete.First().Id; // Lấy Id của user đầu tiên trong service để xóa

            // Act
            bool result = await _userService.DeleteAsync(idToDelete);
            var allUsersAfterDelete = (await _userService.GetAllAsync()).ToList();

            // Assert
            Assert.IsTrue(result); // Phải trả về true (xóa thành công)
            Assert.AreEqual(initialServiceCount - 1, allUsersAfterDelete.Count); // Số lượng giảm 1
            Assert.IsFalse(allUsersAfterDelete.Any(u => u.Id == idToDelete)); // User đã xóa không còn tồn tại
        }

        [Test]
        public async Task DeleteAsync_WhenUserDoesNotExist_ReturnsFalse()
        {
            // Arrange
            int maxId = 0;
            var currentUsers = (await _userService.GetAllAsync()).ToList();
            if (currentUsers.Any())
            {
                maxId = currentUsers.Max(u => u.Id);
            }
            int nonExistentId = maxId + 100; // Một Id chắc chắn không tồn tại
            int initialServiceCount = currentUsers.Count;

            // Act
            bool result = await _userService.DeleteAsync(nonExistentId);
            var allUsersAfterDelete = (await _userService.GetAllAsync()).ToList();

            // Assert
            Assert.IsFalse(result); // Phải trả về false (không tìm thấy để xóa)
            Assert.AreEqual(initialServiceCount, allUsersAfterDelete.Count); // Số lượng không thay đổi
        }
    }
}