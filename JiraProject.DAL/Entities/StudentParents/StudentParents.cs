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
        [ForeignKey("StudentParents_Student")]
        public int StudentID { get; set; }
        public Student Student { get; set; }
        [ForeignKey("StudentParents_Parent")]
        public int ParentID { get; set; }
        public Parent Parent { get; set; }
    }
}
