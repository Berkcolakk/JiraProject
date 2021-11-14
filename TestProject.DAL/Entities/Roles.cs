using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using TestProject.DAL.Entities.Base;

namespace TestProject.DAL.Entities
{
    public class Roles : EntityBase
    {
        public Roles()
        {
            UserRole = new List<UserRole>();
        }
        public string Name { get; set; }
        public string Desc { get; set; }
        [ForeignKey("CompanyID")]
        public string CompanyID { get; set; }

        public virtual ICollection<UserRole> UserRole { get; set; }
    }
}
