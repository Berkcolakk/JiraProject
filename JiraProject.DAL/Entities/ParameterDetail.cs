using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JiraProject.DAL.Entities.Base;

namespace JiraProject.DAL.Entities
{
    public class ParameterDetail : EntityBase
    {
        [ForeignKey("ParameterMaster_Details")]
        public int ParameterMasterID { get; set; }
        public ParameterMaster ParameterMaster { get; set; }

        public string Name { get; set; }
        public string Desc { get; set; }
        public string Value1 { get; set; }
        public string Value2 { get; set; }
        public string Value3 { get; set; }

        //[InverseProperty("ParameterDetailMenuNameList")]
        //public virtual List<Menu> MenuNameList { get; set; }
    }
}
