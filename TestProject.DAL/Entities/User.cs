using System.Collections.Generic;
using TestProject.DAL.Entities.Base;

namespace TestProject.DAL.Entities
{
    public class User : EntityBase
    {
        public string USER_ACCESSNAME { get; set; }

        public string USER_ACCESSPASSWORD { get; set; }

        public string USER_NAME_SURNAME { get; set; }

        public string USER_EMAIL { get; set; }

        public virtual List<ProjectManager> ProjectManagers { get; set; }

        public virtual List<ItemDemandMaster> ItemDemandMasters { get; set; }
    }
}