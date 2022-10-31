using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public interface IFruit
    {
        string Taste 
        { 
            get;
            set;
        }

        string Color
        {
            get;
            set;
        }

        void PrintDetails();
    }

    public class Bananas : IFruit
    {
        private string taste;
        private string color;

        public string Taste 
        {
            get { return taste; }
            set { taste = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public void PrintDetails()
        {
            Console.WriteLine(this.GetType().Name + " are " + color + " and " + taste);
        }
    }

    public class Mangos : IFruit
    {
        private string taste;
        private string color;

        public string Taste
        {
            get { return taste; }
            set { taste = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public void PrintDetails()
        {
            Console.WriteLine(this.GetType().Name + " are " + color + " and " + taste);
        }
    }

    public class Grapes : IFruit
    {
        private string taste;
        private string color;

        public string Taste
        {
            get { return taste; }
            set { taste = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public void PrintDetails()
        {
            Console.WriteLine(this.GetType().Name + " are " + color + " and " + taste);
        }
    }
}
