using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NT_Project.Models
{
    public class Interaction
    {
        public int ActionType { get; set; } //1 -> Like , 2 -> Dislike
        public DateTime Date { get; set; }

        [Key]
        [Column(Order = 1)]
        public int PostID { get; set; }
        [Key]
        [Column(Order = 2)]
        public int AccountID { get; set; }

        public virtual Post Post { get; set; }
        public virtual Account Account { get; set; }


    }
}