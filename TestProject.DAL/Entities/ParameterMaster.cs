using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JiraProject.DAL.Entities.Base;

namespace JiraProject.DAL.Entities
{
    public class ParameterMaster : EntityBase
    {
        public ParameterMaster()
        {
            ParameterDetail = new List<ParameterDetail>();
        }
        public string MasterName { get; set; }
        public virtual ICollection<ParameterDetail> ParameterDetail { get; set; }
    }
}
