using System;
using System.Collections.Generic;
using JiraProject.DAL.Entities;

namespace JiraProject.DAL.DataSeeding
{
    public static class Seeding
    {
        public static List<User> AllUserCreate()
        {
            List<User> allUsers = new List<User>
            {
                new User()
                {
                    CrtDate = DateTime.Now,
                    CrtUserID = 0,
                    UpdUserIP = "0",
                    UpdUserID = 0,
                    IsActive = true,
                    UpdDate=DateTime.Now,
                    CrtUserIP = "0",
                    MachineName = "DESKTOP-0000",
                    CompanyID = 1,
                    Email = "berkcolak4@gmail.com",
                    Password = "123456",
                    Phone = "5434203403",
                    ID = 1,
                    UserName = "Berk Çolak",
                },
                new User()
                {
                    CrtDate = DateTime.Now,
                    CrtUserID = 0,
                    UpdUserIP = "0",
                    UpdUserID = 0,
                    IsActive = true,
                    UpdDate=DateTime.Now,
                    CrtUserIP = "0",
                    MachineName = "DESKTOP-0000",
                    CompanyID = 1,
                    Email = "test@test.com.tr",
                    Password = "123456",
                    Phone = "123456",
                    ID = 2,
                    UserName = "Test Test",
                },
                new User()
                {
                    CrtDate = DateTime.Now,
                    CrtUserID = 0,
                    UpdUserIP = "0",
                    UpdUserID = 0,
                    IsActive = true,
                    UpdDate=DateTime.Now,
                    CrtUserIP = "0",
                    MachineName = "DESKTOP-0000",
                    CompanyID = 1,
                    Email = "test2@test.com.tr",
                    Password = "123456",
                    Phone = "123456",
                    ID = 3,
                    UserName = "Test Test",
                }
            };
            return allUsers;
        }

        public static List<UserRole> AllUserRoleCreate()
        {
            List<UserRole> allUsers = new List<UserRole>
            {
                new UserRole()
                {
                    CrtDate = DateTime.Now,
                    CrtUserID = 0,
                    UpdUserIP = "0",
                    UpdUserID = 0,
                    IsActive = true,
                    UpdDate=DateTime.Now,
                    CrtUserIP = "0",
                    MachineName = "DESKTOP-0000",
                    CompanyID = 1,
                    RoleID = 1,
                    UserID = 1,
                    ID = 1,
                    Desc = "TEST",
                    StartDate = DateTime.Now
                }
            };
            return allUsers;
        }

        public static List<Roles> AllRolesCreate()
        {
            List<Roles> allUsers = new List<Roles>
            {
                new Roles()
                {
                    CrtDate = DateTime.Now,
                    CrtUserID = 0,
                    UpdUserIP = "0",
                    UpdUserID = 0,
                    IsActive = true,
                    UpdDate=DateTime.Now,
                    CrtUserIP = "0",
                    MachineName = "DESKTOP-0000",
                    ID  = 1,
                    CompanyID = 1,
                    Desc = "TEST",
                    Name = "Yazılım Geliştirici",
                }
            };
            return allUsers;
        }

        public static List<Company> AllCompanyCreate()
        {
            List<Company> allUsers = new List<Company>
            {
                new Company()
                {
                    Name = "INTRANET Yazılım Teknolojileri",
                    CrtDate = DateTime.Now,
                    CrtUserID = 0,
                    UpdUserIP = "0",
                    UpdUserID = 0,
                    IsActive = true,
                    UpdDate=DateTime.Now,
                    CrtUserIP = "0",
                    MachineName = "DESKTOP-0000",
                    Desc = "Seeding-Data",
                    RegistrationNumber = "0",
                    Type = "1",
                    ID = 2
                }
            };
            return allUsers;
        }

        public static List<Menu> AllMenuCreate()
        {
            List<Menu> allUsers = new List<Menu>
            {
                //new Menu()
                //{
                //    CrtDate = DateTime.Now,
                //    CrtUserID = 0,
                //    UpdUserIP = "0",
                //    UpdUserID = 0,
                //    IsActive = true,
                //    UpdDate=DateTime.Now,
                //    CrtUserIP = "0",
                //    MachineName = "DESKTOP-0000",
                //}
            };
            return allUsers;
        }

        public static List<MenuRole> AllMenuRoleCreate()
        {
            List<MenuRole> allUsers = new List<MenuRole>
            {
                //new MenuRole()
                //{
                //    CrtDate = DateTime.Now,
                //    CrtUserID = 0,
                //    UpdUserIP = "0",
                //    UpdUserID = 0,
                //    IsActive = true,
                //    UpdDate=DateTime.Now,
                //    CrtUserIP = "0",
                //    MachineName = "DESKTOP-0000",
                //}
            };
            return allUsers;
        }
    }
}