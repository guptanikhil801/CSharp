using Common.NotesModels;
using FundooRepository.ImplementationClassRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace FundooNotes.Controllers
{
    public class CollabratorController : Controller
    {

        private CollabratorImplClass manager = new CollabratorImplClass();

        // GET: Collabrator
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCollabrator(Collabrator collab)
        {
            string msg = "Collabrator Added Successfully";
            if (this.manager.AddCollabrator(collab))
            {
                return Json(new { HttpStatusCode.OK, msg });
            }

            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }


        [HttpGet]
        public ActionResult GetAllCollabrators(int noteid)
        {
            var allcollabs = this.manager.GetAllCollabrator(noteid);
            if (allcollabs != null)
            {
                return Json(new { HttpStatusCode.OK, allcollabs }, JsonRequestBehavior.AllowGet);
            }

            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }

        [HttpDelete]
        public ActionResult RemoveCollabrator(int CollabId)
        {
            string msg = "Collabrator removed successfully";
            if (this.manager.RemoveCollabrator(CollabId))
            {
                return Json(new { HttpStatusCode.OK, msg });
            }

            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }



    }
}