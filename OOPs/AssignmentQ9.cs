using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPs
{
    //Creating Marvel Class 
    public class Marvel
    {
        //Set the default value of studioName
        private string studioName = "Marvel";

        //Get method for studioName
        public string StudioName
        {
            get { return studioName; }
        }

        //Constructor
        public Marvel() 
        {
            Console.WriteLine("Welcome to MCU.............");
        }

        //Virtual Print Method
        public virtual void Print() 
        {
            Console.WriteLine("Marvel Has many SuperHeroes....");
        }
    }

    //Inherit IronMan class from Marvel
    public class IronMan : Marvel
    {
        //default name IronMan
        private string name = "IronMan";
        private string superPower;

        //Get for name
        public string Name
        {
            get { return name; }
        }

        //Get and set for superPower
        public string SuperPower
        {
            get { return superPower; }
            set { superPower = value; }
        }

        //Override the Print Method
        public override void Print()
        {
            Console.WriteLine(base.StudioName + "'s " + name + " is " + superPower);
        }
    }

    //class Thor Inherit the Properties of Marvel class
    public class Thor : Marvel
    {
        //Private default name
        private string name = "Thor";
        private string superPower;

        //Get method for name
        public string Name
        {
            get { return name; }
        }

        //get and set methods for superPower
        public string SuperPower
        {
            get { return superPower; }
            set { superPower = value; }
        }

        //Override Print Method
        public override void Print()
        {
            Console.WriteLine(base.StudioName + "'s " + name + " is " + superPower);
        }
    }
}
