using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Classes
{
    class Category
    {
        public string Name { get; set; }
        public int Id { get; private set; }
        public Category(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }
}
