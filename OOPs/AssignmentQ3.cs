using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public abstract class Vehicle
    {
        protected int topSpeed;
        protected int average;
        protected double price;

        public abstract int TopSpeed
        {
            get;
            set;
        }
        public abstract int Average
        {
            get;
            set;
        }

        public abstract double Price
        {
            get;
            set;
        }

        public virtual void PrintDetails()
        {
            Console.WriteLine(this.GetType().Name + "'s average is " + average + " km/L with " + topSpeed + " km/h of Topspeed and price is " + price + " Rs.");
        }
    }

    public class Ford : Vehicle
    {
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

        public Ford()
        {
            Console.WriteLine("Hello Welcome to " + this.GetType().Name);
        }

       
    }

    public class Kia : Vehicle
    {
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

        public Kia()
        {
            Console.WriteLine("Hello Welcome to " + this.GetType().Name);
        }

    }
}
