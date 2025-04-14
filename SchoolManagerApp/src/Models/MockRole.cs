using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagerApp.src.Models
{
    internal class MockRole
    {
        public static List<Role> GetMockRoles()
        {
            return new List<Role>
            {
                new Role { Id = 1, Name = "Admin" },
                new Role { Id = 2, Name = "User" },
                new Role { Id = 3, Name = "Manager" },
                new Role { Id = 4, Name = "Editor" }
            };
        }
    }
}