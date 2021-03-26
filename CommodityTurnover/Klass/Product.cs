using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace CommodityTurnover.Klass
{
    class Product
    {
        private class SortByNameHelper : IComparer
        {
            public int Compare(object x, object y)
            {
                return (x as Product).ProductName.CompareTo((y as Product).ProductName);
            }
        }

        private class SortByPriceHelper : IComparer
        {
            public int Compare(object x, object y)
            {
                return (x as Product).Price.CompareTo((y as Product).Price);
            }
        }
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }

        public Category Category { get; set; }

        public override string ToString()
        {
            return $"Product Name: {ProductName} Prise:{Price}, Id:{Id}, Category:{Category.Name}";
        }
        public static IComparer SortByName()
        {
            return new SortByNameHelper();
        }
        public static IComparer SortByPrice()
        {
            return new SortByPriceHelper();
        }


    }
}
