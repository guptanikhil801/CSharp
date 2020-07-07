namespace BookStoreModal.Modals
{
    public class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public int AvailableStock { get; set; }
        public double Rating { get; set; }
        public string Review { get; set; }
    }
}
