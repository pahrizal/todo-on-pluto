using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TodoApi.Models
{
    public class Todo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid TodoId { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

        [ConcurrencyCheck]
        public int concurencyToken {get; set;}
    }
}