using System;
using System.Collections.Generic;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NewsSite_v1._1.Models
{
    public class ApplicationDbContext1 : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext1()
            : base("DefaultConnection2")
        {

        }

        public System.Data.Entity.DbSet<NewsSite_v1._1.Models.MailRecipient> MailRecipients { get; set; }
    }
}