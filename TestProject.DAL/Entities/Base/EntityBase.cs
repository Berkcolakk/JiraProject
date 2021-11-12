using System;

namespace TestProject.DAL.Entities.Base
{
    public class EntityBase
    {
        public int ID { get; set; }

        public DateTime CREATED_DATE { get; set; }

        public int CREATED_USER_ID { get; set; }

        public string CREATED_USER_IP { get; set; }

        public string MACHINENAME_MACHINEIDENTITY { get; set; }

        public bool ISACTIVE { get; set; }
    }
}
