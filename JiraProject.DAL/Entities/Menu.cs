using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using JiraProject.DAL.Entities.Base;

namespace JiraProject.DAL.Entities
{
    public class Menu : EntityBase
    {
        public Menu()
        {
            IPMenuMenuRole = new List<MenuRole>();
        }

        public string Name { get; set; }

        public string Icon { get; set; }

        public string Color { get; set; }

        public string Desc { get; set; }

        [ForeignKey("IPCompanyMenu")]
        public virtual int CompanyID { get; set; }
        public virtual Company IPCompanyMenu { get; set; }
        [InverseProperty("IPMenuMenuRole")]
        public virtual ICollection<MenuRole> IPMenuMenuRole { get; set; }
    }
}