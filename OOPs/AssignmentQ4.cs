using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    //Creating Fruit Interface
    public interface IFruit
    {
        //Define Method to get and set value of Taste
        string Taste 
        { 
            get;
            set;
        }

        //Define Method to get and set value of Color
        string Color
        {
            get;
            set;
        }

        //Define Method to print details
        void PrintDetails();
    }

    public class Bananas : IFruit
    {
        private string taste;
        private string color;

        //implementing get and set method for taste
        public string Taste 
        {
            get { return taste; }
            set { taste = value; }
        }

        //implementing get and set method for color
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        //implementing PrintDetails method
        public void PrintDetails()
        {
            Console.WriteLine(this.GetType().Name + " are " + color + " and " + taste);
        }
    }

    public class Mangos : IFruit
    {
        private string taste;
        private string color;

        //implementing get and set method for taste
        public string Taste
        {
            get { return taste; }
            set { taste = value; }
        }

        //implementing get and set method for Color
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        //implementing PrintDetails method
        public void PrintDetails()
        {
            Console.WriteLine(this.GetType().Name + " are " + color + " and " + taste);
        }
    }

    public class Grapes : IFruit
    {
        private string taste;
        private string color;

        //implementing get and set method for taste
        public string Taste
        {
            get { return taste; }
            set { taste = value; }
        }

        //implementing get and set method for color
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        //implementing PrintDetails method
        public void PrintDetails()
        {
            Console.WriteLine(this.GetType().Name + " are " + color + " and " + taste);
        }
    }
}
