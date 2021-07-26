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
        

        public IActionResult Index()
        {
            
            return View();
        }

        Logi dock = new Logi();
        public IActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Login([Bind] Logino ad)
        {
            int res = dock.LoginCheck(ad);
            if (res == 1)
            {
                TempData["msg"] = "Welcome To Personalized Window.";
              
            }
            else
            {
                TempData["msg"] = "User id or Password is wrong:";
            }
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

        Moduledb dc = new Moduledb();

        public IActionResult ModuleRegisteration()
        {

            return View();
        }
        [HttpPost]
        public IActionResult ModuleRegisteration([Bind] Module Fac)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string res = dc.Saverecord(Fac);
                    TempData["msg"] = res;
                }

            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
            }

            return View();
        }

        public IActionResult Batch1()
        {

            return View();
        }

        Allocationdb al = new Allocationdb();
        public IActionResult BatchAllocation()
        {

            return View();
        }

        [HttpPost]
        public IActionResult BatchAllocation([Bind] Allocation Fac)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string res = al.Saverecord(Fac);
                    TempData["msg"] = res;
                }

            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
            }
            return View();
        }


        Fac_searchdb sd = new Fac_searchdb();
        public IActionResult BatchSearch()
        {

            return View();
        }

        [HttpPost]
        public IActionResult BatchSearch([Bind] Fac_search ad)
        {

            int res = sd.LoginCheck(ad);
            if (res == 1)
            {
                TempData["msg"] = "Welcome To Personalized Window.";

            }
            else
            {
                TempData["msg"] = "User id or Password is wrong:";
            }
            return View();
        }

        Updationdb cd = new Updationdb();
        public IActionResult BatchUpdateScreen()
        {

            return View();
        }

        [HttpPost]
        public IActionResult BatchUpdateScreen([Bind] Updation Fac)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string res = cd.Saverecord(Fac);
                    TempData["msg"] = res;
                }

            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
            }
            return View();
        }

        Batch_searchdb dd = new Batch_searchdb();
        public IActionResult ReportManagement()
        {

            return View();
        }

        [HttpPost]
        public IActionResult ReportManagement([Bind] Batch_Search ad)
        {
            int res = dd.LoginCheck(ad);
            if (res == 1)
            {
                TempData["msg"] = "Welcome To Personalized Window.";

            }
            else
            {
                TempData["msg"] = "User id or Password is wrong:";
            }
            return View();
        }

        Report_Submissiondb rd = new Report_Submissiondb();
        public IActionResult ReportSubmission()
        {

            return View();
        }

        [HttpPost]
        public IActionResult ReportSubmission([Bind] Report_Submission Fac)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string res = rd.Saverecord(Fac);
                    TempData["msg"] = res;
                }

            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
            }
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
        Batch_Screendb bd = new Batch_Screendb();
        public IActionResult BatchScreen()
        {


            return View();
        }

        [HttpPost]
        public IActionResult BatchScreen([Bind] Batch_Screen Fac)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string res = bd.Saverecord(Fac);
                    TempData["msg"] = res;
                }

            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
            }
            return View();
        }

        public IActionResult submit()
        {

            return View();
        }
    }
}
