using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TurkceGridMvc.Models;

namespace TurkceGridMvc.Controllers
{
    public class HomeController : Controller
    {
        ProgrammingDbEntities db = new ProgrammingDbEntities();
        // GET: Home
        public ActionResult ProgrammingList()
        {
            return View(db.Languages.ToList());
        }
    }
}