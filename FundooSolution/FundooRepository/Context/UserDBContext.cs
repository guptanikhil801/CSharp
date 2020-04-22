// -------------------------------------------------------------------------------------------------------
// <copyright file="UserDbContext.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Nikhil Gupta"/>
// -------------------------------------------------------------------------------------------------------
namespace FundooRepository.Context
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Text;
    using Common.UserModel;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// defining userdbcontext
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityDbContext{Common.UserModel.User}" />
    public class UserDBContext : IdentityDbContext<User>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserDBContext"/> class.
        /// </summary>
        /// <param name="options">The options.</param>
        public UserDBContext(DbContextOptions<UserDBContext> options) : base(options)
        {
        }

        /// <summary>
        /// Gets or sets the DbSet of Users.
        /// </summary>
        public new DbSet<User> Users { get; set; }

        /// <summary>
        /// Configures the schema needed for the identity framework.
        /// </summary>
        /// <param name="builder">The builder being used to construct the model for this context.</param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
