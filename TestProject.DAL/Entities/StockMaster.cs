using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using TestProject.DAL.Entities.Base;

namespace TestProject.DAL.Entities
{
    public class StockMaster : EntityBase
    {
        [ForeignKey("ParameterDetail_StockMaster_Type")]
        public int STOCKMASTER_TYPE_ID { get; set; }

        [ForeignKey("ParameterDetail_StockMaster_Store")]
        public int STOCKMASTER_TARGETSTORE_ID { get; set; }

        [ForeignKey("ParameterDetail_StockMaster_SourceStore")]
        public int STOCKMASTER_SOURCESTORE_ID { get; set; }

        [ForeignKey("Company")]
        public int? STOCKMASTER_COMPANY_ID { get; set; }

        [ForeignKey("SubCompany")]
        public int? COMPANY_SUB_COMPANY_ID { get; set; }

        public string STOCKMASTER_WAYBILL_NO { get; set; }

        public string STOCKMASTER_WAYBILL_DATE { get; set; }

        public int? STOCKMASTER_REF_ID { get; set; }

        public string STOCKMASTER_REF_LINK { get; set; }

        public virtual List<StockDetail> StockDetails { get; set; }

        public virtual Company Company { get; set; }

        public virtual Company SubCompany { get; set; }

        public virtual ParameterDetail ParameterDetail_StockMaster_Type { get; set; }

        public virtual ParameterDetail ParameterDetail_StockMaster_Store { get; set; }

        public virtual ParameterDetail ParameterDetail_StockMaster_SourceStore { get; set; }
    }
}