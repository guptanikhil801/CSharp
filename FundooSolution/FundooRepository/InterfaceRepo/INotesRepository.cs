// -------------------------------------------------------------------------------------------------------
// <copyright file="INotesRepository.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -------------------------------------------------------------------------------------------------------

namespace FundooRepository.InterfaceRepo
{
    using Common.ModelsOfNotes;
    using Microsoft.AspNetCore.Http;
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// interface for Notes Repository
    /// </summary>
    public interface INotesRepository
    {
        /// <summary>
        /// Makes the cloud image.
        /// </summary>
        /// <param name="file">The file.</param>
        /// <returns>image cloud link</returns>
        string MakeCloudImage(IFormFile file);

        /// <summary>
        /// Does the add note.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="notemodel">The notemodel.</param>
        /// <param name="file">The file.</param>
        /// <returns>true or false</returns>
        bool DoAddNote(string email, NewNote notemodel, IFormFile file);

        /// <summary>
        /// Does the put data to cache.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>list of notes</returns>
        List<NotesModel> DoPutDataToCache(string email);

        /// <summary>
        /// Does the retreive data from cache.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>list of notes</returns>
        List<NotesModel> DoRetreiveDataFromCache(string key);

        /// <summary>
        /// Does the get note.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="id">The identifier.</param>
        /// <returns>the note</returns>
        NotesModel DoGetNote(string email, int id);
        IEnumerable<NotesModel> DoGetAllNotes(string email);

        /// <summary>
        /// Does the update note.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="note">The note.</param>
        /// <param name="id">The identifier.</param>
        /// <returns>true or false</returns>
        bool DoUpdateNote(string email, NewNote note, int id);

        /// <summary>
        /// deletes a note.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="id">The identifier.</param>
        /// <returns>true or false</returns>
        bool DoDeleteNote(string email, int id);

        /// <summary>
        /// Does the update note image.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="noteid">The noteid.</param>
        /// <param name="imagefile">The imagefile.</param>
        /// <returns>true or false</returns>
        bool DoUpdateNoteImage(string email, int noteid, IFormFile imagefile);

        /// <summary>
        /// Does the archive.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="id">The identifier.</param>
        /// <returns>true or false</returns>
        bool DoArchive(string email, int id);

        /// <summary>
        /// Gets the archived note list.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>archived notes</returns>
        IEnumerable<NotesModel> GetArchivedNoteList(String email);

        /// <summary>
        /// Does the pin.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="id">The identifier.</param>
        /// <returns>true or false</returns>
        bool DoPin(string email, int id);

        /// <summary>
        /// Gets the pinned note list.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>pinned notes</returns>
        IEnumerable<NotesModel> GetPinnedNoteList(String email);

        /// <summary>
        /// Does the trash.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="noteid">The noteid.</param>
        /// <returns>true or false</returns>
        bool DoTrash(string email, int noteid);

        /// <summary>
        /// Gets the trash note list.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>trashed note list</returns>
        IEnumerable<NotesModel> GetTrashNoteList(string email);

        /// <summary>
        /// Does the restore.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="noteid">The noteid.</param>
        /// <returns>true or false</returns>
        bool DoRestore(string email, int noteid);

        /// <summary>
        /// Searches the notes.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="searchquery">The searchquery.</param>
        /// <returns>searched notes</returns>
        List<NotesModel> SearchNotes(string email, string searchquery);
    }
}
