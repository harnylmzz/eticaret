namespace eticaret.Entities
{
    public class Cart
    {
        public int CartId { get; set; }
        public string CustomerId { get; set; } = null!;

        // Boş liste ile başlat
        public List<CartItem> CartItems { get; set; } = new List<CartItem>();
    }

    public class CartItem
    {
        public int CartItemId { get; set; }
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        // Nullable olmayan ilişki
        public Product Product { get; set; } = null!;
        public Cart Cart { get; set; } = null!;
    }
}
