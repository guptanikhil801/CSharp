// -------------------------------------------------------------------------------------------------------
// <copyright file="CollabratorManagerImpl.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -------------------------------------------------------------------------------------------------------

namespace BusinessManager.ImplementationClassManager
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using BusinessManager.InterfaceManager;
    using Common.ModelsOfNotes;
    using FundooRepository.InterfaceRepo;

    /// <summary>
    /// implementation class of  ICollabratorManager
    /// </summary>
    /// <seealso cref="BusinessManager.InterfaceManager.ICollabratorManager" />
    public class CollabratorManagerImpl : ICollabratorManager
    {
        private readonly CollabratorRepository repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="CollabratorManagerImpl"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        public CollabratorManagerImpl(CollabratorRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Adds the collabrator.
        /// </summary>
        /// <param name="useremail">The useremail.</param>
        /// <param name="collabemail">The collabemail.</param>
        /// <param name="noteid">The noteid.</param>
        /// <returns>
        /// true or false
        /// </returns>
        public bool AddCollabrator(string useremail, string collabemail, int noteid)
        {
            return this.repository.AddCollabrator(useremail, collabemail, noteid);
        }

        /// <summary>
        /// Gets all collabrator.
        /// </summary>
        /// <param name="useremail">The useremail.</param>
        /// <returns>
        /// all collabrators
        /// </returns>
        public IEnumerable<CollabModel> GetAllCollabrator(string useremail)
        {
            return this.repository.GetAllCollabrator(useremail);
        }

        /// <summary>
        /// Removes the collabrator.
        /// </summary>
        /// <param name="collabeid">The collabeid.</param>
        /// <returns>
        /// true or false
        /// </returns>
        public bool RemoveCollabrator(int collabeid)
        {
            return this.repository.RemoveCollabrator(collabeid);
        }
    }
}
