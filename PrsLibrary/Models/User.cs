using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrsLibrary.Models {

    public class User {

        //Properties
        public int Id { get; set; }
        [Required, StringLength(30)]
        public string UserName { get; set; }
        [Required, StringLength(30)]
        public string Password { get; set; }
        [Required, StringLength(30)]
        public string Firstname { get; set; }
        [Required, StringLength(30)]
        public string Lastname { get; set; }
        [StringLength(12)]
        public string Phone { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        public bool IsReviewer { get; set; }
        public bool IsAdmin { get; set; }

        //constructor
        public User() { }

    }
}
