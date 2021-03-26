using System;
using System.Collections;
using System.Linq;
using System.Text;
using Geometric_figure.Klasses;
namespace Geometric_figure
{
    public class SystemFigure : IEnumerable
    {
        GeometricFigure[] systemFigure =
        {
            new Quadrate(3),
            new Circle(4.1),
            new Rectangle(4.2, 5.5),
            new Ellipse(4, 5.6),
            new Triangle(4, 5.6, 7.2),
        };
        public IEnumerator GetEnumerator()
        {
            return systemFigure.GetEnumerator();
        }
    }
}
