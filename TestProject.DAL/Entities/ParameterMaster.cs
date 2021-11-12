using System.Collections.Generic;
using TestProject.DAL.Entities.Base;

namespace TestProject.DAL.Entities
{
    public class ParameterMaster : EntityBase
    {
        public string PARAMETERMASTER_NAME { get; set; }

        public bool PARAMETERMASTER_ISEDITABLE { get; set; } = true;

        public virtual List<ParameterDetail> ParameterDetails { get; set; }
    }
}