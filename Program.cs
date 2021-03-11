using System;

namespace ABSTRACT_SHAPE
{ 
    class Program
    {
        public static void Main(string[] args)
        {
            //OBJECT OF CLASS TRIANGLE
            Triangle triangle1 = new Triangle(3, 4);
            Triangle triangle2 = new Triangle(5, 7);
            Triangle triangle3 = new Triangle(6, 9);

            Console.WriteLine("\a\n\n\t RESULT FOR TRIANGLE CALCULATION");
            Console.WriteLine("\nTriangle1 with width=3 and height=4 is {0}", triangle1.CalculateSurface());
            Console.WriteLine("\nTriangle2 with width=5 and height=7 is {0}", triangle2.CalculateSurface());
            Console.WriteLine("Triangle3 with width=6 and height=9 is {0}", triangle3.CalculateSurface());

            //OBJECT OF RECTANGLE
           
            Rectangle rectangle1 = new Rectangle(9, 18);
            Rectangle rectangle2 = new Rectangle(13, 27);
            Rectangle rectangle3 = new Rectangle(25, 40);

            Console.WriteLine("\n\n\t RESULT FOR RECTANGLE CALCULATION");
            Console.WriteLine("\nRectangle1 with width=9 and height=18 is {0}", rectangle1.CalculateSurface());
            Console.WriteLine("Rectangle2 with width=13 and height=27 is {0}", rectangle2.CalculateSurface());
            Console.WriteLine("Rectangle3 with width=25 and height=40 is {0}", rectangle3.CalculateSurface());

            //OBJECT OF CLASS CIRCLE 
            Circle circle1 = new Circle(3);
            Circle circle2 = new Circle(5);
            Circle circle3 = new Circle(8);

            Console.WriteLine("\n\n\t RESULT FOR RECTANGLE CALCULATION");
            Console.WriteLine("\nCircle1 with radius 3 is is {0}", circle1.CalculateSurface());
            Console.WriteLine("Circle2 with radius 5 is is {0}", circle2.CalculateSurface());
            Console.WriteLine("Circle3 with radius 8 is is {0}", circle3.CalculateSurface());
        }
    }

   
}
