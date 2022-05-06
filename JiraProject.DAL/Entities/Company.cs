using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using JiraProject.DAL.Entities.Base;

namespace JiraProject.DAL.Entities
{
    public class Company : EntityBase
    {
        public Company()
        {
            CompanyRoles = new List<Roles>();
            CompanyUsers = new List<User>();
            CompanyUserRole = new List<UserRole>();
            CompanyMenu = new List<Menu>();
            CompanyProjects = new List<Projects>();
        }

        public string Name { get; set; }

        public string Desc { get; set; }

        public string Type { get; set; }

        public string RegistrationNumber { get; set; }
        [InverseProperty("IPCompanyRoles")]
        public virtual ICollection<Roles> CompanyRoles { get; set; }
        [InverseProperty("IPCompanyUsers")]
        public virtual ICollection<User> CompanyUsers { get; set; }
        [InverseProperty("IPCompanyUserRole")]
        public virtual ICollection<UserRole> CompanyUserRole { get; set; }
        [InverseProperty("IPCompanyMenu")]
        public virtual ICollection<Menu> CompanyMenu { get; set; }
        [InverseProperty("IPCompanyProjects")]
        public virtual ICollection<Projects> CompanyProjects { get; set; }
    }
}