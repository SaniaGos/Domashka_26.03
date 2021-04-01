using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage.Classes;

namespace Storage
{
    class View
    {
        public static void Show(MyStorage storage)
        {
            foreach (Product item in storage)
            {
                Console.WriteLine(String.Format("{0}\t{1}\t{2}\t{3}"
                    , item.Name, item.Price, item.Category.Name, item.Id));
            }
            Console.Write("\n\n");
        }
        public static void Show(List<Category> category)
        {
            if (category is null) return;
            foreach (Category item in category)
            {
                Console.WriteLine(String.Format("{0}\t{1}"
                    , item.Name, item.Id));
            }
            Console.Write("\n\n");
        }
    }
}
