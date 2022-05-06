using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using JiraProject.DAL.Entities.Base;

namespace JiraProject.DAL.Entities
{
    public class User : EntityBase
    {
        public User()
        {
            UserRole = new List<UserRole>();
            UserTokenUser = new List<UserToken>();
            UserProjectUser = new List<ProjectUser>();
        }

        public string Email { get; set; }

        public string Password { get; set; }

        public string UserName { get; set; }

        public string Phone { get; set; }
        public string JobName { get; set; }
        public string DepartmentName { get; set; }
        public string OrganizationName { get; set; }
        [ForeignKey("IPCompanyUsers")]
        public int CompanyID { get; set; }
        public virtual Company IPCompanyUsers { get; set; }
        [InverseProperty("IPUserRoleUser")]
        public virtual ICollection<UserRole> UserRole { get; set; }
        [InverseProperty("IPUserTokenUser")]
        public virtual ICollection<UserToken> UserTokenUser { get; set; }
        [InverseProperty("IPUserProjectUser")]
        public virtual ICollection<ProjectUser> UserProjectUser { get; set; }
        [InverseProperty("IPUserProjectIssuesUser")]
        public virtual ICollection<ProjectIssues> IPUserProjectIssuesUser { get; set; }
        [InverseProperty("IPUserProjectIssuesReporter")]
        public virtual ICollection<ProjectIssues> IPUserProjectIssuesReporter { get; set; }


    }
}