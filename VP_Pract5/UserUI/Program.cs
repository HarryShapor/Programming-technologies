using LibraryLINQ;
using System.Linq;

namespace UserUI
{
    public class Program
    {
        public static void Main(string[] args)
        {

            List<Item> listItem = new List<Item>
            {
                new Item("001","Рюкзак тактический","Черный", 3500 ,"ООО \"Военное снаряжение\"",new DateOnly(2023,05,15)),
                new Item("002","Нож складной","Стальной", 1500,"ИП \"Оружейный мастер\"",new DateOnly(2023,03,20)),
                new Item("003","Комплект термобелья","Темно-синий", 2500,"ЗАО \"Тепло и комфорт\"",new DateOnly(2023,04,10)),
                new Item("004","Фляга алюминиевая","Серебристый", 800,"ООО \"Кемпинг и отдых\"",new DateOnly(2023,06,01)),
                new Item("005","Костюм защитный","Olive Drab", 5000,"ООО \"Тактическое снаряжение\"",new DateOnly(2023,02,25)),
                new Item("006","Ботинки военные","Черный", 4500,"ЗАО \"Обувь для армии\"",new DateOnly(2023,01,30)),
                new Item("007","Фонарик тактический","Черный", 1200,"ООО \"Кемпинг и отдых\"",new DateOnly(2023,06,05)),
                new Item("008","Спальный мешок","Зеленый",3000,"ООО \"Кемпинг и отдых\"",new DateOnly(2023,04,15)),
                new Item("009","Компас военный","Серый", 900,"ЗАО \"Навигация\"",new DateOnly(2023,04,15)),
                new Item("010","Аптечка тактическая","Красный",2000 ,"ИП \"Забота о здоровье\"",new DateOnly(2023,06,20))
            };
            Console.WriteLine("Начальный список:");
            foreach (var item in listItem)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------");
            var sortedItems = listItem
                                .OrderBy(item => item.Supplier)
                                .ThenBy(item => item.Title);
            Console.WriteLine("Список после группировки:");
            foreach (var item in sortedItems)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------");
            var sortedItems2 = from item in listItem
                               orderby item.Supplier, item.Title
                               select item;
            foreach (var item in sortedItems2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------");

            
            string supplier = "ИП \"Забота о здоровье\"";
            Console.WriteLine("Товары, где производитель " + supplier);
            var SupplierItems = listItem
                                .Where(item => item.Supplier == supplier);
            foreach (var item in SupplierItems)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------");
            var SupplierItems2 = from item in listItem
                                where item.Supplier == supplier
                                select item;
            foreach (var item in SupplierItems2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Три самых дорогих товара:");

            var richItems = listItem.OrderByDescending(item => item.Price).Take(3);
            foreach (var item in richItems)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------");
            var richItems2 = from item in listItem
                             orderby item.Price descending
                             select item;
            foreach (var item in richItems.Take(3))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Последний выпущенный товар:");
            var lastItem = listItem.OrderBy(item => item.ProductionDate).Last();
            Console.WriteLine(lastItem);
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------");

            var lastItem2 = from item in listItem
                            orderby item.ProductionDate descending
                            select item;
            Console.WriteLine(lastItem2.First());
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------");
            string name = "Спальный мешок";
            Console.WriteLine("Количество товаров с наименованием " + name);
            var countNameItems = listItem.Where(item => item.Title == name).Count();
            Console.WriteLine(countNameItems);
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------");
            var countNameItems2 = from item in listItem
                                  where item.Title == name
                                  select item;
            Console.WriteLine(countNameItems2.Count());
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("Поставщик");
            var richSupplierItems = listItem.Where(item => item.Price > 4000).Except(listItem.Where(item => item.Price <= 4000));

            foreach (var item in richSupplierItems)
            {
                Console.WriteLine(item.Supplier);
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------");

            var richSupplierItems2 = from item in listItem
                                     group item by item.Supplier into itemGroup
                                     where itemGroup.All(item => item.Price > 4000)
                                     select itemGroup.Key;

            foreach (var item in richSupplierItems2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("Товары, которые не поставлялись в этом году, либо их цена ниже средней цены всех товаров:");
            var yearAvgItems = listItem.Where(item => item.ProductionDate.Year != 2023 | item.Price < listItem.Average(item => item.Price));

            foreach (var item in yearAvgItems)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------");

            var yearAvgItems2 = from item in listItem
                                where item.ProductionDate.Year != 2023 |
                                        item.Price < (from it in listItem select it.Price).Average()
                                select item;

            foreach (var item in yearAvgItems)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------");
            
            Console.WriteLine("Наименованиея товаров в виде {Артикул} {Наименование} {Цвет}");
            var ItemsList = listItem.Select(item => "{" + item.Article + "}" + "{" + item.Title + "}" + "{" + item.Color + "}");
            foreach (var item in ItemsList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------");
            var ItemsList2 = from item in listItem
                             select "{" + item.Article + "}" + "{" + item.Title + "}" + "{" + item.Color + "}";
            foreach (var item in ItemsList2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Минимальная цена для каждого поставщика:");

            var minPriceItems = listItem.GroupBy(item => item.Supplier).Select(list => new { Supplier = list.Key, MinPrice = list.Min(n => n.Price) });
            foreach (var item in minPriceItems)
            {
                Console.WriteLine($"Поставщик: {item.Supplier}, Минимальная цена: {item.MinPrice}");
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------");
            var minPriceItems2 = from item in listItem
                                 group item by item.Supplier into supGroup
                                 select new { Supplier = supGroup.Key, MinPrice = supGroup.Min(i => i.Price) };
            foreach (var item in minPriceItems2)
            {
                Console.WriteLine($"Поставщик: {item.Supplier}, Минимальная цена: {item.MinPrice}");
            }
        }
    }
}
