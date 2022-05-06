using JiraProject.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraProject.DAL.Entities
{
    public class ProjectUser : EntityBase
    {
        [ForeignKey("IPUserProjectUser")]
        public int UserID { get; set; }
        public virtual User IPUserProjectUser { get; set; }
        [ForeignKey("IPProjectsProjectUser")]
        public int ProjectID { get; set; }
        public virtual Projects IPProjectsProjectUser { get; set; }
    }
}
