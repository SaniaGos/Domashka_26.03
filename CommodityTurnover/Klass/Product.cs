using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace CommodityTurnover.Klass
{
    class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }

        public Category Category { get; set; }

        public override string ToString()
        {
            return $"Product Name: {ProductName} Prise:{Price}, Id:{Id}, Category:{Category.Name}";
        }
      
    }
}
