using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    
    public class TestController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HandleError(ExceptionType = typeof(Exception))]
        public ActionResult Action()
        {
            throw new Exception("test");
            //return View("TestAction");
        }
        
        public string Getstring()
        {
            return "test";
        }

        [NonAction]
        public string NonAction()
        {
            return "NonAction";
        }
    }
}