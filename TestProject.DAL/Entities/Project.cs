using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using TestProject.DAL.Entities.Base;

namespace TestProject.DAL.Entities
{
    public class Project : EntityBase
    {
        public string PROJECT_NAME { get; set; }

        public string PROJECT_PYP_NO { get; set; }

        public string PROJECT_GROUP { get; set; }

        public string PROJECT_DESC { get; set; }

        public string PROJECT_EXPLOREDESC { get; set; }

        public int PROJECT_DAY { get; set; }

        public DateTime PROJECT_WORKORDERDATE { get; set; }

        public DateTime PROJECT_DELIVERYDATE { get; set; }

        public double PROJECT_EXPLOREPRICE { get; set; }

        public double PROJECT_OWNERPRICE { get; set; }

        public double PROJECT_CONSTRUCTORPRICE { get; set; }

        public double PROJECT_DISCOUNTEDPRICE { get; set; }

        public bool PROJECT_ISDELIVERYEXPLORE { get; set; } = false;

        [ForeignKey("Company")]
        public int PROJECT_COMPANY_ID { get; set; }

        [ForeignKey("Contract")]
        public int PROJECT_CONTRACT_ID { get; set; }

        [ForeignKey("ParameterDetail_Project_ContractType")]
        public int PROJECT_TYPE_ID { get; set; }

        [ForeignKey("ParameterDetail_Project_State")]
        public int PROJECT_STATE_ID { get; set; }

        [ForeignKey("ParameterDetail_Project_ExploreState")]
        public int PROJECT_EXPLORESTATE_ID { get; set; }

        public virtual ParameterDetail ParameterDetail_Project_ContractType { get; set; }

        public virtual ParameterDetail ParameterDetail_Project_State { get; set; }

        public virtual ParameterDetail ParameterDetail_Project_ExploreState { get; set; }

        public virtual Company Company { get; set; }

        public virtual Contract Contract { get; set; }

        public virtual List<ProjectExplore> ProjectExplores { get; set; }

        public virtual List<ProjectManager> ProjectManagers { get; set; }

        public virtual List<PayoffMaster> Payoffs { get; set; }
    }
}