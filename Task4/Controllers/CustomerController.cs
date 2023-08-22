using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task4.Controllers
{
    [RoutePrefix("r")]

    public class CustomerController : Controller
    {
        // GET: Customer
        [Route("Customer/Index/{SubjectName}")]
        //https://localhost:44325/r/Customer/Index/MVC
        //controller , parameter , action
        public ActionResult Index(string SubjectName)
        {
            return Content("This Example is Totally Based on " + SubjectName);
        }

        [Route("~/Customer/Index1/{Id?}")]
        //https://localhost:44325/r/Customer/Index1
        public ActionResult Index1(int? Id) 
        { 

          return Content("This Example is Totally Based on SubjectId " + Id);

        }

        [HttpGet]
        [Route("~/Customer/Index2/{customerId:alpha:min(4):max(16)}")]  
        //https://localhost:44325/r/Customer/Index2/hellowelcome
        public ActionResult Index2(string customerId)
        {
            return Content("This Example is Restrictions for the route " + customerId);
        }
    }
}