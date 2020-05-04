// -------------------------------------------------------------------------------------------------------
// <copyright file="CollabratoImpl.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -------------------------------------------------------------------------------------------------------

namespace FundooRepository.ImplementationClassRepo
{
    using Common.ModelsOfNotes;
    using FundooRepository.Context;
    using FundooRepository.InterfaceRepo;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// implementation class of CollabratorRepository
    /// </summary>
    /// <seealso cref="FundooRepository.InterfaceRepo.CollabratorRepository" />
    public class CollabratorImpl : CollabratorRepository
    {
        /// <summary>
        /// The dbcontext
        /// </summary>
        private readonly UserDBContext dbcontext;

        /// <summary>
        /// Initializes a new instance of the <see cref="CollabratorImpl"/> class.
        /// </summary>
        /// <param name="dbcontext">The dbcontext.</param>
        public CollabratorImpl( UserDBContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        /// <summary>
        /// Adds the collabrator.
        /// </summary>
        /// <param name="useremail">The useremail.</param>
        /// <param name="collabemail">The collabemail.</param>
        /// <param name="noteid">The noteid.</param>
        /// <returns>boolean value</returns>
        public bool AddCollabrator(string useremail, string collabemail, int noteid)
        {
            if(useremail!=null && collabemail!=null )
            {
                var newcollab = new CollabModel
                {
                    UserEmail = useremail,
                    CollabratorEmail = collabemail,
                    NoteId = noteid
                };
                this.dbcontext.Collabrators.Add(newcollab);
                if(dbcontext.SaveChanges() == 1)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Gets all collabrator.
        /// </summary>
        /// <param name="useremail">The useremail.</param>
        /// <returns>boolean value</returns>
        public IEnumerable<CollabModel> GetAllCollabrator(string useremail)
        {
            var allcollab = dbcontext.Collabrators.Where(op => op.UserEmail == useremail);
            return allcollab;
        }

        /// <summary>
        /// Removes the collabrator.
        /// </summary>
        /// <param name="collabeid">The collabeid.</param>
        /// <returns>boolean value</returns>
        public bool RemoveCollabrator(int collabeid)
        {
            var collabarator = dbcontext.Collabrators.FirstOrDefault(op => op.collabId == collabeid);
            if(collabarator != null)
            {
                this.dbcontext.Collabrators.Add(collabarator);
                if( this.dbcontext.SaveChanges() == 1)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
