using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task4.Models;

namespace Task4.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            IList<Studentdetails> student = new List<Studentdetails>
            {
                new Studentdetails {StuRoll = "20CSC1" , StuName = "Harita" ,StuStd = "XII",UserName = "aaaa",Password = "1111"},
                new Studentdetails {StuRoll = "20CSC2" , StuName = "Safa" ,StuStd = "XII",UserName = "bbbb",Password = "2222"},
                new Studentdetails {StuRoll = "20CSC3" , StuName = "Shehana" ,StuStd = "XII", UserName = "cccc",Password = "3333"},
                new Studentdetails {StuRoll = "20CSC4" , StuName = "Anjusha" ,StuStd = "XII",UserName = "dddd",Password = "4444"},
                new Studentdetails {StuRoll = "20CSC5" , StuName = "Jensy" ,StuStd = "XII", UserName = "eeee",Password = "5555"}

            };

            TempData["students"] = student;

            for (int i = 0; i < 5; i++)
            {
                TempData["UserName"] = student[i].UserName;
                TempData["Password"] = student[i].Password;

                if (TempData.ContainsValue(TempData["Username"]) && TempData.ContainsKey("Password"))
                {
                    ViewBag.U = student[i].UserName;
                    ViewBag.P = student[i].Password;
                }

            }

            return View(student);
        }

        //web-config
        [HandleError(ExceptionType = typeof(DivideByZeroException), View = "Error1")]
        public ActionResult Index2()
        {
            int a = 1;
            int b = 0;
            int c = 0;
            c = a / b; //it would cause exception.
            return View();
        }
    }
}




