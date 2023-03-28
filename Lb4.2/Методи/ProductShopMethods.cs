using Lb4._2.Продукти;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb4._2.Методи
{
    internal class ProductShopMethods
    {
        public static void PriceSort(List<Products> products)
        {
            Console.Clear();
            var sorted = products.OrderBy(prod => prod.Price);
            Console.WriteLine("Продукти вiдсорторванi за цiною:");
            foreach (Products product in sorted)
            {
                Console.WriteLine($"--- Назва продукту: {product.Name}. Цiна: {product.Price}");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Щоб вийти на головну сторiнку натиснiть Enter. Щоб вийти з програми натиснiть Esc");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void TypeSort(List<Products> products)
        {
            Console.Clear();
            Console.WriteLine("Продукти вiдсорторванi за типом:");
            var sorted = products.GroupBy(p => p.GetType());
            foreach (var type in sorted)
            {
                Console.WriteLine($"Тип продукту {type.First().GetType().Name}:");
                foreach (Products product in type)
                {
                    Console.WriteLine($"--- {product.Name}");
                }
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Щоб вийти на головну сторiнку натиснiть Enter. Щоб вийти з програми натиснiть Esc");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void ExpiredProducts(List<Products> products)
        {
            Console.Clear();
            Console.WriteLine("Простроченi товари: ");
            var expiredFood = products.Where(p => p is Food food && food.ProductIsExpired);
            Console.WriteLine("*Прострочена iжа: ");
            foreach (Food product in expiredFood)
            {
                Console.WriteLine($"--- {product.Name}. Треба було вжити до: {product.Expiration_date}");
            }
            var expiredDrinks = products.Where(p => p is Drink drink && drink.ProductIsExpired);
            Console.WriteLine("*Простроченi напоi: ");
            foreach (Drink product in expiredDrinks)
            {
                Console.WriteLine($"--- {product.Name}. Треба було вжити до: {product.Expiration_date}");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Щоб вийти на головну сторiнку натиснiть Enter. Щоб вийти з програми натиснiть Esc");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void ProductsJanuary2020(List<Products> products)
        {
            Console.Clear();
            Console.WriteLine("Продукти, якi були виготовленi у сiчнi 2020 року: ");
            var jan2020prod = products.Where(p => p.Date_of_creation.Year == 2020 && p.Date_of_creation.Month == 1);
            foreach (Products product in jan2020prod)
            {
                Console.WriteLine($"--- {product.Name}");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Щоб вийти на головну сторiнку натиснiть Enter. Щоб вийти з програми натиснiть Esc");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void TimePeriodProducts(List<Products> products)
        {
            Console.Clear();
            Console.WriteLine("Пошук продуктiв за промiжком часу.");
            Console.Write("*Введiть початкову дату у форматi (рррр-мм-дд): ");
            DateTime startDate = DateTime.Parse(Console.ReadLine());
            Console.Write("*Введiть кiнцеву дату у форматi (рррр-мм-дд): ");
            DateTime finishDate = DateTime.Parse(Console.ReadLine());
            var prodprom = products.Where(p => p.Date_of_creation > startDate && p.Date_of_creation < finishDate);
            Console.WriteLine();
            Console.WriteLine($"Продукти, якi були виготовленi у перiод з {startDate} по {finishDate}");
            foreach (Products product in prodprom)
            {
                Console.WriteLine($"--- {product.Name}");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Щоб вийти на головну сторiнку натиснiть Enter. Щоб вийти з програми натиснiть Esc");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
