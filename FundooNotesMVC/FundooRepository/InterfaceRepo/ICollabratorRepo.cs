using Common.NotesModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FundooRepository.InterfaceRepo
{
   public interface ICollabratorRepo
    {
        /// <summary>
        /// Adds the collabrator.
        /// </summary>
        /// <param name="useremail">The useremail.</param>
        /// <param name="collabemail">The collabemail.</param>
        /// <param name="noteid">The noteid.</param>
        /// <returns>true or false</returns>
        bool AddCollabrator(Collabrator model);

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
        IEnumerable<Collabrator> GetAllCollabrator(int noteid);
    }
}
