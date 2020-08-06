namespace BookStoreModal.Modals
{
    /// <summary>
    /// class to deine Customer
    /// </summary>
    public class Customer
    {
        public int CustId { get; set; }
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>

        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        /// <value>
        /// The phone number.
        /// </value>
        public long PhoneNumber { get; set; }


        /// <summary>
        /// Gets or sets the email address for this user.
        /// </summary>

        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the profile picture.
        /// </summary>
        /// <value>
        /// The profile picture.
        /// </value>
        public string ProfilePicture { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public int PinCode { get; set; }


    }
}
