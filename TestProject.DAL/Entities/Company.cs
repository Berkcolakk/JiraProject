using System.Collections.Generic;
using TestProject.DAL.Entities.Base;

namespace TestProject.DAL.Entities
{
    public class Company : EntityBase
    {
        public Company()
        {
            Roles = new List<Roles>();
            User = new List<User>();
            UserRole = new List<UserRole>();
        }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Type { get; set; }
        public string RegistrationNumber { get; set; }
        public virtual ICollection<Roles> Roles { get; set; }
        public virtual ICollection<User> User { get; set; }
        public virtual ICollection<UserRole> UserRole { get; set; }
    }
}
