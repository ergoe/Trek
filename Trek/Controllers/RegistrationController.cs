using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Trek.Controllers
{
    public class RegistrationController : Controller
    {
        //
        // GET: /Registration/

        public ActionResult RegistrationForm()
        {
            return View();
        }

        public ActionResult PermissionSlip()
        {
            return View();
        }

    }
}
