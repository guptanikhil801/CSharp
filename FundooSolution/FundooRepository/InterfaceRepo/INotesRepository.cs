namespace FundooRepository.InterfaceRepo
{
    using Common.ModelsOfNotes;
    using Microsoft.AspNetCore.Http;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public interface INotesRepository
    {
        string MakeCloudImage(IFormFile file);
        bool DoAddNote(string email, NewNote notemodel, IFormFile file);
        List<NotesModel> DoPutDataToCache(string email);
        List<NotesModel> DoRetreiveDataFromCache(string key);
        NotesModel DoGetNote(string email, int id);
        IEnumerable<NotesModel> DoGetAllNotes(string email);
        bool DoUpdateNote(string email, NewNote note);
        bool DoDeleteNote(string email, int id);
        bool DoUpdateNoteImage(string email, int noteid, IFormFile imagefile);
        bool DoArchive(string email, int id);
        IEnumerable<NotesModel> GetArchivedNoteList(String email);
        bool DoPin(string email, int id);
        IEnumerable<NotesModel> GetPinnedNoteList(String email);
        bool DoTrash(string email, int noteid);
        IEnumerable<NotesModel> GetTrashNoteList(string email);
        bool DoRestore(string email, int noteid);
    }
}
