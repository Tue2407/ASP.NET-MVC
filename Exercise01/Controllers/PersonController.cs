using Exercise01.Models;
using Exercise01.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercise01.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            return View(PersonService.GetPeople());
        }

        public ActionResult Details(int id)
        {
            return View(PersonService.GetPerson(id));
        }
    }
}