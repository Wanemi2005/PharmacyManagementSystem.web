using Microsoft.EntityFrameworkCore;
using PharmacyManagementSystem.web.Models;

namespace PharmacyManagementSystem.web.Data
{
    public class PharmacyDbContext : DbContext
    {
        public PharmacyDbContext(DbContextOptions<PharmacyDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Medicine> Medicines { get; set; }

        public DbSet<MedicineBatch> MedicineBatches { get; set; }

        public DbSet<Prescription> Prescriptions { get; set; }
    }
}