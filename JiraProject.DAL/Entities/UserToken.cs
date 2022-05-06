using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using JiraProject.DAL.Entities.Base;

namespace JiraProject.DAL.Entities
{
    public class UserToken : EntityBase
    {
        public string Token { get; set; }
        public DateTime ExpireDate { get; set; }
        [ForeignKey("IPUserTokenUser")]
        public int UserID { get; set; }
        public virtual User IPUserTokenUser { get; set; }
    }
}