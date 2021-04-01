using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Classes
{
    class Exemple
    {
        internal static List<Category> Categories = new List<Category>
        {
             new Category("Toys", 1),
             new Category("Food", 2)
        };
        internal static List<Product> Products = new List<Product>
        {
          new Product("Doll", 500, 1),
          new Product("Lego", 300, 2),
          new Product("Candy", 100, 3),
          new Product("Apples", 150, 4)
        };
        static Exemple()
        {
            Products[0].Category = Categories[0];
            Products[1].Category = Categories[0];
            Products[2].Category = Categories[1];
            Products[3].Category = Categories[1];
        }
    }
}
