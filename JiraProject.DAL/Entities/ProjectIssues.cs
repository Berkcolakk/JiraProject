using JiraProject.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraProject.DAL.Entities
{
    public class ProjectIssues : EntityBase
    {
        [ForeignKey(nameof(ProjectIssuespProjectID))]
        public int ProjectIssuespProjectID { get; set; }
        [ForeignKey(nameof(ProjectUsersID))]
        public int ProjectUsersID { get; set; }
        [ForeignKey(nameof(ProjectReporterID))]
        public int ProjectReporterID { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public int PriorityID { get; set; }
        public int LabelID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public int FixVersionID { get; set; }
        public string Attachment { get; set; }
        public int IssuesParentID { get; set; }
        public int FlagID { get; set; }
        public int IssueTypeID { get; set; }
    }
}
