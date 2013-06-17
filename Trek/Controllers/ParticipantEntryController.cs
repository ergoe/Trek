using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Trek.Models;
using System.Net;

namespace Trek.Controllers
{
    public class ParticipantEntryController : Controller
    {
        //
        // POST: /ParticipantEntry/Create

        
        //public ActionResult AddParticipant(FormCollection collection)
        //{
        //    var participantModel = (ParticipantModel) collection;
        //    string name = collection.Get("");
        //    return null;
        //}

        public ActionResult AddParticipant(ParticipantModel participant)
        {
            //var p = new ParticipantModel("12330", "Eric", "Goeckeritz", "16", "M", "12", "2013-12-22", "5910 Joe Lane",
            //                              "address2", "2086956598", "Lara Goeckeritz", "2086088044",
            //                              "This is the considerations field", "Blue Cross", "zqdd1234d",
            //                              "This is the camput arrangment box");

            string id = Guid.NewGuid().ToString().Substring(0, 8);
            participant.UserId = id;
            //main api
            string requestUrl = @"http://www.truetothefaithtrek.com/_trekapi/api/participant";
            //localhost
            //string requestUrl = @"http://localhost:49167/api/participant";

            var request = HttpWebRequest.Create(requestUrl);

            request.Method = "POST";

            request.ContentType = "application/json; charset=utf-8";
            var jsonObj = JsonConvert.SerializeObject(participant);

            var djsonOject = JsonConvert.DeserializeObject<ParticipantModel>(jsonObj);

            try
            {
                using (StreamWriter requestWritter = new StreamWriter(request.GetRequestStream()))
                {
                    requestWritter.Write(jsonObj);
                }
            }
            catch (WebException ex)
            {
                return Content("");
            }

            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    ModelState.AddModelError("", "Request status was not OK. Please try again");
                }
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    var serverResponse = reader.ReadToEnd();
                }
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    //Redirect("Home/ParticipantEntry");
                    //return View("ParticipantEntry");
                }
            }


            //string name = participant.Fname;
            //JsonResult jsonResult = Json(participant);
            //var b = jsonResult.Data;
            //ViewBag.Participant = Json(participant, JsonRequestBehavior.AllowGet);
            //return Json(p, JsonRequestBehavior.AllowGet);
            ModelState.Clear();
            return View("ParticipantEntry");
        }

        
    }
}
