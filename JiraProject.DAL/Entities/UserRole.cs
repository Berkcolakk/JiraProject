using System;
using System.ComponentModel.DataAnnotations.Schema;
using JiraProject.DAL.Entities.Base;

namespace JiraProject.DAL.Entities
{
    public class UserRole : EntityBase
    {
        public UserRole()
        {
        }

        [ForeignKey("IPUserRoleUser")]
        public int UserID { get; set; }
        public virtual User IPUserRoleUser { get; set; }

        public string Desc { get; set; }

        public DateTime StartDate { get; set; }

        [ForeignKey("IPUserRoleRoles")]
        public int RoleID { get; set; }
        public virtual Roles IPUserRoleRoles { get; set; }

        [ForeignKey("IPCompanyUserRole")]
        public int CompanyID { get; set; }
        public virtual Company IPCompanyUserRole { get; set; }
    }
}