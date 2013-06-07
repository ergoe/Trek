using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trek.Models;

namespace Trek.Controllers
{
    public class RegistrationController : Controller
    {
        DataClasses objData;
        
        public RegistrationController()
        {
            objData = new DataClasses();
        }

        
        public ActionResult RegistrationForm()
        {
            //var files = objData.GetFiles();
            var files = DataClasses.GetFiles();
            return View(files);
        }

        
        public FileResult Download(string id)
        {
            int fid = Convert.ToInt32(id);
            //var files = objData.GetFiles();
            var files = DataClasses.GetFiles();
            string filename = (from f in files
                               where f.FileId == fid
                               select f.FilePath).First();
            string contentType = "application/pdf";
            string documentName = (from t in files
                                   where t.FileId == fid
                                   select t.FileName).First();
            return File(filename, contentType, String.Format("{0}.pdf", documentName));
        }

        public ActionResult PermissionSlip()
        {
            return View();
        }

    }
}
