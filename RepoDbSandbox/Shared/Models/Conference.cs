using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RepoDbSandbox.Shared.Models
{
    [Table("Conference")]
    public class Conference 
    {
        public int ConfId { get; set; }
        [Column("ConfName")]
        public string Name { get; set; }

    }
}
