using System.ComponentModel.DataAnnotations.Schema;

namespace TestProject.DAL.Entities
{
    public class MenuRole
    {
        [ForeignKey("MenuID")]
        public int MenuID { get; set; }
        [ForeignKey("UserRoleID")]
        public int UserRoleID { get; set; }
        public string Desc { get; set; }
    }
}
