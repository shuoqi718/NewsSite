using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsSite_v1._1.Models
{
    public class SelectRecipientEditorViewModel
    {
        public bool Selected { get; set; }
        public SelectRecipientEditorViewModel() { }
        public int MailRecipientId { get; set; }
        public string Email { get; set; }
        public string LastMailedDate { get; set; }
    }
}