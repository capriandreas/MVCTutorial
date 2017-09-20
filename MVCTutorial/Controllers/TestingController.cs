using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorial.Controllers
{
    public class TestingController : Controller
    {
        // GET: Testing
        public ActionResult Index()
        {
            ViewBag.Name = "Capri";

            List<String> agitMember = new List<string>();
            agitMember.Add("Narodo");
            agitMember.Add("Josua");
            agitMember.Add("Daniel");

            ViewBag.AgitMember = agitMember;

            return View();
        }
    }
}