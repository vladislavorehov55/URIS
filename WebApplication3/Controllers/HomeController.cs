using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;


namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Login1()
        {
            return View();
        }
        public ActionResult login1_calendar()
        {
            return View();
        }
        public ActionResult login1_documents()
        {
            return View();
        }
        Plan_rabotContext db = new Plan_rabotContext();
        public ActionResult login1_plan()
        {
            IEnumerable<Plan_rabot> plans = db.Plans;
            ViewBag.Plans = plans;
            return View();
        }
        public ActionResult login1_report()
        {
            return View();
        }
        public ActionResult Login2()
        {
            return View();
        }
        public ActionResult login2_calendar()
        {
            return View();
        }
        public ActionResult login2_documents()
        {
            return View();
        }
        public ActionResult login2_plan()
        {
            return View();
        }
        public ActionResult login2_report()
        {
            return View();
        }
        public void Download()
        {
            
        }
    }

}