using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using TestProject.DAL.Entities.Base;

namespace TestProject.DAL.Entities
{
    public class Company : EntityBase
    {
        public string COMPANY_TAXNAME { get; set; }

        public string COMPANY_TAXNUMBER { get; set; }

        public string COMPANY_COMPANY_NAME { get; set; }

        public string COMPANY_PHONE { get; set; }

        public string COMPANY_FAX { get; set; }

        public string COMPANY_ADRESS { get; set; }

        public bool COMPANY_SUBCONTRACTOR { get; set; }

        [ForeignKey("ParameterDetail_Company_Store")]
        public int? COMPANY_STORE_ID { get; set; }

        [InverseProperty("Company")]
        public virtual List<StockMaster> StockMasters { get; set; }

        [InverseProperty("SubCompany")]
        public virtual List<StockMaster> Sub_StockMasters { get; set; }

        public virtual List<Project> Projects { get; set; }

        public virtual ParameterDetail ParameterDetail_Company_Store { get; set; }
    }
}