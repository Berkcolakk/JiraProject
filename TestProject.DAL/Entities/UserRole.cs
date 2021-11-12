using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using TestProject.DAL.Entities.Base;

namespace TestProject.DAL.Entities
{
    public class UserRole : EntityBase
    {
        [ForeignKey("User")]
        public int USERROLE_USER_ID { get; set; }

        [ForeignKey("ParameterDetail_UserRole_Role")]
        public int USERROLE_ROLE_ID { get; set; }

        public virtual User User { get; set; }

        public virtual ParameterDetail ParameterDetail_UserRole_Role { get; set; }
    }
}