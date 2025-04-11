using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Davaleba8
{
    internal class Rectangle
    {
        private double _length;
        private double _width;
        private double _perimeter;
        public double Length { get { return _length; }  }
        public double Width { get { return _width; } }
        public double Perimeter { get { return _perimeter; }}



        public Rectangle(double length, double width)
        {
            _length = length;
            _width = width;
            _perimeter = 2 * (length + width);

        }
    
        public void Print()
        {
            Console.WriteLine($"Length: {Length}");
            Console.WriteLine($"Width: {Width}");
            Console.WriteLine($"Perimeter: {Perimeter}");
        }
    }
}
