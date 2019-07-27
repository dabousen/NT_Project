using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NT_Project.Models
{
    public class Friend
    {
        [Key]
        [Column(Order = 1)]
        public int FirstID { get; set; }
        [Key]
        [Column(Order = 2)]
        public int SecondID { get; set; }




    }
}