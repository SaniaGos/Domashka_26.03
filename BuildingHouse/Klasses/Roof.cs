using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using BuildingHouse.Interfaces;


namespace BuildingHouse.Klasses
{
    class Roof : IPart
    {
        public void DoBuild(int part = 1)
        {
            MyConsole.WriteInformation("Roof is building     ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(3 + i, 11 - i);
                for (int j = 0; j < 44 - i * 2; j++)
                {
                    Console.Write("*");
                    Thread.Sleep(25);
                }
                Console.WriteLine();
            }
        }
    }
}
