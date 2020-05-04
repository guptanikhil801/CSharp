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
            return this.repository.DoAddNote(email,notemodel,file);
        }

        public bool Archive(string email, int id)
        {
            return this.repository.DoArchive(email, id);
        }

        public IEnumerable<NotesModel> ArchivedNoteList(string email)
        {
            return this.repository.GetArchivedNoteList(email);
        }

        public string CloudImage(IFormFile file)
        {
            return this.repository.MakeCloudImage(file);
        }

        public bool DeleteNote(string email, int id)
        {
           return this.repository.DoDeleteNote(email, id);
        }

        public IEnumerable<NotesModel> GetAllNotes(string email)
        {
            return this.repository.DoGetAllNotes(email);
        }

        public NotesModel GetNote(string email, int id)
        {
            return this.repository.DoGetNote(email, id);
        }

        public bool Pin(string email, int id)
        {
            return this.repository.DoPin(email, id);
        }

        public IEnumerable<NotesModel> PinnedNoteList(string email)
        {
            return this.repository.GetPinnedNoteList(email);
        }


        public bool Restore(string email, int noteid)
        {
            return this.repository.DoRestore(email, noteid);
        }

        public List<NotesModel> SearchNotes(string email, string searchquery)
        {
            return this.repository.SearchNotes(email, searchquery);
        }

        public bool Trash(string email, int noteid)
        {
            return this.repository.DoTrash(email, noteid);
        }

        public IEnumerable<NotesModel> TrashNoteList(string email)
        {
            return this.repository.GetTrashNoteList(email);
        }

        public bool UpdateNote(string email, NewNote note,int id)
        {
            return this.repository.DoUpdateNote(email, note,id);
        }

        public bool UpdateNoteImage(string email, int noteid, IFormFile imagefile)
        {
            return this.repository.DoUpdateNoteImage(email, noteid, imagefile);
        }
    }
}
