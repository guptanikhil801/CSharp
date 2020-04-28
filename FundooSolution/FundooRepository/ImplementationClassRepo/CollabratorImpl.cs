namespace FundooRepository.ImplementationClassRepo
{
    using Common.ModelsOfNotes;
    using FundooRepository.Context;
    using FundooRepository.InterfaceRepo;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class CollabratorImpl : CollabratorRepository
    {
        private readonly UserDBContext dbcontext;

        public CollabratorImpl( UserDBContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        public bool AddCollabrator(string useremail, string collabemail, int noteid)
        {
            if(useremail!=null && collabemail!=null )
            {
                var newcollab = new CollabModel
                {
                    UserEmail = useremail,
                    CollabratorEmail = collabemail,
                    NoteId = noteid
                };
                this.dbcontext.Collabrators.Add(newcollab);
                if(dbcontext.SaveChanges() == 1)
                {
                    return true;
                }
            }

            return false;
        }

        public IEnumerable<CollabModel> GetAllCollabrator(string useremail)
        {
            var allcollab = dbcontext.Collabrators.Where(op => op.UserEmail == useremail);
            return allcollab;
        }

        public bool RemoveCollabrator(int collabeid)
        {
            var collabarator = dbcontext.Collabrators.FirstOrDefault(op => op.collabId == collabeid);
            if(collabarator != null)
            {
                this.dbcontext.Collabrators.Add(collabarator);
                if( this.dbcontext.SaveChanges() == 1)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
