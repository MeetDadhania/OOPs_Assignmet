using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Creating Year2021 Object refere is to Interface
            IIntrestRate intrestRate = new Year2021();
            intrestRate.MoneytoPay(12000);

            //Creating Year2021 Object refere is to Interface
            intrestRate = new Year2022();
            intrestRate.MoneytoPay(12000);

            Console.WriteLine("--------------------------------------------------------------------------");

            //Question 1 from Assignment 
            Shape firstShape = new Circle(7);
            firstShape.CalculateArea();
            firstShape = new Rectangle(10, 10);
            firstShape.CalculateArea();
            firstShape = new Square(12);
            firstShape.CalculateArea();

            Console.WriteLine("--------------------------------------------------------------------------");

            //Question 2 from Assignment 
            Students students = new Students();
            students.Print("Meet");
            students.Print("Meet","Patel");
            students.Print("Meet", "Patel", "metptl@gmail.com");
            students.Print("Meet", "Patel",9837784829);

            Console.WriteLine("--------------------------------------------------------------------------");

            //Question 3 from Assignment
            Vehicle firstVehicle = new Ford();
            firstVehicle.Price = 6899999.99;
            firstVehicle.TopSpeed = 320;
            firstVehicle.Average = 10;
            firstVehicle.PrintDetails();

            firstVehicle = new Kia();
            firstVehicle.Price = 1999999.99;
            firstVehicle.TopSpeed = 180;
            firstVehicle.Average = 19;
            firstVehicle.PrintDetails();

            Console.WriteLine("--------------------------------------------------------------------------");

            //Question 4 From Assignment 
            IFruit fruit = new Bananas();
            fruit.Color = "Yellow";
            fruit.Taste = "Sweet";
            fruit.PrintDetails();

            fruit = new Mangos();
            fruit.Color = "orangish-yellow";
            fruit.Taste = "Sweet";
            fruit.PrintDetails();

            fruit = new Grapes();
            fruit.Color = "Violet";
            fruit.Taste = "sweet-sour";
            fruit.PrintDetails();

            Console.WriteLine("--------------------------------------------------------------------------");

            //Question 5 From Assignment 
            Calculator calculator = new Calculator();
            calculator.Addition(12, 13);
            calculator.Subtraction(50, 24);
            calculator.Multiplication(4, 8);

            Console.WriteLine("--------------------------------------------------------------------------");

            //Question 6 From Assignment 

            Teachers teachers = new Teachers();
            //Public data member can be access directly
            teachers.firstName = "Meet";
            teachers.lastName = "Patel";

            //To use private data member we have to implement get and set methods
            teachers.Email = "metptl@gmail.com";

            //This gives error because methods are private or protected
            //teachers.PrintDetails();
            //teachers.ShowDetails();

            teachers.DisplayDetails();

            Console.WriteLine("--------------------------------------------------------------------------");

            //Question 7 From Assignment 

            //Creating Cat Object with Default Constructor
            Cat firstAminal = new Cat();
            Console.WriteLine("Cod is running.....");

            //Assign AnimalName and ColorName
            firstAminal.AnimalName = "Mini";
            firstAminal.ColorName = "Black/White";

            //Call Method Activity
            firstAminal.Activity("Laugh");

            //Creating Cat Object with Parameterized constructor
            firstAminal = new Cat("Kitty","Brown");

            //Call Method Activity
            firstAminal.Activity("Laugh");

            Console.WriteLine("--------------------------------------------------------------------------");

            //Question 8 From Assignment

            IceCream iceCream = new IceCream();
            iceCream.Flavour = "Chocolate";

            iceCream.Print();

            Console.WriteLine("--------------------------------------------------------------------------");

            //Question 9 From Assignment

            IronMan ironMan = new IronMan();
            ironMan.SuperPower = "Intelligent";
            ironMan.Print();
            Thor thor = new Thor();
            thor.SuperPower = "Strong";
            thor.Print();

            Console.WriteLine("------------------------------The End-------------------------------------");

        }
    }
}
