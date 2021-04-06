using System;

namespace Ex1
{
    public class Customer
    {
        public double Money { get; set; }

        public Customer()
        {
            Money = 50;
        }
        public void ShowAllProducts()
        {
            Stock.ShowAll();
        }

        public void BuyProduct(string title, int quantity)
        {
            
            if (Stock.GetPrice(title, quantity, out var price))
            {
                if (price <= Money)
                {
                    Stock.StockGiveProduct(title, quantity);
                    Money -= price;
                }
                else
                    Console.WriteLine("Not enough money!");
            }
            else
                Console.WriteLine($"No {title} on stock");
        }
    }
}