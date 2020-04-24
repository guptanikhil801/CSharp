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

    public class NotesManagerImpl : INotesManager
    {
        private readonly INotesRepository repository;

        public NotesManagerImpl( INotesRepository repository)
        {
            this.repository = repository;
        }

        public bool AddNote(string email, NewNote notemodel, IFormFile file)
        {
            throw new NotImplementedException();
        }

        public bool Archive(string email, int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NotesModel> ArchivedNoteList(string email)
        {
            throw new NotImplementedException();
        }

        public string CloudImage(IFormFile file)
        {
            throw new NotImplementedException();
        }

        public bool DeleteNote(string email, int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NotesModel> GetAllNotes(string email)
        {
            throw new NotImplementedException();
        }

        public NotesModel GetNote(string email, int id)
        {
            throw new NotImplementedException();
        }

        public bool Pin(string email, int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NotesModel> PinnedNoteList(string email)
        {
            throw new NotImplementedException();
        }

        public List<NotesModel> PutDataToCache(string email)
        {
            throw new NotImplementedException();
        }

        public bool Restore(string email, int noteid)
        {
            throw new NotImplementedException();
        }

        public List<NotesModel> RetreiveDataFromCache(string key)
        {
            throw new NotImplementedException();
        }

        public bool Trash(string email, int noteid)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NotesModel> TrashNoteList(string email)
        {
            throw new NotImplementedException();
        }

        public bool UpdateNote(string email, NewNote note)
        {
            throw new NotImplementedException();
        }

        public bool UpdateNoteImage(string email, int noteid, IFormFile imagefile)
        {
            throw new NotImplementedException();
        }
    }
}
