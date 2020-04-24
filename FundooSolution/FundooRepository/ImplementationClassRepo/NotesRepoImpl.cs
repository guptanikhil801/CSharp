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
    using Microsoft.Extensions.Caching.Distributed;
    using Newtonsoft.Json;

    public class NotesRepoImpl : INotesRepository
    {
        private readonly UserDBContext dbcontext;
        private readonly IDistributedCache distributedcache;

        public NotesRepoImpl(UserDBContext dbcontext, IDistributedCache distributedcache)
        {
            this.dbcontext = dbcontext;
            this.distributedcache = distributedcache;
        }

        public bool AddNote(string email, NewNote note, IFormFile file)
        {
            var imagelink = CloudImage(file);
            var createnote = new NotesModel
            {
                Email = email,
                Image = imagelink,
                Description = note.Description,
                NoteId = note.NoteId,
                Reminder = note.Reminder,
                Title = note.Title,
                Colour = note.Colour,
                CreatedDate = DateTime.UtcNow,
                ModifiedDate = DateTime.UtcNow,
                IsArchive = false,
                IsPin = false,
                IsTrash = false,
            };

            var result = this.dbcontext.Notes.FirstOrDefault(o => o.NoteId == note.NoteId);
            if (result == null)
            {
                this.dbcontext.Notes.Add(createnote);
                if (this.dbcontext.SaveChanges() == 1)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Archive(string email, int id)
        {
            var note = dbcontext.Notes.FirstOrDefault(option => option.Email == email && option.NoteId == id);
            if (note != null)
            {
                if (note.IsArchive == true)
                {
                    note.IsArchive = false;
                }
                else
                {
                    note.IsArchive = true;
                }
                this.dbcontext.Notes.Update(note);
                this.dbcontext.SaveChanges();
                return true;
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

        public bool DeleteNote(string email, int id)
        {
            var note = dbcontext.Notes.FirstOrDefault(option => option.Email == email && option.NoteId == id);
            if (note != null)
            {
                dbcontext.Notes.Remove(note);
                var result = dbcontext.SaveChanges();
                if (result == 1)
                {
                    return true;
                }
            }

            return false;
        }

        public IEnumerable<NotesModel> GetAllNotes(string email)
        {
            var cachestring = distributedcache.GetString("notelist");
            if (cachestring == null)
            {
                var tempdata = PutDataToCache(email);
                return tempdata.Where(option => option.IsArchive == false && option.IsTrash == false);
            }
            else
            {
                var tempdata = RetreiveDataFromCache("notelist");
                return tempdata.Where(option => option.IsArchive == false && option.IsTrash == false);
            }
        }

        public NotesModel GetNote(string email, int id)
        {
            var cachestring = distributedcache.GetString("notelist");
            if (cachestring == null)
            {
                var tempdata = PutDataToCache(email);
                return tempdata.Find(option => option.Email == email && option.NoteId == id &&
                option.IsArchive == false && option.IsTrash == false);
            }
            else
            {
                var tempdata = RetreiveDataFromCache("notelist");
                return tempdata.Find(option => option.Email == email && option.NoteId == id &&
                option.IsArchive == false && option.IsTrash == false);
            }
        }

        public List<NotesModel> PutDataToCache(string email)
        {
            var options = new DistributedCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromMinutes(90));
            var data = this.dbcontext.Notes.Where(op => op.Email == email);
            var jsondata = JsonConvert.SerializeObject(data);
            distributedcache.SetString("notelist", jsondata, options);
            return data.ToList();
        }

        public List<NotesModel> RetreiveDataFromCache(string key)
        {
            var CacheString = this.distributedcache.GetString(key);
            return JsonConvert.DeserializeObject<IEnumerable<NotesModel>>(CacheString).ToList();
        }

        public bool UpdateNote(NewNote note)
        {
            var record = dbcontext.Notes.FirstOrDefault(option => option.NoteId == note.NoteId);
            if (record != null)
            {
                record.ModifiedDate = DateTime.Now;
                record.Colour = note.Colour ?? record.Colour;
                record.Description = note.Description ?? record.Description;
                record.Image = record.Image;
                record.Title = note.Title ?? record.Title;
                record.Reminder = note.Reminder ?? record.Reminder;
                this.dbcontext.Update(record);
                var result = this.dbcontext.SaveChanges();
                if (result == 1)
                {
                    return true;
                }
            }

            return false;
        }

        public bool UpdateNoteImage(int noteid, IFormFile imagefile)
        {
            var imagelink = CloudImage(imagefile);
            var record = dbcontext.Notes.FirstOrDefault(option => option.NoteId == noteid);
            if (record != null)
            {
                record.Image = imagelink;
                this.dbcontext.Update(record);
                var result = this.dbcontext.SaveChanges();
                if (result == 1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
