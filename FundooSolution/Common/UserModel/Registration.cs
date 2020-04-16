using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Common.UserModel
{
   public class Registration
    {
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        public int MobileNumber { get; set; }
        [Required]
        public string Email { get; set; }
        [MaxLength(8), MinLength(4), Required]
        public string Password { get; set; }
       
    }
}
