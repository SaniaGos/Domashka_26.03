using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingHouse.Klasses
{
    static class MyConsole
    {
        public static void WriteInformation(string info)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(5, 0);
            Console.WriteLine($"{info}                      ");
            Console.ResetColor();
            Console.SetCursorPosition(0, 1);
            //Console.ReadKey();
        }
    }
}
