using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    //Creating class MealCourse
    public class MealCourse
    {
        private string mealCourseType;

        //Get and Set Method
        public string MealType
        {
            get 
            { 
                return mealCourseType; 
            }
            set 
            {
                mealCourseType = value;
            }
        }

        //constructor
        public MealCourse() { }

        //Parameterized constructor
        public MealCourse(string mealCourseType)
        {
            this.mealCourseType = mealCourseType;
        }

        //Virtual method to Print
        public virtual void Print()
        {
            Console.WriteLine("MealCourseType is " + mealCourseType);
        }
    }

    //inherit Dessert class from MealCourse
    public class Dessert : MealCourse
    {
        private string dessertType;

        //get and set methods
        public string DessertType
        {
            get
            {
                return dessertType;
            }
            set
            {
                dessertType = value;
            }  
        }

        //Constructor
        public Dessert() : base("Dessert") { }

        //parameterized constructor
        public Dessert(string dessertType) : base("Dessert")
        {
            this.dessertType = dessertType;
        }

        //Override the Print Method
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Dessert type is " + dessertType);
        }
    }

    public class IceCream : Dessert
    {
        private string flavour;

        //Get and Set Methods
        public string Flavour
        {
            get
            {
                return flavour;
            }
            set
            {
                flavour = value;
            }
        }

        //constructor
        public IceCream() : base("IceCream") { }

        //parameterized constructor
        public IceCream(string flavour) : base("IceCream")
        {
            this.flavour = flavour;
        }

        //override Print Method
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Icecream flavour is " + flavour);
        }

    }
}
