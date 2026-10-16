using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyManagementSystem.web.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
