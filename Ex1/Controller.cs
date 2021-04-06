using System;

namespace Ex1
{
    public static class Controller
    {
        public static void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("Choo-o-oose you de-e-stinyy-y!!! (only in this program, not in general):");
                Console.WriteLine("1. Manager");
                Console.WriteLine("2. Customer");

                var isLogin = false;
                var answer = Console.ReadLine();
                var customer = new Customer();
                
                if (answer == "1" || answer == "2")
                    isLogin = true;
                else
                    Console.WriteLine("Please, enter the digit corresponding to the command");
                
                while (isLogin) { 
                    Console.WriteLine("Choose action: ");
                    
                    switch (answer)
                    {
                        case "1":
                            Console.WriteLine("1. Show products\n2. Add product\n3. Delete product\n0. Change destiny");
                            break;
                        case "2":
                            Console.WriteLine("1. Show products\n2. Buy product\n0. Change destiny");
                            break;
                        default:
                            isLogin = false;
                            break;
                    }
                    
                    switch (Console.ReadLine())
                    {
                        case "0": isLogin = false;
                            break;
                        case "1":
                            Stock.ShowAll();
                            break;
                        case "2" when answer == "1":
                            Manager.AddProduct(CreateProduct());
                            break;
                        case "2":
                            Console.WriteLine($"Available money: {customer.Money}");
                            Controller.BuyProduct(out var title, out var quantity);
                            customer.BuyProduct(title, quantity);
                            break;
                        case "3" when answer == "1":
                            Manager.DestroyProduct(Controller.DeleteProduct());
                            break;
                        default: Console.WriteLine("Please, enter the digit corresponding to the command");
                            break;
                    }
                }
            }
        }

        private static Product CreateProduct()
        {
            string title;
            double price;
            int quantity;

            while (true)
            {
                Console.WriteLine("Please, enter title:");
                title = Console.ReadLine();
                if (title != "")
                    break;
                Console.WriteLine("Title can not be empty. Try again");
            }

            if (!Stock.HasProduct(title))
                
                while (true)
                {
                    Console.WriteLine("Please, enter price:");
                    if (!double.TryParse(Console.ReadLine(), out price))
                    {
                        Console.WriteLine("The price can only be numerical. Try again");
                        continue;
                    }
                    if (price > 0)
                        break;
                    Console.WriteLine("Price can not be zero or less. Try again");
                }
            else 
                price = Stock.GetProductByTitle(title).Price;

            while (true)
            {
                Console.WriteLine("Please, enter quantity:");
                if (!int.TryParse(Console.ReadLine(), out quantity))
                {
                    Console.WriteLine("The quantity can only be integer. Try again");
                    continue;
                }
                if (quantity > 0)
                    break;
                Console.WriteLine("Quantity can not be zero or less. Try again");
            }
            return new Product(title, quantity, price);
        }

        private static string DeleteProduct()
        {
            string title;

            while (true)
            {
                Console.WriteLine("Please, enter title:");
                title = Console.ReadLine();
                if (title != "")
                    break;
                Console.WriteLine("Title can not be empty. Try again.");
            }

            return title;
        }

        private static void BuyProduct(out string title, out int quantity)
        {
            while (true) 
            {
                Console.WriteLine("Please, enter title:");
                title = Console.ReadLine();
                if (title != "")
                    break;
                Console.WriteLine("Title can not be empty. Try again");
            }
            
            while (true)
            {
                Console.WriteLine("Please, enter quantity:");
                if (!int.TryParse(Console.ReadLine(), out quantity)) continue;
                if (quantity > 0)
                    break;
                Console.WriteLine("Quantity can not be zero or less. Try again");
            }
        }
    }
}