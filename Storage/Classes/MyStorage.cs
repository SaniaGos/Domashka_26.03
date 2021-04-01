using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage.Interface;

namespace Storage.Classes
{
    class MyStorage : IStorage, ІSection, IEnumerable<Product>
    {
        public double Squere { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
        string ІSection.Name { get; set; }
        public List<Category> Categories { get; set; }
        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)Products).GetEnumerator();
        }
        IEnumerator<Product> IEnumerable<Product>.GetEnumerator()
        {
            return Products.GetEnumerator();
        }
    }
}
