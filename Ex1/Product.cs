namespace Ex1
{
    public class Product
    {
        public string Title { get; }
        public int Quantity { get; set; }

        public double Price { get; }

        public Product(string title, int quantity, double price)
        {
            Title = title;
            Quantity= quantity;
            Price = price;
        }
    }
}