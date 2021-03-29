using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using BuildingHouse.Interfaces;


namespace BuildingHouse.Klasses
{
    class Basement : IPart
    {
        public void DoBuild(int part = 1)
        {
            MyConsole.WriteInformation("Basement is building");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(5, 22 - i);
                for (int j = 0; j < 40; j++)
                {
                    Console.Write("#");
                    Thread.Sleep(25);
                }
                Console.WriteLine();
            }
            MyConsole.WriteInformation("The basement is completed");
        }
    }
}
