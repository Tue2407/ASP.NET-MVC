using Exercise2.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercise2.Controllers
{
    public class RockbandController : Controller
    {
        // GET: Rockband
        public ActionResult Index()
        {
            return View(RockbandService.getRockbands());
        }
    }
}