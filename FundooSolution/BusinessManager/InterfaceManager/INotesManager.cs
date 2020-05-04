// -------------------------------------------------------------------------------------------------------
// <copyright file="INotesManager.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -------------------------------------------------------------------------------------------------------

namespace BusinessManager.InterfaceManager
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Common.ModelsOfNotes;
    using Microsoft.AspNetCore.Http;

    /// <summary>
    /// Interface for Notes Manager
    /// </summary>
    public interface INotesManager
    {
        /// <summary>
        ///  image link
        /// </summary>
        /// <param name="file">The file.</param>
        /// <returns>image link</returns>
        string CloudImage(IFormFile file);

        /// <summary>
        /// Adds the note.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="notemodel">The notemodel.</param>
        /// <param name="file">The file.</param>
        /// <returns>true if success otherwise false</returns>
        bool AddNote(string email, NewNote notemodel, IFormFile file);

        /// <summary>
        /// Gets the note.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="id">The identifier.</param>
        /// <returns>A note by id</returns>
        NotesModel GetNote(string email, int id);

        /// <summary>
        /// Gets all notes.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>All Notes</returns>
        IEnumerable<NotesModel> GetAllNotes(string email);

        /// <summary>
        /// Updates the note.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="note">The note.</param>
        /// <param name="id">The identifier.</param>
        /// <returns>true if success otherwise false</returns>
        bool UpdateNote(string email, NewNote note, int id);

        /// <summary>
        /// Deletes the note.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="id">The identifier.</param>
        /// <returns>true if success otherwise false</returns>
        bool DeleteNote(string email, int id);

        /// <summary>
        /// Updates the note image.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="noteid">The noteid.</param>
        /// <param name="imagefile">The imagefile.</param>
        /// <returns>true if success otherwise false</returns>
        bool UpdateNoteImage(string email, int noteid, IFormFile imagefile);

        /// <summary>
        /// Archives the specified email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="id">The identifier.</param>
        /// <returns>true if success otherwise false</returns>
        bool Archive(string email, int id);

        /// <summary>
        /// Archived list.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>All Archived Notes</returns>
        IEnumerable<NotesModel> ArchivedNoteList(String email);

        /// <summary>
        /// Pins by specified email and id
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="id">The identifier.</param>
        /// <returns>true if succeded otherwise false</returns>
        bool Pin(string email, int id);

        /// <summary>
        /// Pinned note list.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>all pinned notes</returns>
        IEnumerable<NotesModel> PinnedNoteList(String email);

        /// <summary>
        /// Trashes note by specified email and id
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="noteid">The noteid.</param>
        /// <returns></returns>
        bool Trash(string email, int noteid);

        /// <summary>
        /// Trashes the note list.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>Trashed notes</returns>
        IEnumerable<NotesModel> TrashNoteList(string email);

        /// <summary>
        /// Restores the note by specified email and noteid
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="noteid">The noteid.</param>
        /// <returns></returns>
        bool Restore(string email, int noteid);

        /// <summary>
        /// Searches the notes.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="searchquery">The searchquery.</param>
        /// <returns>searched notes</returns>
        List<NotesModel> SearchNotes(string email, string searchquery);
    }
}
