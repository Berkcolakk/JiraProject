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
            MenuRole = new List<MenuRole>();
        }

        public string Name { get; set; }

        public string Desc { get; set; }

        [ForeignKey("CompanyID")]
        public int CompanyID { get; set; }

        public virtual ICollection<UserRole> UserRole { get; set; }

        public virtual ICollection<MenuRole> MenuRole { get; set; }
    }
}