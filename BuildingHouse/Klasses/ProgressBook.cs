using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingHouse.Klasses
{
    class ProgressBook
    {
        public int Basement { get; set; }
        public int Walls { get; set; }
        public int Roof { get; set; }
        public int Doors { get; set; }
        public int Windows { get; set; }
        public ProgressBook()
        {
            Basement = 0;
            Walls = 0;
            Roof = 0;
            Doors = 0;
            Windows = 0;
        }
        public static bool operator ==(Project project, ProgressBook dayBook)
        {
            if (
                project.Basement == dayBook.Basement &&
                project.Walls == dayBook.Walls &&
                project.Roof == dayBook.Roof &&
                project.Windows == dayBook.Windows &&
                project.Doors == dayBook.Doors
                ) return true;
            else return false;
        }
        public static bool operator !=(Project project, ProgressBook dayBook)
        {
            return !(project == dayBook);
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
