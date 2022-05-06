using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using JiraProject.DAL.Entities.Base;

namespace JiraProject.DAL.Entities
{
    public class Roles : EntityBase
    {
        public Roles()
        {
            UserRole = new List<UserRole>();
            IPRolesMenuRole = new List<MenuRole>();
        }

        public string Name { get; set; }

        public string Desc { get; set; }

        [ForeignKey("IPCompanyRoles")]
        public int CompanyID { get; set; }
        public virtual Company IPCompanyRoles { get; set; }
        [InverseProperty("IPUserRoleRoles")]
        public virtual ICollection<UserRole> UserRole { get; set; }
        [InverseProperty("IPRolesMenuRole")]
        public virtual ICollection<MenuRole> IPRolesMenuRole { get; set; }
    }
}