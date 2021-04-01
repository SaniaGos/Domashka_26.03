using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage.Classes;

namespace Storage.Interface
{
    interface IStorage
    {
        double Squere { get; set; }
        string Name { get; set; }
        List<Product> Products { get; set; }
    }
}
