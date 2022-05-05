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
            ProjectUsersID = new List<ProjectUser>();
            ProjectIssuespProjectID = new List<ProjectIssues>();
        }
        public string ProjectName { get; set; }
        public string ProjectVersion { get; set; }
        public ICollection<ProjectUser> ProjectUsersID { get; set; }
        //[InverseProperty(nameof(ProjectIssuespProjectID))]
        public ICollection<ProjectIssues> ProjectIssuespProjectID { get; set; }

    }
}
