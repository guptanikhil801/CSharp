namespace FundooRepository.InterfaceRepo
{
    using Common.ModelsOfLabel;
    using System;
    using System.Collections.Generic;
    using System.Text;

   public interface ILabelRepository
    {
        bool AddLabel(string email, string details);
        LabelModel GetLabel(string email, int labelid);
        IEnumerable<LabelModel> GetAllLabels(string email);
        bool Update(string email, int labelid);
        bool Delete(string email, int labelid);

    }
}
