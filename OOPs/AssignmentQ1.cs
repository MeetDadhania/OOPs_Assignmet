using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    //Creating Shape class as Base class
    public class Shape
    {
        private double height=0;
        private double width=0;
        private double radius=0;

        //Constructor for assign radius to circle
        public Shape(double radius)
        {
            this.radius = radius;
        }

        //Constructor for assign radius to Rectangle
        public Shape(double height,double width)
        {
            this.width = width;
            this.height = height;
        }

        //Get and Set for Height
        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        //Get and Set for Width
        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        //Get and Set for Radius
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        //Create one Virtual method and override it in child class
        public virtual void CalculateArea() { }
    }

    //Circle Class (child of Shape class)
    public class Circle : Shape
    {
        //Constructor to assign value to radius via calling base class constructor
        public Circle(double radius) : base(radius) { }

        //Override CalculateArea method for circle class
        public override void CalculateArea()
        {
            Console.WriteLine("The area Of " + this.GetType().Name + " is " + Math.Round(Math.PI*Math.Pow(base.Radius,2),2));
        }
    }


    public class Rectangle : Shape
    {

        //Constructor to assign value to radius via calling base class constructor
        public Rectangle(double width, double height) : base(width, height) { }

        //Override CalculateArea method for circle class
        public override void CalculateArea()
        {
            Console.WriteLine("The area Of " + this.GetType().Name + " is " + (base.Height * base.Width));
        }
    }

    //Inherit Square from Rectangle
    public class Square : Rectangle
    {
        //Constructor to assign value of Height
        public Square(double height) : base(height,height) { }

    }
}
