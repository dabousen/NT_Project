using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace NT_Project.Models
{
    public class Post
    {
        [Key]
        public int PostID { get; set; }
        public int AccountID { get; set; }
        public string Text { get; set; }
        public string ContentPath { get; set; }

        public virtual Account Account { get; set; }
        public virtual ICollection<Interaction> Interactions { get; set; }
    }
}