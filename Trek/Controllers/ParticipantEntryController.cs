using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trek.Models;

namespace Trek.Controllers
{
    public class ParticipantEntryController : Controller
    {
        //
        // GET: /ParticipantEntry/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /ParticipantEntry/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /ParticipantEntry/Create

        public ActionResult Create()
        {
            return View();
        }

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
            string name = participant.Fname;
            JsonResult jsonResult = Json(participant);
            var b = jsonResult.Data;
            return null;
        }

        //
        // GET: /ParticipantEntry/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /ParticipantEntry/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /ParticipantEntry/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /ParticipantEntry/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
