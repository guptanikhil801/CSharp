﻿// -------------------------------------------------------------------------------------------------------
// <copyright file="ILabelManager.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using Common.ModelsOfLabel;
namespace BusinessManager.InterfaceManager
{
   public interface ILabelManager
    {
        /// <summary>
        /// Adds the label.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="details">The details.</param>
        /// <returns>true or false</returns>
        bool AddLabel(string email, string details);

        /// <summary>
        /// Gets the label.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="labelid">The labelid.</param>
        /// <returns>the label</returns>
        LabelModel GetLabel(string email, int labelid);

        /// <summary>
        /// Gets all labels.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>all labels</returns>
        IEnumerable<LabelModel> GetAllLabels(string email);

        /// <summary>
        /// Updates the label.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="labelid">The labelid.</param>
        /// <param name="details">The details.</param>
        /// <returns>true or false</returns>
        bool UpdateLabel(string email, int labelid, string details);

        /// <summary>
        /// Deletes the label.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="labelid">The labelid.</param>
        /// <returns>true or false</returns>
        bool DeleteLabel(string email, int labelid);
    }
}
