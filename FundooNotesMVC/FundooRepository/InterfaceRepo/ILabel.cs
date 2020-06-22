using Common.NotesModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FundooRepository.InterfaceRepo
{
   public interface ILabel
    {
        bool AddLabel(int NoteId, string Details);
        Label GetLabelByNoteId(int NoteId);
        bool DeleteLabel(int LabelId);      
        bool UpdateLabel(int LabelId, string Details);
    }
}
