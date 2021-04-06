namespace Ex1
{
    public static class Manager
    {
        public static void AddProduct(Product product)
        {
            Stock.StockAddProduct(product);
        }

        public static void DestroyProduct(string title)
        {
            Stock.DestroyProduct(title);
        }

        public static void ShowAllProducts()
        {
            Stock.ShowAll();
        }
    }
}