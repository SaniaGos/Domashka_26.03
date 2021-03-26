using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric_figure.Klasses
{
    class Quadrate : GeometricFigure
    {
        private double a;
       public Quadrate(double a)
        {
           this.a = a;
        }
        public override double PerimeterFigure()
        {
            return 4 * a;
        }
        public override double SquareFigure()
        {
            return a * a;
        }
        public override string ToString()
        {
            return $"Quadrate:\nPerimeter figure: {Math.Round(PerimeterFigure(), 3)}\nSquare Figure: {Math.Round(SquareFigure(), 3)}\n\n";
        }
    }
}
