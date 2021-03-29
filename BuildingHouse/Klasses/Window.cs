using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using BuildingHouse.Interfaces;


namespace BuildingHouse.Klasses
{
    class Window : IPart
    {
        public void DoBuild(int part)
        {
            MyConsole.WriteInformation("Windows are building now...    ");
            Console.ForegroundColor = ConsoleColor.Gray;
            for (int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition(8 + part * 8, 17 - i);
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(":");
                    Thread.Sleep(25);
                }
                Console.WriteLine();
            }
        }
    }
}
