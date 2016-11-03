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
        public string Browse(string genre)
        {
            ViewBag.Title = "Browse";
            string message = HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);
            return message;
        }

        // GET: Details
        public string Details(int id)
        {
            ViewBag.Title = "Details";
            string message = "Store.Details, ID = " + id;
            return message;
        }
    }
}