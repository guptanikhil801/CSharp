using FundooRepository.ImplementationClassRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace FundooNotes.Controllers
{
    public class LabelController : Controller
    {
        private LabelImpl manager = new LabelImpl();
        
        // GET: Label
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddLabel(int noteid, string details)
        {
            string msg = "Label added";
            if (this.manager.AddLabel(noteid, details))
            {
                return Json(new { HttpStatusCode.OK, msg });
            }

            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }

        [HttpGet]
        [Route("/Label/GetLabelByNoteId/{id}")]
        public ActionResult GetLabelByNoteId(int id)
        {
            var label = this.manager.GetLabelByNoteId(id);
            return Json(new { HttpStatusCode.OK, label }, JsonRequestBehavior.AllowGet);
        }

        [HttpDelete]
        public ActionResult DeleteLabel(int id)
        {
            string msg = "Label Deleted permanently";
            if (this.manager.DeleteLabel(id))
            {
                return Json(new { HttpStatusCode.OK, msg });
            }

            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }

        [HttpPut]
        public ActionResult UpdateLabel(int labelid, string details)
        {
            if (this.manager.UpdateLabel(labelid, details))
            {
                return Json(new { HttpStatusCode.OK });
            }

            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }
    
    }
}