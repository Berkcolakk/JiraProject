using System.ComponentModel.DataAnnotations.Schema;
using TestProject.DAL.Entities.Base;

namespace TestProject.DAL.Entities
{
    public class StockDetail : EntityBase
    {
        [ForeignKey("Item")]
        public int STOCKDETAIL_ITEM_ID { get; set; }

        [ForeignKey("StockMaster")]
        public int STOCKDETAIL_MASTER_ID { get; set; }

        public string STOCKDETAIL_BARCODE_ID { get; set; }

        public double STOCKDETAIL_QUANTITY { get; set; }

        public double? STOCKDETAIL_PRIVATEVALUE1 { get; set; }

        public double? STOCKDETAIL_PRIVATEVALUE2 { get; set; }

        [ForeignKey("ParameterDetail_StockDetail_Store")]
        public int STOCKDETAIL_STORE_ID { get; set; }

        [ForeignKey("ParameterDetail_StockDetail_Rack")]
        public int STOCKDETAIL_RACK_ID { get; set; }

        public string STOCKDETAIL_DESCRIPTION { get; set; }

        public string STOCKDETAIL_SERIALNUMBER { get; set; }

        public int? STOCKDETAIL_REF_ID { get; set; }

        public string STOCKDETAIL_REF_LINK { get; set; }

        public virtual StockMaster StockMaster { get; set; }

        public virtual Item Item { get; set; }

        public virtual ParameterDetail ParameterDetail_StockDetail_Rack { get; set; }

        public virtual ParameterDetail ParameterDetail_StockDetail_Store { get; set; }
    }
}