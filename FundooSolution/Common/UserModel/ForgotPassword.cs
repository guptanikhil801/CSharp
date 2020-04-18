using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Common.UserModel
{
    public class ForgotPassword
    {
        [Required]
        public string Email { get; set; }
    }
}
