// -------------------------------------------------------------------------------------------------------
// <copyright file="CollabratorRepository.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -------------------------------------------------------------------------------------------------------

namespace FundooRepository.InterfaceRepo
{
    using Common.ModelsOfNotes;
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// interface of collabrator
    /// </summary>
    public interface CollabratorRepository
    {
        /// <summary>
        /// Adds the collabrator.
        /// </summary>
        /// <param name="useremail">The useremail.</param>
        /// <param name="collabemail">The collabemail.</param>
        /// <param name="noteid">The noteid.</param>
        /// <returns>true or false</returns>
        bool AddCollabrator(string useremail, string collabemail, int noteid);

        /// <summary>
        /// Removes the collabrator.
        /// </summary>
        /// <param name="collabeid">The collabeid.</param>
        /// <returns>true or false</returns>
        bool RemoveCollabrator(int collabeid);

        /// <summary>
        /// Gets all collabrator.
        /// </summary>
        /// <param name="useremail">The useremail.</param>
        /// <returns>all collabrators</returns>
        IEnumerable<CollabModel> GetAllCollabrator(string useremail);
    }
}
