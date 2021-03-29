using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BuildingHouse.Klasses;

namespace BuildingHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Project project = new Project(1, 4, 1, 2, 1);
            Menu.MyMenu(project);
            
        }
    }
}
