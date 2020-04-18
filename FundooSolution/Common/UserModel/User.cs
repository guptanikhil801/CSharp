
namespace Common.UserModel
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.AspNetCore.Identity;

    public class User : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Key,Required]
        public override string Email { get; set; }
    }
}
