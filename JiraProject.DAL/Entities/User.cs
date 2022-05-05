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
            UserToken = new List<UserToken>();
            ProjectUsers = new List<ProjectUser>();
            ProjectUsersID = new List<ProjectIssues>();
            ProjectReporterID = new List<ProjectIssues>();
        }

        public string Email { get; set; }

        public string Password { get; set; }

        public string UserName { get; set; }

        public string Phone { get; set; }
        public string JobName { get; set; }
        public string DepartmentName { get; set; }
        public string OrganizationName { get; set; }
        [ForeignKey("CompanyID")]
        public int CompanyID { get; set; }
        public virtual ICollection<UserRole> UserRole { get; set; }

        public virtual ICollection<UserToken> UserToken { get; set; }
        public ICollection<ProjectUser> ProjectUsers { get; set; }
        [ForeignKey(nameof(ProjectUsersID))]
        public ICollection<ProjectIssues> ProjectUsersID { get; set; }
        [ForeignKey(nameof(ProjectReporterID))]
        public ICollection<ProjectIssues> ProjectReporterID { get; set; }
    }
}