namespace BookStoreModal.Modals
{
    public class BookInCart
    {
        public int CartId { get; set; }
        public int BookId { get; set; }
        public int BookQuantity { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
    }
}
