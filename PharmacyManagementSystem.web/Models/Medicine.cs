using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyManagementSystem.web.Models
{
    public class Medicine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int QuantityInStock { get; set; }

        public int ReorderLevel { get; set; }
    }

}


       