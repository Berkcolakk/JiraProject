using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using TestProject.DAL.Entities.Base;

namespace TestProject.DAL.Entities
{
    public class User : EntityBase
    {
        public User()
        {
            UserRole = new List<UserRole>();
            UserToken = new List<UserToken>();
        }
        public string Email { get; set; }

        public string Password { get; set; }

        public string UserName { get; set; }

        public string Phone { get; set; }
        [ForeignKey("CompanyID")]
        public int CompanyID { get; set; }

        public virtual ICollection<UserRole> UserRole { get; set; }
        public virtual ICollection<UserToken> UserToken { get; set; }
    }
}