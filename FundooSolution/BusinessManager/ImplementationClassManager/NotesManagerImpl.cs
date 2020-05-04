// -------------------------------------------------------------------------------------------------------
// <copyright file="NotesManagerImpl.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -------------------------------------------------------------------------------------------------------

namespace BusinessManager.ImplementationClassManager
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using BusinessManager.InterfaceManager;
    using Common.ModelsOfNotes;
    using FundooRepository;
    using FundooRepository.InterfaceRepo;
    using Microsoft.AspNetCore.Http;

    /// <summary>
    /// implementation class of INotesManager
    /// </summary>
    /// <seealso cref="BusinessManager.InterfaceManager.INotesManager" />
    public class NotesManagerImpl : INotesManager
    {
        private readonly INotesRepository repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="NotesManagerImpl"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        public NotesManagerImpl( INotesRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Adds the note.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="notemodel">The notemodel.</param>
        /// <param name="file">The file.</param>
        /// <returns>
        /// true if success otherwise false
        /// </returns>
        public bool AddNote(string email, NewNote notemodel, IFormFile file)
        {
            return this.repository.DoAddNote(email,notemodel,file);
        }

        /// <summary>
        /// Archives the specified email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// true if success otherwise false
        /// </returns>
        public bool Archive(string email, int id)
        {
            return this.repository.DoArchive(email, id);
        }

        /// <summary>
        /// Archived list.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>
        /// All Archived Notes
        /// </returns>
        public IEnumerable<NotesModel> ArchivedNoteList(string email)
        {
            return this.repository.GetArchivedNoteList(email);
        }

        /// <summary>
        /// image link
        /// </summary>
        /// <param name="file">The file.</param>
        /// <returns>
        /// image link
        /// </returns>
        public string CloudImage(IFormFile file)
        {
            return this.repository.MakeCloudImage(file);
        }

        /// <summary>
        /// Deletes the note.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// true if success otherwise false
        /// </returns>
        public bool DeleteNote(string email, int id)
        {
           return this.repository.DoDeleteNote(email, id);
        }

        /// <summary>
        /// Gets all notes.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>
        /// All Notes
        /// </returns>
        public IEnumerable<NotesModel> GetAllNotes(string email)
        {
            return this.repository.DoGetAllNotes(email);
        }

        /// <summary>
        /// Gets the note.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// A note by id
        /// </returns>
        public NotesModel GetNote(string email, int id)
        {
            return this.repository.DoGetNote(email, id);
        }

        /// <summary>
        /// Pins by specified email and id
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// true if succeded otherwise false
        /// </returns>
        public bool Pin(string email, int id)
        {
            return this.repository.DoPin(email, id);
        }

        /// <summary>
        /// Pinned note list.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>
        /// all pinned notes
        /// </returns>
        public IEnumerable<NotesModel> PinnedNoteList(string email)
        {
            return this.repository.GetPinnedNoteList(email);
        }

        /// <summary>
        /// Restores the note by specified email and noteid
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="noteid">The noteid.</param>
        /// <returns></returns>
        public bool Restore(string email, int noteid)
        {
            return this.repository.DoRestore(email, noteid);
        }

        /// <summary>
        /// Searches the notes.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="searchquery">The searchquery.</param>
        /// <returns>
        /// searched notes
        /// </returns>
        public List<NotesModel> SearchNotes(string email, string searchquery)
        {
            return this.repository.SearchNotes(email, searchquery);
        }

        /// <summary>
        /// Trashes note by specified email and id
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="noteid">The noteid.</param>
        /// <returns></returns>
        public bool Trash(string email, int noteid)
        {
            return this.repository.DoTrash(email, noteid);
        }

        /// <summary>
        /// Trashes the note list.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>
        /// Trashed notes
        /// </returns>
        public IEnumerable<NotesModel> TrashNoteList(string email)
        {
            return this.repository.GetTrashNoteList(email);
        }

        /// <summary>
        /// Updates the note.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="note">The note.</param>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// true if success otherwise false
        /// </returns>
        public bool UpdateNote(string email, NewNote note,int id)
        {
            return this.repository.DoUpdateNote(email, note,id);
        }

        /// <summary>
        /// Updates the note image.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="noteid">The noteid.</param>
        /// <param name="imagefile">The imagefile.</param>
        /// <returns>
        /// true if success otherwise false
        /// </returns>
        public bool UpdateNoteImage(string email, int noteid, IFormFile imagefile)
        {
            return this.repository.DoUpdateNoteImage(email, noteid, imagefile);
        }
    }
}
