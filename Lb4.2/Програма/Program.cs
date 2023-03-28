using Lb4._2.Програма;
using Lb4._2.Продукти;

Console.CursorVisible = false;
List<Products> products = new List<Products>()
        {
        new Food("Яблуко", 2.0, new DateTime(2023, 1, 1), new DateTime(2023, 2, 1)),
        new Food("Банан", 1.0, new DateTime(2023, 2, 14), new DateTime(2023, 3, 14)),
        new Food("Апельсин", 1.5, new DateTime(2023, 1, 5), new DateTime(2023, 3, 30)),

        new Drink("Кола", 0.33, new DateTime(2022, 1, 6), new DateTime(2023, 3, 6)),
        new Drink("Спрайт", 0.35, new DateTime(2023, 1, 8), new DateTime(2024, 3, 8)),
        new Drink("Фанта", 0.3, new DateTime(2023, 1, 10), new DateTime(2024, 3, 10)),

        new Other("Блокнот", 1.66, new DateTime(2020, 2, 12)),
        new Other("Ручка", 0.7, new DateTime(2023, 2, 12)),
        new Other("Oлiвець", 0.3, new DateTime(2020, 1, 4))
    };
StartProgram.Start(products);