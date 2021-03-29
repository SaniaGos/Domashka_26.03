using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingHouse.Klasses
{
    class Team
    {
        private House house;
        private List<Worker> workers;
        public TeamLeader TeamLeader { get; }
        public readonly int maxWorkers;
        public Team(House house, int maxWorkers = 4)
        {
            this.maxWorkers = maxWorkers;
            this.house = house;
            TeamLeader = new TeamLeader(house);
            workers = new List<Worker>();
        }
        public void HireWorkers(int num = 1)
        {
            for (int i = 0; i < num; i++)
            {
                if (workers.Count < maxWorkers)
                {
                    workers.Add(new Worker());
                }
                else
                {
                    MyConsole.WriteInformation("The team is complete        ");
                }
            }
        }
        public void LayOffWorkers(int num = 1)
        {
            for (int i = 0; i < num; i++)
            {
                if (workers.Count > 0)
                {
                    workers.RemoveAt(0);
                }
                else MyConsole.WriteInformation("There are no employees in the team");
            }
        }
        public void BuildBasement()
        {
            if (workers.Count >= 2)
            {
                if (!house.Documentation.ActWorkPerformed.BasementFinish)
                {
                    if (house.Basement is null) throw new Exception("Basement is NULL");
                    house.Basement.DoBuild();
                    house.Documentation.ProgressBook.Basement++;
                    if (house.Documentation.ProgressBook.Basement == house.Documentation.Project.Basement)
                        house.Documentation.ActWorkPerformed.Besement_Finish();
                }
                else
                {
                    MyConsole.WriteInformation("Basement is already buil");
                }
            }
            else
            {
                MyConsole.WriteInformation("Very few workers    ");
            }
        }
        public void BuildWalls()
        {
            if (workers.Count >= 2)
            {
                if (house.Documentation.ActWorkPerformed.BasementFinish && !house.Documentation.ActWorkPerformed.WallsFinish)
                {
                    if (house.Walls is null) throw new Exception("Walls is NULL");
                    house.Walls.DoBuild(house.Documentation.ProgressBook.Walls);
                    house.Documentation.ProgressBook.Walls++;
                    if (house.Documentation.ProgressBook.Walls == house.Documentation.Project.Walls)
                        house.Documentation.ActWorkPerformed.Walls_Finish();
                }
                else if (!house.Documentation.ActWorkPerformed.BasementFinish)
                {
                    MyConsole.WriteInformation("Basement is not finish");
                }
                else
                {
                    MyConsole.WriteInformation("Walls is already buil");
                }
            }
            else
            {
                MyConsole.WriteInformation("Very few workers   ");
            }
        }
        public void BuildRoof()
        {
            if (workers.Count >= 2)
            {
                if (house.Documentation.ActWorkPerformed.WallsFinish && !house.Documentation.ActWorkPerformed.RoofFinish)
                {
                    if (house.Roof is null) throw new Exception("Roof is NULL");
                    house.Roof.DoBuild();
                    house.Documentation.ProgressBook.Roof++;
                    if (house.Documentation.ProgressBook.Roof == house.Documentation.Project.Roof)
                        house.Documentation.ActWorkPerformed.Roof_Finish();
                }
                else if (!house.Documentation.ActWorkPerformed.WallsFinish)
                {
                    MyConsole.WriteInformation("Walls is not finish");
                }
                else
                {
                    MyConsole.WriteInformation("Roof is already buil");
                }
            }
            else
            {
                MyConsole.WriteInformation("Very few workers   ");
            }
        }
        public void BuildWindows()
        {
            if (workers.Count >= 2)
            {
                if (house.Documentation.ActWorkPerformed.WallsFinish && !house.Documentation.ActWorkPerformed.WindowFinish)
                {
                    if (house.Window is null) throw new Exception("Windows is NULL");
                    house.Window.DoBuild(house.Documentation.ProgressBook.Windows);
                    house.Documentation.ProgressBook.Windows++;
                    if (house.Documentation.ProgressBook.Windows == house.Documentation.Project.Windows)
                        house.Documentation.ActWorkPerformed.Window_Finish();
                }
                else if (!house.Documentation.ActWorkPerformed.WallsFinish)
                {
                    MyConsole.WriteInformation("Walls are not finish");
                }
                else
                {
                    MyConsole.WriteInformation("Windows are already buil");
                }
            }
            else
            {
                MyConsole.WriteInformation("Very few workers   ");
            }
        }
        public void BuildDoor()
        {
            if (workers.Count >= 2)
            {
                if (house.Documentation.ActWorkPerformed.WallsFinish && !house.Documentation.ActWorkPerformed.DoorFinish)
                {
                    if (house.Door is null) throw new Exception("Door is NULL");
                    house.Door.DoBuild(house.Documentation.ProgressBook.Doors);
                    house.Documentation.ProgressBook.Doors++;
                    if (house.Documentation.ProgressBook.Doors == house.Documentation.Project.Doors)
                        house.Documentation.ActWorkPerformed.Door_Finish();
                }
                else if (!house.Documentation.ActWorkPerformed.WallsFinish)
                {
                    MyConsole.WriteInformation("Walls are not finish");
                }
                else
                {
                    MyConsole.WriteInformation("Doors are already buil");
                }
            }
            else
            {
                MyConsole.WriteInformation("Very few workers   ");
            }
        }


    }
}
