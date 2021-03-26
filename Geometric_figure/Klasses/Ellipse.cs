using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric_figure.Klasses
{
    class Ellipse : GeometricFigure
    {
        private double a;
        private double b;
        public Ellipse(double radius_1, double radius_2)
        {
            if (radius_1 > radius_2)
            {
                this.a = radius_1;
                this.b = radius_2;
            }
            else
            {
                this.b = radius_1;
                this.a = radius_2;
            }
        }
        public override double PerimeterFigure()
        {
            return ((22 / (double)7) * (a + b + 3 * Math.Pow((a - b), 2) / (10 * (a + b) + Math.Sqrt(Math.Pow(a, 2) + 14 * a * b + Math.Pow(b, 2))))) /
                (1 + ((22 / (7 * Math.PI)) - 1) *
                Math.Exp(-(Math.Pow((Math.Pow(a / b, 0.14597) - 1),
                (3.40744 / Math.Pow((Math.Pow(a / b, 0.389097) - 1), 0.582524) + 1.12787))))); // формула якогось там Александрова, кажуть, що одна з найточніших
        }
        public override double SquareFigure()
        {
            return (a * b * Math.PI);
        }
        public override string ToString()
        {
            return $"Ellipse:\nPerimeter figure: {Math.Round(PerimeterFigure(), 3)}\nSquare Figure: {Math.Round(SquareFigure(), 3)}\n\n";
        }
    }
}
