using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _031121CRUD.Models;
using Microsoft.AspNetCore.Mvc;

namespace _031121CRUD.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly CrudDbContext _context;
        public HomeController(CrudDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Employee> model = _context.Employees.ToList();
            return View(model);
        }
    }
}
