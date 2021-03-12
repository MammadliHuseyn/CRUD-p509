using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _031121CRUD.Models;
using Microsoft.AspNetCore.Mvc;

namespace _031121CRUD.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EmployeeController : Controller
    {
        private readonly CrudDbContext _context;
        public EmployeeController(CrudDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Employees.Add(employee);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(employee);
        }

        public IActionResult Delete(int? id)
        {
            if (id != null || _context.Employees.Any(x => x.Id == id))
            {
                Employee emp = _context.Employees.Find(id);
                _context.Employees.Remove(emp);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return NotFound();
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id != null || _context.Employees.Any(x => x.Id == id))
            {
                Employee emp = _context.Employees.Find(id);
                return View(emp);
            }

            return View("Index", "Home");
        }

        [HttpPost]
        public IActionResult Edit(Employee emp)
        {
            if (emp != null && ModelState.IsValid && _context.Employees.Any(x => x.Id == emp.Id))
            {
                _context.Update(emp);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(emp);
        }
    }
}
