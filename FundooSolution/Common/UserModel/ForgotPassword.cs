namespace Common.UserModel
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.ComponentModel.DataAnnotations;
    
    public class ForgotPassword
    {
        [Required]
        public string Email { get; set; }
    }
}
