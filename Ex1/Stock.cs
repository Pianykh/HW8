using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex1
{
    public static class Stock
    {
        private static readonly List<Product> _stock = new List<Product>();

        static Stock()
        {
            _stock.Add(new Product("Apple", 4, 2.4));
            _stock.Add(new Product("Apricot", 15, 3.5));
            _stock.Add(new Product("Pineapple", 1, 5.8));
            _stock.Add(new Product("Kiwi", 10, 0.8));
            _stock.Add(new Product("Lime", 310, 3.8));
            _stock.Add(new Product("Mango", 13, 8.8));
            _stock.Add(new Product("Melon", 9, 2.6));
            _stock.Add(new Product("Pear", 3, 1.8));
            _stock.Add(new Product("Peach", 6, 5.2));
            _stock.Add(new Product("Orange", 2, 3.8));
        }

        public static void StockAddProduct(Product product)
        {
            foreach (var currentProduct in _stock.Where(currentProduct => currentProduct.Title == product.Title))
            {
                currentProduct.Quantity += product.Quantity;
                Console.WriteLine("The product has been moved to the stock");
                return;
            }

            _stock.Add(product);
            Console.WriteLine("The product has been moved to the stock");
        }

        public static void StockGiveProduct(string title, int quantity)
        {
            if (HasProduct(title))
                foreach (var product in _stock.Where(product => product.Title == title))
                {
                    if (product.Quantity >= quantity)
                    {
                        product.Quantity -= quantity;
                        Console.WriteLine("Successful purchase");
                        break;
                    }
                    Console.WriteLine($"Not enough {title} on stock. ");
                    break;
                }
            else
                Console.WriteLine($"No {title} on stock");
        }

        public static bool HasProduct(string title)
        {
            return _stock.Any(product => product.Title == title);
        }

        public static void ShowAll()
        {
            foreach (var product in _stock)
                Console.WriteLine($"{product.Title}. Price: {product.Price}. Quantity: {product.Quantity}");

        }

        public static void DestroyProduct(string title)
        {
            if (HasProduct(title))
                foreach (var product in _stock.Where(product => product.Title == title))
                {
                    _stock.Remove(product);
                    break;
                }
            else
                Console.WriteLine($"No {title} on stock");
        }

        public static bool GetPrice(string title, int quantity, out double price)
        {
            if (HasProduct(title))
                foreach (var product in _stock.Where(product => product.Title == title))
                {
                    price = product.Price * quantity;
                    return true;
                }
            price = 0;
            return false;
        }

        public static Product GetProductByTitle(string title)
        {
            return _stock.FirstOrDefault(product => product.Title == title);
        }
    }
}