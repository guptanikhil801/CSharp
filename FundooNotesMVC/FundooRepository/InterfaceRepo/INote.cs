using Common.NotesModels;
using System;
using System.Collections.Generic;
using System.Text;
namespace FundooRepository.InterfaceRepo
{
   public interface INote
    {
        IEnumerable<Note> AllNotes();
        bool AddNote(AddNoteModel note);
        bool UpdateNote(int noteid, string title, string description);
        bool Archive(int Noteid);
        bool DeleteNote(int NoteId);
        IEnumerable<Note> GetAllNotes(string Email);
        IEnumerable<Note> GetAllArchivedNotes(string Email);
        IEnumerable<Note> GetAllTrashedNotes(string Email);
        bool TrashAndUnTrash(int NoteId);
        bool NoteImage(int NoteId, string Imageurl);
        bool ProfilePicture(string Email, string Imageurl);      
    }
}
