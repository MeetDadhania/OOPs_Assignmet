using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    //Creating Addition Interface
    interface IAddition
    {
        //Define method
        void Addition(int value1,int value2);
    }

    //Creating Addition Interface
    interface ISubtraction
    {
        //Define method    
        void Subtraction(int value1,int value2);
    }

    //Creating Addition Interface
    interface IMultiplication
    {
        //Define method
        void Multiplication(int value1, int value2);
    }

    //creating class Calculator and implement all the interfaces
    public class Calculator : IAddition, ISubtraction, IMultiplication
    {
        //implementing addition method
        public void Addition(int value1, int value2)
        {
            Console.WriteLine("The Addition of " + value1 + " and " + value2 + " is " + (value2 + value1) );
        }

        //implementing Subtraction method
        public void Subtraction(int value1, int value2)
        {
            Console.WriteLine("The Subtraction of " + value2 + " from " + value1 + " is " + (value1 - value2));
        }

        //implementing multiplication method
        public void Multiplication(int value1, int value2)
        {
            Console.WriteLine("The Multiplication of " + value1 + " and " + value2 + " is " + (value2 + value1));
        }
    }
}
