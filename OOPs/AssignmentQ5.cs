using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    interface IAddition
    {
        void Addition(int value1,int value2);
    }

    interface ISubtraction
    {
        void Subtraction(int value1,int value2);
    }

    interface IMultiplication
    {
        void Multiplication(int value1, int value2);
    }

    public class Calculator : IAddition, ISubtraction, IMultiplication
    {
        public void Addition(int value1, int value2)
        {
            Console.WriteLine("The Addition of " + value1 + " and " + value2 + " is " + (value2 + value1) );
        }

        public void Subtraction(int value1, int value2)
        {
            Console.WriteLine("The Subtraction of " + value2 + " from " + value1 + " is " + (value1 - value2));
        }

        public void Multiplication(int value1, int value2)
        {
            Console.WriteLine("The Multiplication of " + value1 + " and " + value2 + " is " + (value2 + value1));
        }
    }
}
