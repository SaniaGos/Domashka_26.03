using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using BuildingHouse.Interfaces;


namespace BuildingHouse.Klasses
{
    class Walls : IPart
    {
        public void DoBuild(int part)
        {
            MyConsole.WriteInformation("Walls is building     ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            for (int i = 0; i < 2; i++)
            {
                Console.SetCursorPosition(5, 19 - i - part * 2);
                for (int j = 0; j < 40; j++)
                {
                    Console.Write("%");
                    Thread.Sleep(25);
                }
                Console.WriteLine();
            }
        }
    }
}
