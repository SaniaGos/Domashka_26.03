using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage.Classes;

namespace Storage
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStorage storage = new MyStorage
            {
                Products = Exemple.Products,                // підключаєм базу продуктів
                Categories = Exemple.Categories             // підключаєм базу категорій
            };
               
            View.Show(storage);                             // відображаєм
            storage.Products.Sort(Product.CompareByName);   // сортуєм по імені
            View.Show(storage);                             // знаву відображаєм
            storage.Products.Sort(Product.CompareByPrise);  // сортуєм по ціні
            View.Show(storage);                             // як завжди відображаєм
            storage.Products.Sort();                        // сортування по замовчуванню відбувається по Id
            View.Show(storage);                             // як здогадалися, відображаєм

            View.Show(storage.Categories);                  // ах, да, про категорії забули

            Console.ReadLine();
        }
    }
}
