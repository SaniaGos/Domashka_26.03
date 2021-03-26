using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric_figure.Klasses
{
    class Rectangle : GeometricFigure
    {
        private double a;
        private double b;
        public Rectangle(double a, double b)
        {
                this.a = a;
                this.b = b;
        }
        public override double PerimeterFigure()
        {
            return 2 * (a + b);
        }
        public override double SquareFigure()
        {
            return a * b;
        }
        public override string ToString()
        {
            return $"Rectangle:\nPerimeter figure: {Math.Round(PerimeterFigure(), 3)}\nSquare Figure: {Math.Round(SquareFigure(), 3)}\n\n";
        }
    }
}
