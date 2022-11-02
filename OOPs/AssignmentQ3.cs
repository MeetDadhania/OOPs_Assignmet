using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    //creating abstract class Vehicle
    public abstract class Vehicle
    {
        protected int topSpeed;
        protected int average;
        protected double price;

        //Creating abstract method to get and set the TopSpeed
        public abstract int TopSpeed
        {
            get;
            set;
        }

        //Creating abstract method to get and set the Average
        public abstract int Average
        {
            get;
            set;
        }

        //Creating abstract method to get and set the Price
        public abstract double Price
        {
            get;
            set;
        }

        //Creating Virtual method To print details
        public void PrintDetails()
        {
            Console.WriteLine(this.GetType().Name + "'s average is " + average + " km/L with " + topSpeed + " km/h of Topspeed and price is " + price + " Rs.");
        }
    }

    //creating Ford class from Vehicle
    public class Ford : Vehicle
    {
        //override abstract method for get and set the TopSpeed
        public override int TopSpeed
        {
            get
            {
                return topSpeed;
            }
            set
            {
                topSpeed = value;
            }
        }

        //override abstract method for get and set the Average
        public override int Average
        {
            get
            {
                return average;
            }
            set
            {
                average = value;
            }
        }

        //override abstract method for get and set the Price
        public override double Price
        {
            get 
            { 
                return price; 
            }
            set 
            { 
                price = value; 
            }
        }

        //Constructor 
        public Ford()
        {
            Console.WriteLine("Hello Welcome to " + this.GetType().Name);
        }

       
    }

    //creating kia from Vehicle 
    public class Kia : Vehicle
    {
        //override abstract method for get and set the TopSpeed
        public override int TopSpeed
        {
            get
            {
                return topSpeed;
            }
            set
            {
                topSpeed = value;
            }
        }

        //override abstract method for get and set the Average
        public override int Average
        {
            get
            {
                return average;
            }
            set
            {
                average = value;
            }
        }

        //override abstract method for get and set the Price
        public override double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        //Constructor
        public Kia()
        {
            Console.WriteLine("Hello Welcome to " + this.GetType().Name);
        }

    }
}
