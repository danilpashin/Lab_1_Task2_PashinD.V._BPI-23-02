using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Task2_PashinD.V._BPI_23_02
{
    public class Circle : GeomFigures
    {
        private double radius;

        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double getArea(double radius)
        {
            return Math.PI * (radius * radius);
        }
        public double getPerimeter(double radius)
        {
            return 2 * radius * Math.PI;
        }
    }
}
