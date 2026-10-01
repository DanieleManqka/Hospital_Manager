using Data_Hospital_Manager;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hospital_Manager.Controllers
{
    public class PatientController : Controller
    {
        private readonly HospitalDbContext context;
        public PatientController(HospitalDbContext dbcontext)
        {
           this.context = dbcontext; 
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<ActionResult> Index()
        {
            var patinets = await context.Patients
                .Include(p=>p.DoctorPatients).ThenInclude() 
        }
    }
}
