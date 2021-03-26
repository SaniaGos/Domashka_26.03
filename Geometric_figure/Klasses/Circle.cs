using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric_figure.Klasses
{
    class Circle : GeometricFigure
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double PerimeterFigure()
        {
            return (2 * radius * Math.PI);
        }
        public override double SquareFigure()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public override string ToString()
        {
            return $"Circle:\nPerimeter figure: {Math.Round(PerimeterFigure(), 3)}\nSquare Figure: {Math.Round(SquareFigure(), 3)}\n\n";
        }
    }
}
