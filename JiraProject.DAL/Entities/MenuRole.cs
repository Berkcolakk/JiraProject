using System.ComponentModel.DataAnnotations.Schema;
using JiraProject.DAL.Entities.Base;

namespace JiraProject.DAL.Entities
{
    public class MenuRole : EntityBase
    {
        [ForeignKey("IPMenuMenuRole")]
        public int MenuID { get; set; }
        public virtual Menu IPMenuMenuRole { get; set; }

        [ForeignKey("IPRolesMenuRole")]
        public int UserRoleID { get; set; }
        public virtual Roles IPRolesMenuRole { get; set; }
        public string Desc { get; set; }
    }
}