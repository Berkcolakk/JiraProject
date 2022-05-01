using System;

namespace TestProject.DAL.Entities.Base
{
    public class EntityBase
    {
        public int ID { get; set; }

        public DateTime CrtDate { get; set; }

        public int CrtUserID { get; set; }

        public string CrtUserIP { get; set; }

        public DateTime UpdDate { get; set; }

        public int UpdUserID { get; set; }

        public string UpdUserIP { get; set; }

        public string MachineName { get; set; }

        public bool IsActive { get; set; }
    }
}