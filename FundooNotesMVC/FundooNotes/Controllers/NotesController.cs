using FundooRepository.ImplementationClassRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Common.NotesModels;

namespace FundooNotes.Controllers
{
    public class NotesController : Controller
    {
        private NoteImplClass manager = new NoteImplClass();
        // GET: Notes
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddNote(AddNoteModel note)
        {
            string msg = "Note Created";
            if (this.manager.AddNote(note))
            {
                return Json(new { HttpStatusCode.OK, msg });
            }

            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }

        [HttpPut]
        public ActionResult UpdateNote(int noteid, string title, string description)
        {
            if (this.manager.UpdateNote(noteid,title,description))
            {
                return Json(new { HttpStatusCode.OK });
            }

            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }

        [HttpPut]
        public ActionResult Archive(int id)
        {
           if (this.manager.Archive( id))
              {
                  return Json(new { HttpStatusCode.OK });
              }
            
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }

        [HttpDelete]
        public ActionResult DeleteForever(int id)
        {
            string msg = "Note Deleted permanently";
            if (this.manager.DeleteNote(id))
            {
                return Json(new { HttpStatusCode.OK, msg });
            }

            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }

        [HttpGet]
        [Route("/Notes/GetAllArchivedNotes/{id}")]
        public ActionResult GetAllArchivedNotes(string id)
        {
            var allarchivednotes = this.manager.GetAllArchivedNotes(id);
            return Json(new { HttpStatusCode.OK, allarchivednotes }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        [Route("/Notes/GetAllNotes/{id}")]
        public ActionResult GetAllNotes(string id)
        {
            var allnotes = this.manager.GetAllNotes(id);
                return Json(new { HttpStatusCode.OK,  allnotes },JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        [Route("/Notes/GetAllPinnedNotes/{id}")]
        public ActionResult GetAllPinnedNotes(string id)
        {
            var allpinnednotes = this.manager.GetAllPinnedNotes(id);
            return Json(new { HttpStatusCode.OK, allpinnednotes }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        [Route("/Notes/GetAllTrashedNotes/{id}")]
        public ActionResult GetAllTrashedNotes(string id)
        {
            var alltrashednotes = this.manager.GetAllTrashedNotes(id);
            return Json(new { HttpStatusCode.OK, alltrashednotes }, JsonRequestBehavior.AllowGet);
        }

        [HttpPut]
        public ActionResult TrashAndRestore(int id)
        {
            if (this.manager.TrashAndUnTrash(id))
            {
                return Json(new { HttpStatusCode.OK });
            }
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }

        [HttpPut]
        public ActionResult NoteImage(int NoteId, HttpPostedFileBase File)
        {
            var imagelink = CloudImageLink(File);
            var msg = "Note Image Uploaded";
            if (this.manager.NoteImage(NoteId, imagelink))
            {
                return Json(new { HttpStatusCode.OK, msg });
            }
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }

        [HttpPut]
        public ActionResult PinUnPin(int id)
        {
            if (this.manager.PinUnPin(id))
            {
                return Json(new { HttpStatusCode.OK });
            }

            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }

        [HttpPut]
        public ActionResult ProfilePicture(string Email, HttpPostedFileBase File)
        {
            var imagelink = CloudImageLink(File);
            var msg = "Profile Picture Uploaded";
            if (this.manager.ProfilePicture(Email, imagelink))
            {
                return Json(new { HttpStatusCode.OK, msg });
            }
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }

        private string CloudImageLink(HttpPostedFileBase file)
        {
            if (file == null)
            {
                return null;
            }
            var filepath = file.InputStream;
            string uniquename = Guid.NewGuid().ToString() + "_" + file.FileName;
            Account account = new Account("nikhilcloud007", "857761978269428", "Dp0h4mHl84o2zDL8HwINokEe6hM");
            Cloudinary cloud = new Cloudinary(account);
            var uploadparam = new ImageUploadParams()
            {
                File = new FileDescription(uniquename, filepath)
            };
            var uploadresult = cloud.Upload(uploadparam);
            return uploadresult.Url.ToString();
        }
    }
}