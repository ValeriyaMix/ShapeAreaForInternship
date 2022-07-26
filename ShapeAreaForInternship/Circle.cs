using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaForInternship
{
    public class Circle: IShape
    {
        public double Radius
        { get; private set; }

        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("The radius cannot" +
                    "be negative value", nameof(radius));
            }

            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 3);
        }
    }
}
