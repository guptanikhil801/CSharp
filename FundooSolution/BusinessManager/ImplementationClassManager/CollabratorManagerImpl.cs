namespace BusinessManager.ImplementationClassManager
{
    using BusinessManager.InterfaceManager;
    using Common.ModelsOfNotes;
    using FundooRepository.InterfaceRepo;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class CollabratorManagerImpl : ICollabratorManager
    {
        private readonly CollabratorRepository repository;

        public CollabratorManagerImpl(CollabratorRepository repository)
        {
            this.repository = repository;
        }

        public bool AddCollabrator(string useremail, string collabemail, int noteid)
        {
            return this.repository.AddCollabrator(useremail, collabemail, noteid);
        }

        public IEnumerable<CollabModel> GetAllCollabrator(string useremail)
        {
            return this.repository.GetAllCollabrator(useremail);
        }

        public bool RemoveCollabrator(int collabeid)
        {
            return this.repository.RemoveCollabrator(collabeid);
        }
    }
}
