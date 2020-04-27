using Common.ModelsOfLabel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessManager.InterfaceManager
{
   public interface ILabelManager
    {
        bool AddLabel(string email, string details);
        LabelModel GetLabel(string email, int labelid);
        IEnumerable<LabelModel> GetAllLabels(string email);
        bool UpdateLabel(string email, int labelid, string details);
        bool DeleteLabel(string email, int labelid);
    }
}
