using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric_figure.Klasses
{
    class Parallelogram : GeometricFigure
    {
        private double a;
        private double b;
        private double height;
        public Parallelogram(double a, double b, double height)
        {
            if (height <= b)
            {
                this.a = a;
                this.b = b;
                this.height = height;
            }
            else throw new Exception("height greater than the adjacent side");
        }
        public override double PerimeterFigure()
        {
            return 2 * (a + b);
        }
        public override double SquareFigure()
        {
            return a * height;
        }
        public override string ToString()
        {
            return $"Parallelogram:\nPerimeter figure: {Math.Round(PerimeterFigure(), 3)}\nSquare Figure: {Math.Round(SquareFigure(), 3)}\n\n";
        }
    }
}
