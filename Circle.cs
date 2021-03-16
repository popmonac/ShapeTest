namespace ShapeProgram.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Circle : Shape
    {
        private double radius;
        public Circle()
        {
            height = double.MinValue;
            width = double.MinValue;
        }
        //constructor initializing Height and Width
        public Circle(double hgt, double wdt)
        {
            height = hgt;
            width = wdt;
        }

        //get and set properties for the Width
        public override double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value != height)
                {
                    throw new ArgumentException("Width must be equal to height");
                }
                width = value;
            }
        }
        //get and set properties for the Height
        public override double Height
        {
            get { return height; }
            set 
            {
                if (value != width)
                {
                    throw new ArgumentException("Height must be equal to Width");
                }
                height = value;
            }
        }

        //Method handling the area
        public override double CalculateSurface()
        {
            double radius = Math.PI * (height * width);
            return radius;
        }
    }
}