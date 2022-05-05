using System.ComponentModel.DataAnnotations.Schema;
using JiraProject.DAL.Entities.Base;

namespace JiraProject.DAL.Entities
{
    public class MenuRole : EntityBase
    {
        [ForeignKey("MenuID")]
        public int MenuID { get; set; }

        [ForeignKey("UserRoleID")]
        public int UserRoleID { get; set; }

        public string Desc { get; set; }
    }
}