using System;
using System.Collections.Generic;
using System.Text;

namespace Common.ModelsOfNotes
{
   public class NewNote
    {
        public int NoteId { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Colour { get; set; }
        public string Reminder { get; set; }
    }
}
