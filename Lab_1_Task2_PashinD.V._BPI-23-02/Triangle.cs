using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Task2_PashinD.V._BPI_23_02
{
    public class Triangle : GeomFigures
    {
        private double a;
        private double b;
        private double c;

        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override double getArea()
        {
            double p = getPerimeter();
            return Math.Sqrt(p*(p-A)*(p-B)*(p-C));
        }
        public override double getPerimeter()
        {
            return A+B+C;
        }
    }
}
