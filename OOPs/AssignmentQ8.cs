using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public class MealCourse
    {
        private string mealCourseType;

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

        public virtual void Print()
        {
            Console.WriteLine("MealCourseType is " + mealCourseType);
        }
    }

    public class Dessert : MealCourse
    {
        private string dessertType;

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

        public Dessert()
        {
            base.MealType = "Dessert";
        }

        public Dessert(string dessertType) 
        {
            base.MealType = "Dessert";
            this.dessertType = dessertType;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Dessert type is " + dessertType);
        }
    }

    public class IceCream : Dessert
    {
        private string flavour;
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

        public IceCream()
        {
            base.DessertType = "IceCream";
        }

        public IceCream(string flavour)
        {
            base.DessertType = "IceCream";
            this.flavour = flavour;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Icecream flavour is " + flavour);
        }

    }
}
