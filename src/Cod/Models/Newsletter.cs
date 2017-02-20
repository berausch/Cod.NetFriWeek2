using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cod.Models
{
    [Table("Newsletters")]
    public class Newsletter
    {
        [Key]
        public int NewsletterId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
