using System;
using System.Collections.Generic;
using System.Text;

namespace ABSTRACT_SHAPE
{
    public abstract class Shape
        {
            public double Width { get; private set; }
            public double Height { get; private set; }

            public Shape(double radius)
            {
                Width = Height = radius;
            }

            public Shape(double _width, double _height)
            {
                Width = _width;
                Height = _height;

            }

            //Abstrct Method Calculate Surface
            public abstract double CalculateSurface();
    
    
    }
}
