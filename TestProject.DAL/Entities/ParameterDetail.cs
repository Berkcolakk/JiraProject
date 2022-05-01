using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.DAL.Entities.Base;

namespace TestProject.DAL.Entities
{
    public class ParameterDetail : EntityBase
    {
        [ForeignKey("ParameterMasterID")]
        public int ParameterMasterID { get; set; }

        public string Name { get; set; }
        public string Desc { get; set; }
        public string Value1 { get; set; }
        public string Value2 { get; set; }
        public string Value3 { get; set; }

        //[InverseProperty("ParameterDetailMenuNameList")]
        //public virtual List<Menu> MenuNameList { get; set; }
    }
}
