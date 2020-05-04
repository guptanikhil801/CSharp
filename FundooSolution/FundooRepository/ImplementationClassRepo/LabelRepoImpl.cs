// -------------------------------------------------------------------------------------------------------
// <copyright file="LabelRepoImpl.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -------------------------------------------------------------------------------------------------------

namespace FundooRepository.ImplementationClassRepo
{
    using Common.ModelsOfLabel;
    using FundooRepository.Context;
    using FundooRepository.InterfaceRepo;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// implementation class of ILabelRepository
    /// </summary>
    /// <seealso cref="FundooRepository.InterfaceRepo.ILabelRepository" />
    public class LabelRepoImpl : ILabelRepository
    {
        /// <summary>
        /// The dbcontext
        /// </summary>
        private readonly UserDBContext dbcontext;

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelRepoImpl"/> class.
        /// </summary>
        /// <param name="dbcontext">The dbcontext.</param>
        public LabelRepoImpl(UserDBContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        /// <summary>
        /// Adds the label.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="details">The details.</param>
        /// <returns>boolean value</returns>
        public bool AddLabel(string email, string details)
        {
            if (email != null && details != null)
            {
                var newlabel = new LabelModel
                {
                    Email = email,
                    Details = details
                };
                this.dbcontext.Labels.Add(newlabel);
                this.dbcontext.SaveChanges();
                return true;
            }

            return false;
        }

        /// <summary>
        /// Deletes the label.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="labelid">The labelid.</param>
        /// <returns>boolean value</returns>
        public bool DeleteLabel(string email, int labelid)
        {
            var label = dbcontext.Labels.FirstOrDefault(option => option.Email == email && option.LabelId == labelid);
            if (label != null)
            {
                dbcontext.Labels.Remove(label);
                var result = dbcontext.SaveChanges();
                if (result == 1)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Gets all labels.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>all labels</returns>
        public IEnumerable<LabelModel> GetAllLabels(string email)
        {
            var labels = dbcontext.Labels.Where(option => option.Email == email);
            return labels;
        }

        /// <summary>
        /// Gets the label by Id
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="labelid">The labelid.</param>
        /// <returns>label by id</returns>
        public LabelModel GetLabel(string email, int labelid)
        {
            var label = dbcontext.Labels.FirstOrDefault(option => option.Email == email && option.LabelId == labelid);
            return label;
        }

        /// <summary>
        /// Updates the label.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="labelid">The labelid.</param>
        /// <param name="details">The details.</param>
        /// <returns>true or false</returns>
        public bool UpdateLabel(string email, int labelid, string details)
        {
            var label = dbcontext.Labels.FirstOrDefault(option => option.Email == email && option.LabelId == labelid);
            if(label!=null && details!=null)
            {
                label.Details = details;
                this.dbcontext.Labels.Update(label);
                if (this.dbcontext.SaveChanges() == 1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
