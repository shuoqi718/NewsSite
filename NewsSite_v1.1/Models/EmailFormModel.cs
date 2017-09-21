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

        [Display(Name = "Check")]
        [Required]
        public bool check { get; set; }

        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }


        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }


        public string Message { get; set; }
    }
}