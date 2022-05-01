using System;
using System.ComponentModel.DataAnnotations.Schema;
using TestProject.DAL.Entities.Base;

namespace TestProject.DAL.Entities
{
    public class UserRole : EntityBase
    {
        public UserRole()
        {
        }

        [ForeignKey("UserID")]
        public int UserID { get; set; }

        public string Desc { get; set; }

        public DateTime StartDate { get; set; }

        [ForeignKey("RoleID")]
        public int RoleID { get; set; }

        [ForeignKey("CompanyID")]
        public int CompanyID { get; set; }
    }
}