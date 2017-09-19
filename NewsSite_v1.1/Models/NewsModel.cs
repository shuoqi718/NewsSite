namespace NewsSite_v1._1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class NewsModel : DbContext
    {
        public NewsModel()
            : base("name=NewsModel")
        {
        }

        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Journalist> Journalists { get; set; }

        public virtual DbSet<EmailFormModel> EmailForm { get; set; }

        
    }
}
