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

        public bool DoAddNote(string email, NewNote note, IFormFile file)
        {
            var imagelink = MakeCloudImage(file);
            var createnote = new NotesModel
            {
                Email = email,
                Image = imagelink,
                Description = note.Description,
                Reminder = note.Reminder,
                Title = note.Title,
                Colour = note.Colour,
                CreatedDate = DateTime.UtcNow,
                ModifiedDate = DateTime.UtcNow,
                IsArchive = false,
                IsPin = false,
                IsTrash = false,
            };
            this.dbcontext.Notes.Add(createnote);
            if (this.dbcontext.SaveChanges() == 1)
            {
                return true;
            }

            return false;
        }

        public bool DoArchive(string email, int id)
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

        public IEnumerable<NotesModel> GetArchivedNoteList(string email)
        {
            var result = this.dbcontext.Notes.Where(option => option.Email == email && option.IsArchive == true);
            return result;
        }

        public string MakeCloudImage(IFormFile file)
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

        public bool DoDeleteNote(string email, int id)
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

        public IEnumerable<NotesModel> DoGetAllNotes(string email)
        {
            var cachestring = distributedcache.GetString("notelist");
            if (cachestring == null)
            {
                var tempdata = DoPutDataToCache(email);
                return tempdata.Where(option => option.IsArchive == false && option.IsTrash == false);
            }
            else
            {
                var tempdata = DoRetreiveDataFromCache("notelist");
                return tempdata.Where(option => option.IsArchive == false && option.IsTrash == false);
            }
        }

        public NotesModel DoGetNote(string email, int id)
        {
            var cachestring = distributedcache.GetString("notelist");
            if (cachestring == null)
            {
                var tempdata = DoPutDataToCache(email);
                return tempdata.Find(option => option.Email == email && option.NoteId == id &&
                option.IsArchive == false && option.IsTrash == false);
            }
            else
            {
                var tempdata = DoRetreiveDataFromCache("notelist");
                return tempdata.Find(option => option.Email == email && option.NoteId == id &&
                option.IsArchive == false && option.IsTrash == false);
            }
        }

        public bool DoPin(string email, int id)
        {
            var note = dbcontext.Notes.FirstOrDefault(option => option.Email == email && option.NoteId == id);
            if (note != null)
            {
                if (note.IsPin == true)
                {
                    note.IsPin = false;
                }
                else
                {
                    note.IsPin = true;
                }
                dbcontext.Notes.Update(note);
                dbcontext.SaveChanges();
                return true;
            }

            return false;
        }

        public IEnumerable<NotesModel> GetPinnedNoteList(string email)
        {
            var pinnednotes = dbcontext.Notes.Where(option => option.Email == email && option.IsPin == true);
            return pinnednotes;
        }

        public List<NotesModel> DoPutDataToCache(string email)
        {
            var options = new DistributedCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromMinutes(90));
            var data = this.dbcontext.Notes.Where(op => op.Email == email);
            var jsondata = JsonConvert.SerializeObject(data);
            distributedcache.SetString("notelist", jsondata, options);
            return data.ToList();
        }

        public bool DoRestore(string email, int noteid)
        {
            var note = dbcontext.Notes.FirstOrDefault(option => option.Email == email && option.NoteId == noteid);
            if (note != null)
            {
                if (note.IsTrash == true)
                {
                    note.IsTrash = false;
                }

                this.dbcontext.Notes.Update(note);
                this.dbcontext.SaveChanges();
                return true;
            }
            return false;
        }

        public List<NotesModel> DoRetreiveDataFromCache(string key)
        {
            var CacheString = this.distributedcache.GetString(key);
            return JsonConvert.DeserializeObject<IEnumerable<NotesModel>>(CacheString).ToList();
        }

        public bool DoTrash(string email, int noteid)
        {
            var note = dbcontext.Notes.FirstOrDefault(option => option.Email == email && option.NoteId == noteid);
            if (note != null)
            {
                if (note.IsTrash == false)
                {
                    note.IsTrash = true;
                }

                this.dbcontext.Notes.Update(note);
                this.dbcontext.SaveChanges();
                return true;
            }

            return false;
        }

        public IEnumerable<NotesModel> GetTrashNoteList(string email)
        {
            return dbcontext.Notes.Where(option => option.Email == email && option.IsTrash == true);
        }

        public bool DoUpdateNote(string email, NewNote note, int id)
        {
            var record = dbcontext.Notes.FirstOrDefault(option => option.Email == email && option.NoteId == id);
            if (record != null)
            {
                record.ModifiedDate = DateTime.Now;
                record.Colour = note.Colour ?? record.Colour;
                record.Description = note.Description ?? record.Description;
                record.Image = record.Image;
                record.Title = note.Title ?? record.Title;
                record.Reminder = note.Reminder ?? record.Reminder;
                this.dbcontext.Notes.Update(record);
                var result = this.dbcontext.SaveChanges();
                if (result == 1)
                {
                    return true;
                }
            }

            return false;
        }

        public bool DoUpdateNoteImage(string email, int noteid, IFormFile imagefile)
        {
            var imagelink = MakeCloudImage(imagefile);
            var record = dbcontext.Notes.FirstOrDefault(option => option.Email == email && option.NoteId == noteid);
            if (record != null)
            {
                record.Image = imagelink;
                this.dbcontext.Notes.Update(record);
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
