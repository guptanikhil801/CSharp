namespace BookStoreRepository.Utility
{
    /// <summary>
    /// class for db access
    /// </summary>
    public class ConnectionString
    {
        /// <summary>
        /// The cname variable to use further
        /// </summary>
        private static string cName = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=BookStoreDb;Integrated Security=true";

        /// <summary>
        /// Gets the Cname.
        /// </summary>
        /// <value>
        /// The name of the CName.
        /// </value>
        public static string CName
        {
            get => cName;
        }
    }
}
