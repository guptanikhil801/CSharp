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
        public ActionResult Archive( int NoteId)
        {
           if (this.manager.Archive( NoteId))
              {
                  return Json(new { HttpStatusCode.OK, NoteId });
              }
            
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }

        [HttpDelete]
        public ActionResult DeleteForever(int NoteId)
        {
            string msg = "Note Deleted permanently";
            if (this.manager.DeleteNote(NoteId))
            {
                return Json(new { HttpStatusCode.OK, msg });
            }

            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }

        [HttpPut]
        public ActionResult TrashAndRestore(int NoteId)
        {
            if (this.manager.TrashAndUnTrash(NoteId))
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