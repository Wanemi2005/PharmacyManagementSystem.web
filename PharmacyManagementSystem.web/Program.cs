using PharmacyManagementSystem.Models;

User admin = new User
{
    Id = 1,
    Username = "admin",
    EmailAddress = "admin@pharmacy.com",
    Password = "password123",
    Role = "Admin"
};

User pharmacist = new User
{
    Id = 2,
    Username = "grace",
    EmailAddress = "grace@pharmacy.com",
    Password = "password123",
    Role = "Pharmacist"
};

Console.WriteLine(admin.Role);

Console.WriteLine(pharmacist.Role);