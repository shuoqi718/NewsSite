namespace NewsSite_v1._1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Journalist")]
    public partial class Journalist
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Journalist()
        {
            Articles = new HashSet<Article>();
        }

        [Key]
        [Display(Name = "Journalist ID")]
        public int JId { get; set; }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "Please enter first name")]
        [StringLength(50)]
        public string FName { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Please enter last name")]
        [StringLength(50)]
        public string LName { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Please enter email address")]
        [DataType(DataType.EmailAddress)]
        [StringLength(50)]
        public string Email { get; set; }

        [DisplayName("Phone Number")]
        [Required(ErrorMessage = "Please enter phone number")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [DisplayName("Date of Birth")]
        [Required(ErrorMessage = "Please choose date of birth")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Column(TypeName = "date")]
        public DateTime DoB { get; set; }

        [DisplayName("Country")]
        [Required(ErrorMessage = "Please enter country")]
        [StringLength(20)]
        public string Country { get; set; }

        [DisplayName("Company")]
        [Required(ErrorMessage = "Please enter company name")]
        [StringLength(50)]
        public string Company { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Article> Articles { get; set; }
    }
}
