using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyManagementSystem.web.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public decimal Salary { get; set; }

        public User Account { get; set; }

    }
}
