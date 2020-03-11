using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercise03.Controllers
{
    public class TimeController : Controller
    {
        // GET: Time
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection formCollection)
        {
            int hours = Convert.ToInt32(formCollection["Hours"]);
            int minutes = Convert.ToInt32(formCollection["Minutes"]);
            int seconds = Convert.ToInt32(formCollection["seconds"]);
            int totalTime = hours * 3600 + minutes * 60 + seconds;
            string s = hours + " hours + " + minutes + " minutes + " + seconds + " seconds = " +
                totalTime + " seconds in total";
            return View("Result", "", s);
        }
    }
}