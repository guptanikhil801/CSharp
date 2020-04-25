namespace FundooRepository.ImplementationClassRepo
{
    using Common.ModelsOfLabel;
    using FundooRepository.Context;
    using FundooRepository.InterfaceRepo;
    using System;
    using System.Collections.Generic;
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

        public bool Delete(string email, int labelid)
        {
            throw new NotImplementedException();
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
