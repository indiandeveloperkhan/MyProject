using Microsoft.AspNetCore.Mvc;
using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Controllers
{
    public class ValidationController : Controller
    {
        private DataContext db = new DataContext();

        public IActionResult Index()
        {
            ViewBag.Validation = db.validation.ToList();
            return View();
        }
        public IActionResult Login()
        {
            
            return View();
        }
        public IActionResult Page1()
        {

            return View();
        }
        public IActionResult FacultyRegistration()
        {

            return View();
        }

        Facultydb dbop = new Facultydb();
        public IActionResult FacultyPersonal()
        {

            return View();
        }
        [HttpPost]
        public IActionResult FacultyPersonal([Bind] Faculty_Personal Fac)
        {
            try
            {
                if (ModelState.IsValid)
                {
                   string res = dbop.Saverecord(Fac);
                    TempData["msg"] = res;
                }

            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
            }
            
            return View();
        }

        Skilldb dop = new Skilldb();

        public IActionResult FacultySkill()
        {

            return View();
        }

        [HttpPost]
        public IActionResult FacultySkill([Bind] Skill Fac)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    string res = dop.Saverecord(Fac);
                    TempData["msg"] = res;
                }

            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
            }

            return View();
        }
        public IActionResult ModuleRegisteration()
        {

            return View();
        }
        
             public IActionResult Batch1()
        {

            return View();
        }
        public IActionResult BatchAllocation()
        {

            return View();
        }
    
                    public IActionResult BatchSearch()
        {

            return View();
        }
        public IActionResult BatchUpdateScreen()
        {

            return View();
        }
        
        public IActionResult ReportManagement()
        {

            return View();
        }
        
        public IActionResult ReportSubmission()
        {

            return View();
        }
        
        public IActionResult Award()
        {

            return View();
        }
        
        public IActionResult FacultyScreen()
        {

            return View();
        }
        
        public IActionResult BatchScreen()
        {

            return View();
        }
        
        public IActionResult submit()
        {

            return View();
        }
    }
}
