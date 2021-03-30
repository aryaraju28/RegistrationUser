using RegistrationUser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistrationUser.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registration1(Person p)
        {
            return View("About",p);
        }
    }
}