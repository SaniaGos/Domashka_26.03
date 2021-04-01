using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Classes
{
    class Product : IComparer, IComparable<Product>
    {
        public string Name { get; set; }
        public int Id { get; private set; }
        public Category Category { get; set; }
        public int Price { get; set; }
        public Product(string name, int price, int id)
        {
            Name = name;
            Id = id;
            Price = price;
        }
        public static int CompareByName(Product first, Product second)
        {
            return String.Compare(first.Name, second.Name);
        }
        public static int CompareByPrise(Product first, Product second)
        {
            return first.Price.CompareTo(second.Price);
        }
        public int Compare(object x, object y)
        {
            return ((Product)x).Id.CompareTo((y as Product).Id);
        }
        public int CompareTo(Product other)
        {
            return this.Id.CompareTo(other.Id);
        }
    }
}
