using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage.Classes;

namespace Storage.Interface
{
    interface ІSection
    {
        string Name { get; set; }
        List<Category> Categories { get; set; }
    }
}
