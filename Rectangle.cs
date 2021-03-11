using System;
using System.Collections.Generic;
using System.Text;

namespace ABSTRACT_SHAPE
{
    public class Rectangle : Shape
    {
        public Rectangle(double _width, double _height):base(_width,_height)
        {

        }
        public override double CalculateSurface()
        {
            return Height * Width;
        }
    }
}
