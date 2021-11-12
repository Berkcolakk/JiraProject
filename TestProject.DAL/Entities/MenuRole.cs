using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using TestProject.DAL.Entities.Base;

namespace TestProject.DAL.Entities
{
    public class MenuRole : EntityBase
    {
        [ForeignKey("ParameterDetail_MenuRole_Menu")]
        public int MENUROLE_MENU_ID { get; set; }

        [ForeignKey("ParameterDetail_MenuRole_Role")]
        public int MENUROLE_ROLE_ID { get; set; }

        public virtual ParameterDetail ParameterDetail_MenuRole_Menu { get; set; }

        public virtual ParameterDetail ParameterDetail_MenuRole_Role { get; set; }
    }
}