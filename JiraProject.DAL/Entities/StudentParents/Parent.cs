using JiraProject.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraProject.DAL.Entities.StudentParents
{
    public class Parent : EntityBase
    {
        public string NameSurname { get; set; }
        public string Identity { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int BirthPlace { get; set; }
        [InverseProperty("StudentParents_Parent")]
        public virtual ICollection<StudentParents> StudentParents { get; set; }
    }
}
