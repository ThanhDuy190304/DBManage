using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagerApp.src.Models
{
    public class MockUser
    {
        public static List<User> GetMockUsers()
        {
            return new List<User>
            {
                new User
                {
                    Id = 1,
                    Username = "admin1",
                    Password = "admin123",
                    Role = UserRole.Admin,
                    CreatedAt = new DateTime(2023, 1, 1)
                },
                new User
                {
                    Id = 2,
                    Username = "teacher1",
                    Password = "teacher123",
                    Role = UserRole.Teacher,
                    CreatedAt = new DateTime(2023, 2, 1)
                },
                new User
                {
                    Id = 3,
                    Username = "student1",
                    Password = "student123",
                    Role = UserRole.Student,
                    CreatedAt = new DateTime(2023, 3, 1)
                },
                new User
                {
                    Id = 4,
                    Username = "teacher2",
                    Password = "teacher456",
                    Role = UserRole.Teacher,
                    CreatedAt = new DateTime(2023, 4, 1)
                },
                new User
                {
                    Id = 5,
                    Username = "student2",
                    Password = "student456",
                    Role = UserRole.Student,
                    CreatedAt = new DateTime(2023, 5, 1)
                }
            };
        }
    }
}