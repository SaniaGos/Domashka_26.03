using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric_figure.Klasses
{
    class Rhomb : GeometricFigure
    {
        private double a;
        private double height;
        
        public Rhomb(double a, double height)
        {
            if (a > height)
            {
                this.a = a;
                this.height = height;
            }
            else throw new Exception("height greater than the adjacent side");
        }
        public override double PerimeterFigure()
        {
            return 4 * a;
        }
        public override double SquareFigure()
        {
            return a * height;
        }
        public override string ToString()
        {
            return $"Rhomb:\nPerimeter figure: {Math.Round(PerimeterFigure(), 3)}\nSquare Figure: {Math.Round(SquareFigure(), 3)}\n\n";
        }
    }
}
