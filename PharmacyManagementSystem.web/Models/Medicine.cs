using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyManagementSystem.web.Models
{
    public class Medicine
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public MedicineCategory? Category { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int QuantityInStock { get; set; }

        public int ReorderLevel { get; set; }

        public string GenericName { get; set; } = string.Empty;
        public decimal PurchasePrice { get; set; }
        public decimal SellingPrice { get; set; }
        public int Barcode { get; set; }
        public string RequiredPrescription { get; set; } = string.Empty;
    }

}


       