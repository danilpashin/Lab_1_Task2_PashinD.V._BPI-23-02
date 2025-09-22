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

        public override double getArea()
        {
            return Math.PI * (Radius * Radius);
        }
        public override double getPerimeter()
        {
            return 2 * Radius * Math.PI;
        }
    }
}
