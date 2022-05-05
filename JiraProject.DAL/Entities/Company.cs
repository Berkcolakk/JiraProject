using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using JiraProject.DAL.Entities.Base;

namespace JiraProject.DAL.Entities
{
    public class Company : EntityBase
    {
        public Company()
        {
            Roles = new List<Roles>();
            Users = new List<User>();
            UserRole = new List<UserRole>();
            Menu = new List<Menu>();
        }

        public string Name { get; set; }

        public string Desc { get; set; }

        public string Type { get; set; }

        public string RegistrationNumber { get; set; }

        public virtual ICollection<Roles> Roles { get; set; }
        public virtual ICollection<User> Users { get; set; }

        public virtual ICollection<UserRole> UserRole { get; set; }

        public virtual ICollection<Menu> Menu { get; set; }
    }
}