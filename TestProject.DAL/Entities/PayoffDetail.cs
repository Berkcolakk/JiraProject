using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using TestProject.DAL.Entities.Base;

namespace TestProject.DAL.Entities
{
    public class PayoffDetail : EntityBase
    {
        [ForeignKey("ParameterDetail_Payoff_ItemType")]
        public int PAYOFFDETAIL_ITEMTYPE_ID { get; set; }

        [ForeignKey("Item")]
        public int PAYOFFDETAIL_ITEM_ID { get; set; }

        public double PAYOFFDETAIL_UNITPRICE { get; set; }

        public double PAYOFFDETAIL_INCLUDEPRICE { get; set; }

        public virtual Item Item { get; set; }
        public virtual ParameterDetail ParameterDetail_Payoff_ItemType { get; set; }

    }
}