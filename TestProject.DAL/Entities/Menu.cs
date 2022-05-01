using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using TestProject.DAL.Entities.Base;

namespace TestProject.DAL.Entities
{
    public class Menu : EntityBase
    {
        public Menu()
        {
            Roles = new List<Roles>();
        }

        public string Name { get; set; }

        public string Icon { get; set; }

        public string Color { get; set; }

        public string Desc { get; set; }

        [ForeignKey("CompanyID")]
        public int CompanyID { get; set; }

        public virtual ICollection<Roles> Roles { get; set; }
    }
}