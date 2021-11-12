using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using TestProject.DAL.Entities.Base;

namespace TestProject.DAL.Entities
{
    public class ParameterDetail : EntityBase
    {
        public string PARAMETERDETAIL_NAME { get; set; }

        public string PARAMETERDETAIL_VALUE1 { get; set; }

        public string PARAMETERDETAIL_VALUE2 { get; set; }

        public string PARAMETERDETAIL_VALUE3 { get; set; }

        [ForeignKey("ParameterMaster")]
        public int PARAMETERDETAIL_MASTER_ID { get; set; }

        public virtual ParameterMaster ParameterMaster { get; set; }

        [InverseProperty("ParameterDetail_StockMaster_Type")]
        public virtual List<StockMaster> StockMaster_Types { get; set; }

        [InverseProperty("ParameterDetail_StockMaster_Store")]
        public virtual List<StockMaster> StockMaster_Stores { get; set; }

        [InverseProperty("ParameterDetail_StockMaster_SourceStore")]
        public virtual List<StockMaster> StockMaster_SourceStores { get; set; }

        [InverseProperty("ParameterDetail_Item_Unit")]
        public virtual List<Item> ParameterDetail_Unit { get; set; }

        [InverseProperty("ParameterDetail_Item_Group")]
        public virtual List<Item> ParameterDetail_Group { get; set; }

        [InverseProperty("ParameterDetail_StockDetail_Rack")]
        public virtual List<StockDetail> ParameterDetail_Rack { get; set; }

        [InverseProperty("ParameterDetail_Payoff_ItemType")]
        public virtual List<PayoffDetail> ParameterDetail_ItemType { get; set; }

        [InverseProperty("ParameterDetail_StockDetail_Store")]
        public virtual List<StockDetail> ParameterDetail_Store { get; set; }

        [InverseProperty("ParameterDetail_Project_ContractType")]
        public virtual List<Project> ParameterDetail_ContractType { get; set; }

        [InverseProperty("ParameterDetail_Project_State")]
        public virtual List<Project> ParameterDetail_State { get; set; }

        [InverseProperty("ParameterDetail_Project_ExploreState")]
        public virtual List<Project> ParameterDetail_ExploreState { get; set; }

        [InverseProperty("ParameterDetail_ItemDemandMaster_State")]
        public virtual List<ItemDemandMaster> ParameterDetail_ItemDemandMaster_State { get; set; }

        [InverseProperty("ParameterDetail_Company_Store")]
        public virtual List<Company> ParameterDetail_Company_Store { get; set; }

        [InverseProperty("ParameterDetail_MenuRole_Menu")]
        public virtual List<MenuRole> ParameterDetail_Menu { get; set; }

        [InverseProperty("ParameterDetail_MenuRole_Role")]
        public virtual List<MenuRole> ParameterDetail_Role { get; set; }

        [InverseProperty("ParameterDetail_UserRole_Role")]
        public virtual List<UserRole> ParameterDetail_UserRole { get; set; }
        
    }
}