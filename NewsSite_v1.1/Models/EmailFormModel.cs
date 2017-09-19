using System.ComponentModel.DataAnnotations;
namespace NewsSite_v1._1.Models
{
    public class EmailFormModel
    {
        [Required]
        public string Message { get; set; }
    }
}