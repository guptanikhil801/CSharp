namespace Common.UserModel
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("UserTable")]
    public class User
    {
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        public int MobileNumber { get; set; }
        [Key]
        public string Email { get; set; }
        [MaxLength(8), MinLength(4)]
        public string Password { get; set; }
    }
}
