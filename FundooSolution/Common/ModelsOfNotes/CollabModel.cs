// -------------------------------------------------------------------------------------------------------
// <copyright file="CollabModel.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -------------------------------------------------------------------------------------------------------
namespace Common.ModelsOfNotes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    /// <summary>
    /// Model class for Collabrator
    /// </summary>
    public class CollabModel
    {
        /// <summary>
        /// Gets or sets the user email.
        /// </summary>
        /// <value>
        /// The user email.
        /// </value>
        [Required]
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
        [Key]
        public int collabId { get; set; }

        /// <summary>
        /// Gets or sets the collabrator email.
        /// </summary>
        /// <value>
        /// The collabrator email.
        /// </value>
        public string CollabratorEmail { get; set; }
    }
}
