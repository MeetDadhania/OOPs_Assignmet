using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace OOPs
{
    //creaing parent class 
     class Animal
    {
        private string animalName;

        public string AnimalName
        {
            get
            {
                return animalName;
            }
            set
            {
                animalName = value;
            }
        }

        //Default Constructor
        public Animal()
        {

        }

        //parameterized constructor
        public Animal(string name)
        {
            animalName = name;
        }

        // Creating virtual method for polymorphism
        public virtual void Activity(string activity)
        {
            Console.WriteLine(activity);
        }
        
    }

    //Creating child class and its parent is Aminal Class
    class Cat : Animal
    {
        private string color;


        //Get and set method for color 
        public string ColorName
        {
            get { return color; }
            set { color = value; }
        }

        //Default Construtor
        public Cat()
        {

        }
        //parameterized constructor
        public Cat(string name,string colorName) : base(name)
        {
            color = colorName;
        }

        //override method of parent class 
        public override void Activity(string activity)
        {
            Console.WriteLine(color + " " + base.AnimalName + " " + activity);
        }
    }


}
