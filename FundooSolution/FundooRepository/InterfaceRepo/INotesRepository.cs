namespace FundooRepository.InterfaceRepo
{
    using Common.ModelsOfNotes;
    using Microsoft.AspNetCore.Http;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public interface INotesRepository
    {
        string CloudImage(IFormFile file);
        bool AddNote(string email, NewNote notemodel, IFormFile file);
        List<NotesModel> PutDataToCache(string email);
        List<NotesModel> RetreiveDataFromCache(string key);
        NotesModel GetNote(string email, int id);
        IEnumerable<NotesModel> GetAllNotes(string email);
        bool UpdateNote(NewNote note);
        bool DeleteNote(string email, int id);
        bool UpdateNoteImage(int noteid, IFormFile imagefile);
        bool Archive(string email, int id);
        IEnumerable<NotesModel> ArchivedNoteList(String email);
        bool Pin(string email, int id);
        IEnumerable<NotesModel> PinnedNoteList(String email);
    }
}
