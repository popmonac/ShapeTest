using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeProgram.Data;

namespace ShapeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int RH = 6;   //input variable for Rectangle
            int TH = 7;  //input variable for Rectangle  Height
            int TW = 5;  //input variable for Triangle   Width
            int C = 5;  //input variable for Rectangle


            Triangle triangle = new Triangle (TH, TW);      //Creating the object of the class "Triangle"
            Rectangle rectangle = new Rectangle(RH, RH);   //Creating the object of the class "Triangle"
            Circle circle = new Circle(C, C);             //Creating the object of the class "Triangle"


            //Displaying the result of the method (Calculate) called
            Console.WriteLine("The Area of this Triangle is = " + triangle.CalculateSurface());
            Console.WriteLine("The Area of this Rectangle is = " + rectangle.CalculateSurface());
            Console.WriteLine("The Area of a Circle is = " + circle.CalculateSurface());

           
            Console.ReadLine();
        }
    }
}