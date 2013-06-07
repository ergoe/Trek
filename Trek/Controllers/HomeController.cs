using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trek.Models;

namespace Trek.Controllers
{
    public class HomeController : Controller
    {
        DataClasses objData;
        
        public HomeController()
        {
            objData = new DataClasses();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ParticipantEntry()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult ImportantDocuments()
        {
            var files = DataClasses.GetFiles();
            return PartialView(files);
        }


       

    }
}
