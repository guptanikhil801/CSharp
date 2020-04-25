namespace FundooRepository.ImplementationClassRepo
{
    using Common.ModelsOfLabel;
    using FundooRepository.Context;
    using FundooRepository.InterfaceRepo;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class LabelRepoImpl : ILabelRepository
    {
        private readonly UserDBContext dbcontext;

        public LabelRepoImpl(UserDBContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        public bool AddLabel(string email, string details)
        {
            if (email != null && details != null)
            {
                var newlabel = new LabelModel
                {
                    Email = email,
                    Details = details
                };
                this.dbcontext.Labels.Add(newlabel);
                this.dbcontext.SaveChanges();
                return true;
            }

            return false;
        }

        public bool DeleteLabel(string email, int labelid)
        {
            var label = dbcontext.Labels.FirstOrDefault(option => option.Email == email && option.LabelId == id);
            if (label != null)
            {
                dbcontext.Notes.Remove(label);
                var result = dbcontext.SaveChanges();
                if (result == 1)
                {
                    return true;
                }
            }

            return false;
        }

        public IEnumerable<LabelModel> GetAllLabels(string email)
        {
            throw new NotImplementedException();
        }

        public LabelModel GetLabel(string email, int labelid)
        {
            throw new NotImplementedException();
        }

        public bool Update(string email, int labelid)
        {
            throw new NotImplementedException();
        }
    }
}
