using Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Demo.Controllers
{
    public class AuthenticationController :Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult DoLogin(UserDetails u)
        {
            FormsAuthentication.SetAuthCookie(u.UserName, false);
            return RedirectToAction("Index", "Employee");
        }
    }
}