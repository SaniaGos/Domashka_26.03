using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommodityTurnover.Klass
{
    class MovementOfGoods : IEnumerable
    {
        private List<Product> products;
        public MovementOfGoods()
        {
            products = new List<Product>();
        }
        public void InCome(Product product)
        {
            products.Add(product);
        }
        public void OutCome(int iter)
        {
            try
            {
                products.RemoveAt(iter);
            }
            catch (Exception)
            {
                throw new Exception("\nItem not found");
            }
        }
        public Product this[int iter]
        {
            get
            {
                if (iter >= 0 && iter < products.Count)
                    return products[iter];

                else throw new Exception("\nItem not found");
            }
        }
        public int FindElement(int id)
        {
            return products.FindIndex(p => p.Id == id);
        }
        public IEnumerator GetEnumerator()
        {
            return products.GetEnumerator();
        }
    }
}
