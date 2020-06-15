using Common.NotesModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FundooRepository.InterfaceRepo
{
   public interface ILabel
    {
        bool AddLabel(string Email, string Details);
        bool DeleteLabel(string Email, int LabelId);
        IEnumerable<Label> GetAllLabels(string Email, int LabelId);
        bool UpdateLabel(int LabelId, string Email, string Details);
    }
}
