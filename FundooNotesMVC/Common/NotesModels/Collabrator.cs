using System;
using System.Collections.Generic;
using System.Text;

namespace Common.NotesModels
{
   public class Collabrator
    {

        /// <summary>
        /// Gets or sets the user email.
        /// </summary>
        /// <value>
        /// The user email.
        /// </value>
        public string UserEmail { get; set; }

        /// <summary>
        /// Gets or sets the note identifier.
        /// </summary>
        /// <value>
        /// The note identifier.
        /// </value>
        public int NoteId { get; set; }

        /// <summary>
        /// Gets or sets the collab identifier.
        /// </summary>
        /// <value>
        /// The collab identifier.
        /// </value>
        public int CollabId { get; set; }

        /// <summary>
        /// Gets or sets the collabrator email.
        /// </summary>
        /// <value>
        /// The collabrator email.
        /// </value>
        public string CollabratorEmail { get; set; }
    }
}
