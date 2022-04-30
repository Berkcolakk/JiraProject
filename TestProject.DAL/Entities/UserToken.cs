using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.DAL.Entities.Base;

namespace TestProject.DAL.Entities
{
    public class UserToken : EntityBase
    {
        public string Token { get; set; }
        public DateTime ExpireDate { get; set; }
        public int UserID { get; set; }
    }
}
