using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using BuildingHouse.Interfaces;


namespace BuildingHouse.Klasses
{
    class Door : IPart
    {
        public void DoBuild(int part)
        {
            MyConsole.WriteInformation("Door are building now...      ");
            Console.ForegroundColor = ConsoleColor.Gray;
            for (int i = 0; i < 6; i++)
            {
                Console.SetCursorPosition(30, 19 - i);
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(":");
                    Thread.Sleep(25);
                }
                Console.WriteLine();
            }
        }
    }
}
