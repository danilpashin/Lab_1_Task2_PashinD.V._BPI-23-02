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

        public double getArea(double width, double height)
        {
            return width*height;
        }
        public double getPerimeter(double width, double height)
        {
            return 2 * width + 2 * height;
        }
    }
}
