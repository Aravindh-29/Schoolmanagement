using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SchoolManagement.Controllers
{
    public class StudentController : Controller
    {
        private readonly SchoolDbContext _context;
        public StudentController(SchoolDbContext context) {
            _context = context;
        }
        public IActionResult Index()
        {
            var students = _context.Students.ToList();
            return View(students);
        }
    }
}
