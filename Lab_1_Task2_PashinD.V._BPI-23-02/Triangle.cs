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

        public double getArea(double a, double b, double c, double p)
        {
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }
        public double getPerimeter(double a, double b, double c)
        {
            return a+b+c;
        }
    }
}
