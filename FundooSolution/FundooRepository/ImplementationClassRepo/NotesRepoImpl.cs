namespace FundooRepository.ImplementationClassRepo
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using InterfaceRepo;
    using Microsoft.AspNetCore.Http;
    using CloudinaryDotNet;
    using CloudinaryDotNet.Actions;
    using Common.ModelsOfNotes;
    using FundooRepository.Context;
    using System.Linq;

    public class NotesRepoImpl : INotesRepository
    {
        private readonly UserDBContext dbcontext;

        public NotesRepoImpl( UserDBContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        public bool AddNote(string email, NewNote notemodel, IFormFile file)
        {
            var imagelink = CloudImage(file);
            var note = new NotesModel
            {
                Email = email,
                Image = imagelink,
                Description = notemodel.Description,
                NoteId = notemodel.NoteId,
                Reminder = notemodel.Reminder,
                Title = notemodel.Title,
                Colour = notemodel.Colour,
                CreatedDate = DateTime.UtcNow,
                ModifiedDate = DateTime.UtcNow,
                IsArchive = false,
                IsPin = false,
                IsTrash = false,
            };

            var result = this.dbcontext.Notes.FirstOrDefault(o => o.NoteId == note.NoteId);
            if(result == null)
            {
                this.dbcontext.Notes.Add(note);
                if(this.dbcontext.SaveChanges() == 1)
                {
                    return true;
                }
            }
            return false;
        }

        public string CloudImage(IFormFile file)
        {
            if (file == null)
            {
                return null;
            }
            var filepath = file.OpenReadStream();
            string uniquename = Guid.NewGuid().ToString() + "_" + file.FileName;
            Account account = new Account("nikhilcloud007", "857761978269428", "Dp0h4mHl84o2zDL8HwINokEe6hM");
            Cloudinary cloud = new Cloudinary(account);
            var uploadparam = new ImageUploadParams()
            {
                File = new FileDescription(uniquename, filepath)
            };
            var uploadresult = cloud.Upload(uploadparam);
            return uploadresult.Uri.ToString();
        }
    }
}
