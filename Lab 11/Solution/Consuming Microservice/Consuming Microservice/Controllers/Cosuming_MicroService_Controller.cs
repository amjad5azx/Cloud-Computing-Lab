using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Consuming_Microservice.Controllers
{
    public class Cosuming_MicroService_Controller : Controller
    {
        public ActionResult Product()
        {
            return View();
        }
        public ActionResult Bank()
        {
            return View();
        }
    }
}