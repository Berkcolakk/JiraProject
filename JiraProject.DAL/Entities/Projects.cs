using JiraProject.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraProject.DAL.Entities
{
    public class Projects : EntityBase
    {
        public Projects()
        {
            //ProjectUsersID = new List<ProjectUser>();
            //ProjectIssuespProjectID = new List<ProjectIssues>();
        }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public string ProjectLabel { get; set; }
        public DateTime ProjectDueDate { get; set; }
        public string ProjectVersion { get; set; }
        [InverseProperty("IPProjectsProjectUser")]
        public ICollection<ProjectUser> ProjectsProjectUsers { get; set; }
        [InverseProperty("IPProjectProjectIssues")]
        public ICollection<ProjectIssues> IPProjectProjectIssues { get; set; }
        [ForeignKey("IPCompanyProjects")]
        public int CompanyID { get; set; }
        public virtual Company IPCompanyProjects { get; set; }
    }
}
