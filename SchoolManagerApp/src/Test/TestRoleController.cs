using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using SchoolManagerApp.src.Controller;
using SchoolManagerApp.src.Service;
using SchoolManagerApp.src.utils;
using SchoolManagerApp.src.Models;

namespace SchoolManagerApp.src.Test
{
    public class TestRoleController
    {
        private readonly RoleController _roleController;
        private readonly UserController _userController;
        private readonly AuthController _authController;
        private DatabaseService _adminDbService; // For admin operations
        private DatabaseService _testUserDbService; // For testing user access
        public TestRoleController()
        {
            _roleController = new RoleController();
            _userController = new UserController();
            _authController = new AuthController();
            _adminDbService = DatabaseService.GetInstance("sys as sysdba", "Admin123");
        }

        

        

    }
}
