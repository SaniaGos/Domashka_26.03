using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingHouse.Klasses
{
    internal class Project
    {
        public int Basement { get; }
        public int Walls { get; }
        public int Roof { get; }
        public int Doors { get; }
        public int Windows { get; }
        public Project(int basement, int walls, int roofs, int windows, int doors)
        {
            Basement = basement;
            Walls = walls;
            Roof = roofs;
            Doors = doors;
            Windows = windows;
        }
    }
}
