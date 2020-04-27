namespace BusinessManager.ImplementationClassManager
{
    using BusinessManager.InterfaceManager;
    using Common.ModelsOfLabel;
    using FundooRepository.InterfaceRepo;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class LabelManagerImpl : ILabelManager
    {
        private readonly ILabelRepository repo;

        public LabelManagerImpl( ILabelRepository repo)
        {
            this.repo = repo;
        }

        public bool AddLabel(string email, string details)
        {
            return repo.AddLabel(email, details);
        }

        public bool DeleteLabel(string email, int labelid)
        {
            return repo.DeleteLabel(email, labelid);
        }

        public IEnumerable<LabelModel> GetAllLabels(string email)
        {
            return repo.GetAllLabels(email);
        }

        public LabelModel GetLabel(string email, int labelid)
        {
            return repo.GetLabel(email, labelid);
        }

        public bool UpdateLabel(string email, int labelid, string details)
        {
            return repo.UpdateLabel(email, labelid, details);
        }
    }
}
