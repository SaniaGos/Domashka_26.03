using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommodityTurnover.Klass;

namespace CommodityTurnover
{
    static class View
    {
        public static void ViewProduct(Product product, string str = "")
        {
            Console.WriteLine($"\n{str}  {product} ");
        }
    }
}
