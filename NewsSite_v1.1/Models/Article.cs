namespace NewsSite_v1._1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Article")]
    public partial class Article
    {
        public Article()
        {
            PostTime = DateTime.Now;
        }

        [Key]
        [Display(Name = "Article ID")]
        public int AId { get; set; }

        [Display(Name = "Journalist ID")]
        public int JId { get; set; }

        [DisplayName("Article Title")]
        [Required(ErrorMessage = "Please enter article title")]
        [StringLength(100)]
        public string Title { get; set; }

        [DisplayName("Post Time")]
        [Column(TypeName = "DateTime")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime PostTime { get; set; }
        
        [DisplayName("Category")]
        [Required(ErrorMessage = "Please enter category of the article")]
        [StringLength(20)]
        public string Category { get; set; }

        [DisplayName("Content")]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Please enter content")]
        public string Content { get; set; }

        public virtual Journalist Journalist { get; set; }
    }
}
