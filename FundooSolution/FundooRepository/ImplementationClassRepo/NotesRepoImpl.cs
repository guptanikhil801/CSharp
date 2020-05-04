// -------------------------------------------------------------------------------------------------------
// <copyright file="NotesRepoImpl.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// ------------------------------------------------------------------------------------------------------

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

    /// <summary>
    /// implementation class of INotesRepository
    /// </summary>
    /// <seealso cref="FundooRepository.InterfaceRepo.INotesRepository" />
    public class NotesRepoImpl : INotesRepository
    {
        /// <summary>
        /// The dbcontext
        /// </summary>
        private readonly UserDBContext dbcontext;

        /// <summary>
        /// The distributedcache variable for radis cache
        /// </summary>
        private readonly IDistributedCache distributedcache;

        /// <summary>
        /// Initializes a new instance of the <see cref="NotesRepoImpl"/> class.
        /// </summary>
        /// <param name="dbcontext">The dbcontext.</param>
        /// <param name="distributedcache">The distributedcache.</param>
        public NotesRepoImpl(UserDBContext dbcontext, IDistributedCache distributedcache)
        {
            this.dbcontext = dbcontext;
            this.distributedcache = distributedcache;
        }

        /// <summary>
        /// Does the add note.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="note">The note.</param>
        /// <param name="file">The file.</param>
        /// <returns>true or false</returns>
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

        /// <summary>
        /// Does the archive.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="id">The identifier.</param>
        /// <returns>true or false</returns>
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

        /// <summary>
        /// Gets the archived note list.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>list of notes</returns>
        public IEnumerable<NotesModel> GetArchivedNoteList(string email)
        {
            var result = this.dbcontext.Notes.Where(option => option.Email == email && option.IsArchive == true);
            return result;
        }

        /// <summary>
        /// uploads a image to cloud.
        /// </summary>
        /// <param name="file">The file.</param>
        /// <returns>cloud link</returns>
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

        /// <summary>
        /// deletes a note.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="id">The id.</param>
        /// <returns>true or false</returns>
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

        /// <summary>
        /// gets all notes.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>all notes</returns>
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

        /// <summary>
        /// get note by id
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="id">The id.</param>
        /// <returns>a note</returns>
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

        /// <summary>
        /// Does the pin.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="id">The identifier.</param>
        /// <returns>true or false</returns>
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

        /// <summary>
        /// Gets the pinned note list.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>list of notes</returns>
        public IEnumerable<NotesModel> GetPinnedNoteList(string email)
        {
            var pinnednotes = dbcontext.Notes.Where(option => option.Email == email && option.IsPin == true);
            return pinnednotes;
        }

        /// <summary>
        /// Does the put data to cache.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        public List<NotesModel> DoPutDataToCache(string email)
        {
            var options = new DistributedCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromMinutes(90));
            var data = this.dbcontext.Notes.Where(op => op.Email == email);
            var jsondata = JsonConvert.SerializeObject(data);
            distributedcache.SetString("notelist", jsondata, options);
            return data.ToList();
        }

        /// <summary>
        /// Does the restore.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="noteid">The noteid.</param>
        /// <returns>true or false</returns>
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

        /// <summary>
        /// Does the retreive data from cache.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>list of notes</returns>
        public List<NotesModel> DoRetreiveDataFromCache(string key)
        {
            var CacheString = this.distributedcache.GetString(key);
            return JsonConvert.DeserializeObject<IEnumerable<NotesModel>>(CacheString).ToList();
        }

        /// <summary>
        /// Does the trash.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="noteid">The noteid.</param>
        /// <returns>true or false</returns>
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

        /// <summary>
        /// Gets the trash note list.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>list of trashed notes</returns>
        public IEnumerable<NotesModel> GetTrashNoteList(string email)
        {
            return dbcontext.Notes.Where(option => option.Email == email && option.IsTrash == true);
        }

        /// <summary>
        ///  updates a note.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="note">The note.</param>
        /// <param name="id">The identifier.</param>
        /// <returns>true or false</returns>
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

        /// <summary>
        /// add or updates a note image.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="noteid">The noteid.</param>
        /// <param name="imagefile">The imagefile.</param>
        /// <returns>true or false</returns>
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

        /// <summary>
        /// Searches the notes.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="searchquery">The searchquery.</param>
        /// <returns>list of notes</returns>
        public List<NotesModel> SearchNotes(string email, string searchquery)
        {
            var result = this.dbcontext.Notes.Where(option => option.Email == email && option.IsArchive == false && option.IsTrash == false && option.Description.Contains(searchquery)).ToList();
            return result;
        }
    }
}
