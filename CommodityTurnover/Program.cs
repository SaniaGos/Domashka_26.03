using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommodityTurnover.Klass;


namespace CommodityTurnover
{
    class Program
    {
        static void Main(string[] args)
        {
            // розширте консоль до 100 символів, бо можуть надписи не влізти і некрасиво виглядає

            Turnover turnover = new Turnover();
            turnover.IncomingItem(new Product[]  // Прийшли продукти в магаз
            {
                new Product { Id = 222, ProductName = "Sausages", Price = 109.99, Category = Categories.Categoriess[2] },
                new Product { Id = 203, ProductName = "Pizza", Price = 54.99, Category = Categories.Categoriess[2] },
                new Product { Id = 102, ProductName = "Laundry soap", Price = 9.99, Category = Categories.Categoriess[1] },
                new Product { Id = 145, ProductName = "ARIEL gel", Price = 99.99, Category = Categories.Categoriess[1] },
                new Product { Id = 322, ProductName = "Car", Price = 149.49, Category = Categories.Categoriess[0] }
            });
            turnover.RealizeItem(102); // продаєм один з товарів по Id
            turnover.RealizeItem(102); // пробуєм щераз продати, але його вже немає в магазі, видасть попереждення про відсутність товару
            turnover.WriteOffItem(203); // списуєм піцу, в ній якісь зелені гриби почали розти
            turnover.TransferItem(322); // передаєм машинку в інший магазин
            turnover.Remainder(); // залишок товару


            // всі маніпуляції, зберігаються в відповідних журналах




            Console.ReadLine();
        }
    }
}
