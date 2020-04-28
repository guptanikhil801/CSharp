using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Common.ModelsOfNotes
{
   public class CollabModel
    {
        [Required]
        public string UserEmail { get; set; }
        public int NoteId { get; set; }
        [Key]
        public int collabId { get; set; }
        public string CollabratorEmail { get; set; }
    }
}
