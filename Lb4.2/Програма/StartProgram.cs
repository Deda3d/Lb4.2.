using Lb4._2.Методи;
using Lb4._2.Продукти;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb4._2.Програма
{
    internal class StartProgram
    {
        public static void Start(List<Products> products)
        {
            int nowchoosed = 0;
            string[] info = new string[5];
            bool metChoosed = false;
            bool exit = false;

            info[0] = "Вiдсортувати продукти за цiною";
            info[1] = "Вiдсортувати продукти за типом";
            info[2] = "Пошук продуктiв за промiжком часу";
            info[3] = "Пошук прострочених товарiв";
            info[4] = "Показати продукти, якi були виготовленi у сiчнi 2020 року";
            void PrintInfo()
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Головна сторiнка");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();

                for (int i = 0; i < info.Length; i++)
                {
                    if (nowchoosed == i) Console.ForegroundColor = ConsoleColor.DarkGray;
                    else Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(info[i]);
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Щоб пересуватися, використовуйте UpArrow, DownArrow. Щоб обрати - Enter. Вийти - Esc");
                Console.ForegroundColor = ConsoleColor.White;
            }
            while (exit == false)
            {
                if (metChoosed == false) PrintInfo();
                var x = Console.ReadKey(true).Key;
                switch (x)
                {
                    case ConsoleKey.UpArrow: if (metChoosed == false) if (nowchoosed - 1 >= 0) nowchoosed--; break;
                    case ConsoleKey.DownArrow: if (metChoosed == false) if (nowchoosed + 1 < info.Length) nowchoosed++; break;
                    case ConsoleKey.Enter:
                        if (metChoosed == false)
                        {
                            switch (nowchoosed)
                            {
                                case 0: ProductShopMethods.PriceSort(products); break;
                                case 1: ProductShopMethods.TypeSort(products); break;
                                case 2: ProductShopMethods.TimePeriodProducts(products); break;
                                case 3: ProductShopMethods.ExpiredProducts(products); break;
                                case 4: ProductShopMethods.ProductsJanuary2020(products); break;
                            }
                            metChoosed = true;
                        }
                        else metChoosed = false;
                        break;
                    case ConsoleKey.M: metChoosed = false; break;
                    case ConsoleKey.Escape: exit = true; break;
                }
                if (metChoosed == false && exit == false) Console.Clear();
            }
        }
    }
}
