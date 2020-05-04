// -------------------------------------------------------------------------------------------------------
// <copyright file="LabelManagerImpl.cs" company="Bridgelabz">
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
    using Common.ModelsOfLabel;
    using FundooRepository.InterfaceRepo;

    /// <summary>
    /// implementation class of ILabelManager
    /// </summary>
    /// <seealso cref="BusinessManager.InterfaceManager.ILabelManager" />
    public class LabelManagerImpl : ILabelManager
    {
        private readonly ILabelRepository repo;

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelManagerImpl"/> class.
        /// </summary>
        /// <param name="repo">The repo.</param>
        public LabelManagerImpl( ILabelRepository repo)
        {
            this.repo = repo;
        }

        /// <summary>
        /// Adds the label.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="details">The details.</param>
        /// <returns>
        /// true or false
        /// </returns>
        public bool AddLabel(string email, string details)
        {
            return repo.AddLabel(email, details);
        }

        /// <summary>
        /// Deletes the label.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="labelid">The labelid.</param>
        /// <returns>
        /// true or false
        /// </returns>
        public bool DeleteLabel(string email, int labelid)
        {
            return repo.DeleteLabel(email, labelid);
        }

        /// <summary>
        /// Gets all labels.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>
        /// all labels
        /// </returns>
        public IEnumerable<LabelModel> GetAllLabels(string email)
        {
            return repo.GetAllLabels(email);
        }

        /// <summary>
        /// Gets the label.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="labelid">The labelid.</param>
        /// <returns>
        /// the label
        /// </returns>
        public LabelModel GetLabel(string email, int labelid)
        {
            return repo.GetLabel(email, labelid);
        }

        /// <summary>
        /// Updates the label.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="labelid">The labelid.</param>
        /// <param name="details">The details.</param>
        /// <returns>
        /// true or false
        /// </returns>
        public bool UpdateLabel(string email, int labelid, string details)
        {
            return repo.UpdateLabel(email, labelid, details);
        }
    }
}
