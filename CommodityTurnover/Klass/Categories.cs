using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommodityTurnover.Klass;

namespace CommodityTurnover
{
    static class Categories
    {
        public static Category[] Categoriess { get; private set; }
        static Categories()
        {
            Categoriess = new Category[]
            {
                new Category { Name = "Toys", Id = 1 },
                new Category { Name = "Household chemicals", Id = 2 },
                new Category { Name = "Food", Id = 3 }
            };
        }
    }
}
