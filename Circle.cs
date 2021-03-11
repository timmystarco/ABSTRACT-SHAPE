using System;
using System.Collections.Generic;
using System.Text;

namespace ABSTRACT_SHAPE
{
    class Circle : Shape
    {
        public Circle(double radius) : base(radius)
        {

        }

        public override double CalculateSurface()
        {
            //Width raised to the power of 2
            return Math.PI * Math.Pow(Width, 2);
        }
    }
}
