using System;
using System.Collections.Generic;
using System.Text;

namespace Common.NotesModels
{
   public class Label
    {
        public int LabelId { get; set; }
        public int NoteId { get; set; }
        public string Details { get; set; }
    }
}
