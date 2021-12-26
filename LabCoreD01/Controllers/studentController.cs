using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LabCoreD01.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
//using System.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace LabCoreD01.Controllers
{
    public class studentController : Controller
    {
        ITIContext db;
        public studentController(ITIContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            List<Department> depts = db.Departments.ToList();
            ViewBag.depts = depts;
            return View(db.Students.ToList());
        }
        public IActionResult create()
        {
            List<Department> d = db.Departments.ToList();
            SelectList dept = new SelectList(d, "DeptId", "DeptName");
            ViewBag.dept = dept;
            return View();
        }
        [HttpPost]
        public IActionResult create(Student s)
        {
            if (ModelState.IsValid)
            {
                db.Students.Add(s);
                db.SaveChanges();
                return RedirectToAction("index");
            }
            else
            {
                List<Department> d = db.Departments.ToList();
                SelectList dept = new SelectList(d, "DeptId", "DeptName");
                ViewBag.dept = dept;
                return View();
            }
        }
        public IActionResult delete(int id)
        {
            Student s = db.Students.Where(n => n.StId == id).SingleOrDefault();
            db.Students.Remove(s);
            db.SaveChanges();
            return RedirectToAction("index");

        }
        public IActionResult update(int id)
        {
            Student s = db.Students.Where(n => n.StId == id).SingleOrDefault();
            List<Department> d = db.Departments.ToList();
            SelectList dept = new SelectList(d, "DeptId", "DeptName");
            ViewBag.dept = dept;
            return View();

        }
        [HttpPost]
        public IActionResult update(Student s)
        {
            if (ModelState.IsValid)
            {
                db.Entry(s).State =(EntityState)System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("index");
            }
            else
            {
                List<Department> d = db.Departments.ToList();
                SelectList dept = new SelectList(d, "DeptId", "DeptName");
                ViewBag.dept = dept;
                return View();
            }
        }
    }
}
