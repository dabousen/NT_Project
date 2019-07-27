using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NT_Project.Models
{
    public class Account
    {
        [Required]
        [Key]
        public int AccID { get; set; }


        [Required]
        public string Title { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string PhotoPath { get; set; }

        [Required]
        public DateTime BirthDay { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Gender { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}