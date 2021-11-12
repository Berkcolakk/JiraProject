using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using TestProject.DAL.Entities.Base;

namespace TestProject.DAL.Entities
{
    public class Contract : EntityBase
    {
        public string CONTRACT_NAME { get; set; }

        public double CONTRACT_TOTALPRICE { get; set; }

        public double CONTRACT_PRICECUTRATE { get; set; }

        [ForeignKey("MasterContract")]
        public int? CONTRACT_MASTER_ID { get; set; }

        public DateTime CONTRACT_DATE { get; set; }

        public virtual Contract MasterContract { get; set; }

        public virtual List<Project> Projects { get; set; }
    }
}