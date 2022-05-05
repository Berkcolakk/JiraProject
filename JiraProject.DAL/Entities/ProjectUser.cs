using JiraProject.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraProject.DAL.Entities
{
    public class ProjectUser : EntityBase
    {
        public int UserID { get; set; }
        public int ProjectID { get; set; }
    }
}
