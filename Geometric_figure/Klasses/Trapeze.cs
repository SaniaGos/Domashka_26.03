using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric_figure.Klasses
{
    class Trapeze : GeometricFigure
    {
        private double a;
        private double b;
        private double c;
        private double d;
        private double height;
        public Trapeze(double a, double b, double c, double d, double height)
        {
            this.a = a;
            this.b = b;
            if (c >= height && d >= height)
            {
                this.c = c;
                this.d = d;
                this.height = height;
            }
            else throw new Exception("height greater than the adjacent side");
        }
        public override double PerimeterFigure()
        {
            return a + b + c + d;
        }
        public override double SquareFigure()
        {
            return height * (a + b) / 2;
        }
        public override string ToString()
        {
            return $"Trapeze:\nPerimeter figure: {Math.Round(PerimeterFigure(), 3)}\nSquare Figure: {Math.Round(SquareFigure(), 3)}\n\n";
        }
    }
}
