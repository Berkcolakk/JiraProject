using JiraProject.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraProject.DAL.Entities.StudentParents
{
    public class StudentParents : EntityBase
    {
        [ForeignKey("")]
        public int StudentID { get; set; }
        public int ParentID { get; set; }
    }
}
