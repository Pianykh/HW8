/* 
1.Имеется магазин с продуктами, менеджер может добавлять и удалять продукты из склада, 
также может видеть весь список товаров 
Покупатель, имеет 50$ на покупки, он может только покупать товары и просматривать весь перечень, 
примерный вид Название| Цена, $| Кол-во|,
он может покупать определенное кол-во товаров, если его больше чем один. 
Стартовый набор товаров должен быть не менее 10.
*/

using System;
using System.Text;

namespace Ex1
{
    internal static class Program
    {
        private static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Controller.ShowMenu();
        }
    }
}
