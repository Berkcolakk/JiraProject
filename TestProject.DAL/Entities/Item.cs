using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using TestProject.DAL.Entities.Base;

namespace TestProject.DAL.Entities
{
    public class Item : EntityBase
    {
        public string ITEM_NAME { get; set; }

        public string ITEM_CODE { get; set; }

        public string ITEM_ASSM_CODE { get; set; }

        public string ITEM_DEASSM_CODE { get; set; }

        public string ITEM_DEASSMDE_CODE { get; set; }

        public string ITEM_DESCRIPTION { get; set; }

        [ForeignKey("ParameterDetail_Item_Unit")]
        public int ITEM_UNIT_ID { get; set; }

        [ForeignKey("ParameterDetail_Item_Group")]
        public int ITEM_GROUP_ID { get; set; }

        public string ITEM_REF_CODE { get; set; }

        public virtual ParameterDetail ParameterDetail_Item_Unit { get; set; }

        public virtual ParameterDetail ParameterDetail_Item_Group { get; set; }

        public virtual List<ProjectExplore> ProjectExplores { get; set; }

        public virtual List<ItemDemandDetail> ItemDemandDetails { get; set; }

        public virtual List<PayoffDetail> PayoffDetails { get; set; }
    }
}