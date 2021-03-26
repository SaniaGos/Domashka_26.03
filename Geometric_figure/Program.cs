using System;
using System.Linq;
using System.Text;
using Geometric_figure.Klasses;

namespace Geometric_figure
{
    class Program
    {
        static void Main(string[] args)
        {
            SystemFigure figures = new SystemFigure();
            View.ShowFigure(figures);

            Console.ReadLine();
        }
    }
}
