using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaForInternship
{
    public class Triangle: IShape
    {
        public double Side_x
        { get; private set; }
        public double Side_y
        { get; private set; }
        public double Side_z
        { get; private set; }
        public Triangle(double side_x, double side_y, double side_z)
        {
            if (side_x < 0)
            {
                throw new ArgumentException("The side value cannot" +
                    "be negative", nameof(side_x));
            }
            else if (side_y < 0)
            {
                throw new ArgumentException("The side value cannot" +
                    "be negative", nameof(side_y));
            }
            else if (side_z < 0)
            {
                throw new ArgumentException("The side value cannot" +
                    "be negative", nameof(side_z));
            }
            else if (side_x + side_y < side_z || side_y + side_z < side_x
                || side_x + side_z < side_y)
            {
                throw new ArgumentException("The value of sides does not" +
                    "satisfy the triangle inequility. The triangle with" +
                    "these sides does not exist");
            }

            Side_x = side_x;
            Side_y = side_y;
            Side_z = side_z;
        }
        public double CalculateArea()
        {
            if (Math.Sqrt(Side_x * Side_x + Side_y * Side_y) == Side_z)
            {
                return Math.Round((Side_x * Side_y) / 2, 3);
            }
            else if (Math.Sqrt(Side_z * Side_z + Side_y * Side_y) == Side_x)
            {
                return Math.Round((Side_z * Side_y) / 2, 3);
            }
            else if (Math.Sqrt(Side_x * Side_x + Side_z * Side_z) == Side_y)
            {
                return Math.Round((Side_x * Side_z) / 2, 3);
            }
            else
            {
                double p = (Side_x + Side_y + Side_z) / 2;
                return Math.Round(Math.Sqrt(p * (p - Side_x) * (p - Side_y) * (p - Side_z)), 3);
            }
        }

    }
}
