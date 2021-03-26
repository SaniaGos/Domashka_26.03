using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometric_figure.Klasses;


namespace Geometric_figure
{
    public static class View
    {
        public static void ShowFigure(SystemFigure figure)
        {
            foreach (GeometricFigure item in figure)
            {
                Console.WriteLine(item);
            }
        }
    }
}
