using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPs
{
    public class Marvel
    {
        private string studioName = "Marvel";

        public string StudioName
        {
            get { return studioName; }
        }

        public Marvel() 
        {
            Console.WriteLine("Welcome to MCU.............");
        }

        public virtual void Print() 
        {
            Console.WriteLine("Marvel Has many SuperHeroes....");
        }
    }

    public class IronMan : Marvel
    {
        private string name = "IronMan";
        private string superPower;

        public string Name
        {
            get { return name; }
        }

        public string SuperPower
        {
            get { return superPower; }
            set { superPower = value; }
        }

        public override void Print()
        {
            Console.WriteLine(base.StudioName + "'s " + name + " is " + superPower);
        }
    }

    public class Thor : Marvel
    {
        private string name = "Thor";
        private string superPower;

        public string Name
        {
            get { return name; }
        }

        public string SuperPower
        {
            get { return superPower; }
            set { superPower = value; }
        }

        public override void Print()
        {
            Console.WriteLine(base.StudioName + "'s " + name + " is " + superPower);
        }
    }
}
