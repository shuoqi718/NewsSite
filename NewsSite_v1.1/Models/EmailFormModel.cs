using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NewsSite_v1._1.Models
{
    public class EmailFormModel
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public List<bool> checkList { get; set; }

        [Required]
        public List<string> Username { get; set; }

        [Required]
        public List<string> Email { get; set; }

        [Required]
        public string Message { get; set; }
    }
}