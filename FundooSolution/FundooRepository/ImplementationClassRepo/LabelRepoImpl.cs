namespace FundooRepository.ImplementationClassRepo
{
    using Common.ModelsOfLabel;
    using FundooRepository.InterfaceRepo;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class LabelRepoImpl : ILabelRepository
    {
        public bool AddLabel(string email, string details)
        {
            throw new NotImplementedException();
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
