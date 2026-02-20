using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Task2_PashinD.V._BPI_23_02
{
    public class Rectangle : GeomFigures
    {
        private double width;
        private double height;

        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double getArea()
        {
            return Width*Height;
        }
        public override double getPerimeter()
        {
            return 2 * Width + 2 * Height;
        }
    }
}
