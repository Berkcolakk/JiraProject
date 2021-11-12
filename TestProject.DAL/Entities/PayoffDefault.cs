using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using TestProject.DAL.Entities.Base;

namespace TestProject.DAL.Entities
{
    public class PayoffDefault : EntityBase
    {
        public string PAYOFFDEFAULT_DEF1 { get; set; }
        public string PAYOFFDEFAULT_DEF2 { get; set; }
        public string PAYOFFDEFAULT_DEF3 { get; set; }
        public string PAYOFFDEFAULT_DEF4 { get; set; }
        public string PAYOFFDEFAULT_DEF5 { get; set; }
        public string PAYOFFDEFAULT_DEF6 { get; set; }
        public string PAYOFFDEFAULT_DEF7 { get; set; }
        public string PAYOFFDEFAULT_DEF8 { get; set; }
        public string PAYOFFDEFAULT_DEF9 { get; set; }
        public string PAYOFFDEFAULT_DEF10 { get; set; }
        public string PAYOFFDEFAULT_DEF11 { get; set; }
        public string PAYOFFDEFAULT_DEF12 { get; set; }
        public string PAYOFFDEFAULT_DEF13 { get; set; }
        public string PAYOFFDEFAULT_DEF14 { get; set; }
        public string PAYOFFDEFAULT_DEF15 { get; set; }
        public string PAYOFFDEFAULT_DEF16 { get; set; }
        public string PAYOFFDEFAULT_DEF17 { get; set; }
        public string PAYOFFDEFAULT_DEF18 { get; set; }
        public string PAYOFFDEFAULT_DEF19 { get; set; }
        public string PAYOFFDEFAULT_DEF20 { get; set; }

        [ForeignKey("PayoffMaster")]
        public int PAYOFFDEFAULT_PAYOFFMASTER_ID { get; set; }

        public virtual PayoffMaster PayoffMaster { get; set; }


    }
}