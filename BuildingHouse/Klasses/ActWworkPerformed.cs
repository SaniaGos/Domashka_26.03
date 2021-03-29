using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingHouse.Klasses
{
    class ActWorkPerformed
    {
        public bool BasementFinish { get; private set; }
        public bool WallsFinish { get; private set; }
        public bool RoofFinish { get; private set; }
        public bool DoorFinish { get; private set; }
        public bool WindowFinish { get; private set; }
        public ActWorkPerformed()
        {
            BasementFinish = false;
            WallsFinish = false;
            RoofFinish = false;
            DoorFinish = false;
            WindowFinish = false;
        }
        public void Besement_Finish()
        {
            BasementFinish = true;
        }
        public void Walls_Finish()
        {
            if (BasementFinish)
                WallsFinish = true;
        }
        public void Roof_Finish()
        {
            if (WallsFinish)
                RoofFinish = true;
        }
        public void Door_Finish()
        {
            if (WallsFinish)
                DoorFinish = true;
        }
        public void Window_Finish()
        {
            if (WallsFinish)
                WindowFinish = true;
        }
        public bool HouseIsFinish()
        {
            if (WallsFinish && BasementFinish && RoofFinish && DoorFinish && WindowFinish)
                return true;
            else return false;
        }
    }
}
