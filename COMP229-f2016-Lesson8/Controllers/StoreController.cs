using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace COMP229_f2016_Lesson8.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {

            ViewBag.Title = "Model Kit Store";
            return View();
        }

        // GET: Browse
        public ActionResult Browse(string brand)
        {
            ViewBag.Title = "Browse";
            ViewBag.Message = "Brand: " + brand;
            return View();
        }

        // GET: Details
        public ActionResult Details()
        {
            ViewBag.Title = "Details";
            return View();
        }
    }
}