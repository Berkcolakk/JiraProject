using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using TestProject.DAL.Entities.Base;

namespace TestProject.DAL.Entities
{
    public class PayoffControl : EntityBase
    {
        public string PAYOFFCONTROL_LB { get; set; }
        public string PAYOFFCONTROL_PYP { get; set; }
        public string PAYOFFCONTROL_SAP { get; set; }
        public string PAYOFFCONTROL_ITEMNAME { get; set; }
        public string PAYOFFCONTROL_UNIT { get; set; }
        public double PAYOFFCONTROL_TENSIZUP { get; set; }
        public double PAYOFFCONTROL_TENUP { get; set; }
        public double PAYOFFCONTROL_QUANTITY { get; set; }
        public double PAYOFFCONTROL_TOTALTENUP { get; set; }
        public double PAYOFFCONTROL_TOTALTENSIZUP { get; set; }

        public int PAYOFFCONTROL_TYPE_ID { get; set; }

        [ForeignKey("PayoffMaster")]
        public int PAYOFFCONTROL_PAYOFFMASTER_ID { get; set; }

        public virtual PayoffMaster PayoffMaster { get; set; }
    }
}