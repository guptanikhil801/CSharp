namespace FundooRepository.InterfaceRepo
{
    using Common.ModelsOfNotes;
    using System;
    using System.Collections.Generic;
    using System.Text;

   public interface CollabratorRepository
    {
        bool AddCollabrator(string useremail, string collabemail, int noteid);
        bool RemoveCollabrator(int collabeid);
        IEnumerable<CollabModel> GetAllCollabrator(string useremail);
    }
}
