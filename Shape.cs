namespace ShapeProgram.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public abstract class Shape
    {
        protected double width;
        protected double height;

        public virtual double CalculateSurface()
        {
            return width * height;
        }

        public abstract double Width
        { get; set; }

        public abstract double Height
        { get; set; }
    }
}