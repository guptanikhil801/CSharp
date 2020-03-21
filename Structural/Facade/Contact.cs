namespace DesignPattern.Structural.Facade
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public  class Contact
    {
        /// <summary>
        /// Gets or sets FirstName
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets FirstName
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets PhoneNumber
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets Address
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets city
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets State
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Gets or sets zip
        /// </summary>
        public string Zip { get; set; }

        /// <summary>
        /// to override object to string
        /// </summary>
        /// <returns>the string</returns>
        public override string ToString()
        {
            return string.Format("FirtsName:   {0}\nlastName:    {1}\n" +
                "phoneNumber: {2}\ncity:        {3}\nstate:       {4}\nzip:         {5}\naddress:     {6}",
                 this.FirstName, this.LastName, this.PhoneNumber, this.City, this.State, this.Zip, this.Address);
        }
    }
}