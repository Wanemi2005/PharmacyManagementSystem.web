using Microsoft.AspNetCore.Mvc;
using PharmacyManagementSystem.web.Data;

namespace PharmacyManagementSystem.web.Controllers
{
    public class MedicineController : Controller
    {
        private readonly PharmacyDbContext _context;

        public MedicineController(PharmacyDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var medicines = _context.Medicines.ToList();

            return View(medicines);
        }
    }
}