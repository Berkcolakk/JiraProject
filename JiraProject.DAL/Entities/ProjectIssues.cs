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

        [ForeignKey("IPProjectProjectIssues")]
        public int ProjectIssuespProjectID { get; set; }
        public virtual Projects IPProjectProjectIssues { get; set; }
        [ForeignKey("IPUserProjectIssuesUser")]
        public int ProjectUsersID { get; set; }
        public virtual User IPUserProjectIssuesUser { get; set; }

        [ForeignKey("IPUserProjectIssuesReporter")]
        public int ProjectReporterID { get; set; }
        public virtual User IPUserProjectIssuesReporter { get; set; }
    }
}
