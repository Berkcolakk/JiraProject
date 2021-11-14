using System.Collections.Generic;
using TestProject.DAL.Entities.Base;

namespace TestProject.DAL.Entities
{
    public class User : EntityBase
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string UserName { get; set; }

        public string Phone { get; set; }
        public virtual List<ProjectManager> ProjectManagers { get; set; }

        public virtual List<ItemDemandMaster> ItemDemandMasters { get; set; }
    }
}