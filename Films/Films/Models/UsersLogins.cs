using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Films.Models
{
    [Keyless]
    public class UsersLogins
    {
        public int ID { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }

        public Users User { get; set; }
    }
}
