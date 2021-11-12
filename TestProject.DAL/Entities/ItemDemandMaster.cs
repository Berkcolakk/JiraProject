using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using TestProject.DAL.Entities.Base;

namespace TestProject.DAL.Entities
{
    public class ItemDemandMaster : EntityBase
    {
        [ForeignKey("Project")]
        public int ITEMDEMANDMASTER_PROJECT_ID { get; set; }

        [ForeignKey("User")]
        public int ITEMDEMANDMASTER_USER_ID { get; set; }

        public string ITEMDEMANDMASTER_DESC { get; set; }

        [ForeignKey("ParameterDetail_ItemDemandMaster_State")]
        public int ITEMDEMANDMASTER_STATE_ID { get; set; }

        public virtual Project Project { get; set; }

        public bool ITEMDEMANDMASTER_ITEMCONFIRMATION { get; set; }

        public virtual User User { get; set; }

        public virtual ParameterDetail ParameterDetail_ItemDemandMaster_State { get; set; }

        public virtual List<ItemDemandDetail> ItemDemandDetails { get; set; }
    }
}