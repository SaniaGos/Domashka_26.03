using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingHouse.Klasses
{
    class House
    {
        public Documentation Documentation { get; set; }
        public Basement Basement { get; }
        public Walls Walls { get; }
        public Roof Roof { get; }
        public Window Window { get; }
        public Door Door { get; }
        public House(Project project)
        {
            Documentation = new Documentation(project);
            Basement = new Basement();
            Walls = new Walls();
            Roof = new Roof();
            Window = new Window();
            Door = new Door();
        }
    }
}
