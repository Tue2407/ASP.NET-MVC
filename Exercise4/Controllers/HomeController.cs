using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercise4.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(0);
        }

        //POST: Home
        [HttpPost]
        public ActionResult Index(FormCollection formCollection)
        {
            int result = 0;
            string buttonClicked = formCollection["operator"];
            //todo: check if these are set before converting.
            int number1 = Convert.ToInt32(formCollection["field1"]);
            int number2 = Convert.ToInt32(formCollection["field2"]);
            if(buttonClicked == "+")
            {
                result = number1 + number2;
            } else if(buttonClicked == "-")
            {
                result = number1 - number2;
            } else if(buttonClicked == "/")
            {
                result = number1 / number2;
            } else
            {
                result = number1 * number2;
            }
            
            return View(result);
        }
    }
}