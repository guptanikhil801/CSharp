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
            if (result == null)
            {
                this.dbcontext.Notes.Add(note);
                if (this.dbcontext.SaveChanges() == 1)
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

        public NotesModel GetNote(string email, int id)
        {
            var cachestring = distributedcache.GetString("notelist");
            if (cachestring == null)
            {
                var tempdata = PutDataToCache(email);
                return tempdata.Find(option => option.Email == email && option.Id == id &&
                option.IsArchive == false && option.IsTrash == false);
            }
            else
            {
                var tempdata = RetreiveDataFromCache("notelist");
                return tempdata.Find(option => option.Email == email && option.Id == id &&
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
    }
}
