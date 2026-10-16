using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyManagementSystem.web.Models
{
    public class MedicineBatch
    {
        public int Id { get; set; }
        public string BatchNumber { get; set; }
        public DateTime ManufactureDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int Quantity { get; set; }
        public Medicine Medicine { get; set; }
    }
}
