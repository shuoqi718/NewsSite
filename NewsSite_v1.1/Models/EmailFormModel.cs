using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace NewsSite_v1._1.Models
{
    public class EmailFormModel
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public string Message { get; set; }
    }
}