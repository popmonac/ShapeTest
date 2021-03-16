namespace ShapeProgram.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    

    class Rectangle : Shape
    {
        public Rectangle()
        {
            height = double.MinValue;
            width = double.MinValue;
        }
        //constructor initializing Height and Width
        public Rectangle(double hgt, double wdt)
        {
            height = hgt;
            width = wdt;
        }

        //get and set properties for the Height
        public override double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
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
                width = value;
            }
        }
        //Method handling the area
        public override double CalculateSurface()
        {
            return (height * width);
        }
    }
}