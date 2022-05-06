using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JiraProject.DAL.Entities.Base
{
    public class EntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public DateTime? CrtDate { get; set; } = DateTime.Now;
        public int? CrtUserID { get; set; } = 0;
        public string CrtUserIP { get; set; } = String.Empty;
        public DateTime? UpdDate { get; set; } = DateTime.Now;
        public int? UpdUserID { get; set; } = 0;
        public string UpdUserIP { get; set; } = String.Empty;
        public string MachineName { get; set; } = String.Empty;
        public bool IsActive { get; set; } = true;
    }
}