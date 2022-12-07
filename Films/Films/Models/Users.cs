using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Films.Models
{
    public class Users
    {

        [Key]
        public int ID { get; set; }

        public int Admin { get; set; }

        [Required]
        public string UserName { get; set; }

        public string BirthDay { get; set; }

        public string ProfilePic { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public UsersLogins UsersLogins { get; set; }
    }
}
