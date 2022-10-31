using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public class Shape
    {
        private double height=0;
        private double width=0;
        private double radius=0;


        public Shape(double radius)
        {
            this.radius = radius;
        }

        public Shape(double height,double width)
        {
            this.width = width;
            this.height = height;
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public virtual void CalculateArea() { }
    }

    public class Circle : Shape
    {

        public Circle(double radius) : base(radius) { }

        public override void CalculateArea()
        {
            Console.WriteLine("The area Of " + this.GetType().Name + " is " + Math.Round(Math.PI*Math.Pow(base.Radius,2),2));
        }
    }


    public class Rectangle : Shape
    {

        public Rectangle(double width, double height) : base(width, height) { }

        public override void CalculateArea()
        {
            Console.WriteLine("The area Of " + this.GetType().Name + " is " + (base.Height * base.Width));
        }
    }

    public class Square : Rectangle
    {

        public Square(double height) : base(height,height) { }

    }
}
