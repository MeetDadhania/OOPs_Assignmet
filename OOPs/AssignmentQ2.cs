using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    //Creating class
    public class Students
    {
        //Creat method to Print with 1 parameter
        public void Print(string firstName)
        {
            Console.WriteLine("First Name is "+firstName);
        }

        //overLoding same method to Print with 2 parameter
        public void Print(string firstName,string lastName)
        {
            Console.WriteLine("First Name is " + firstName + " And LastName is " + lastName);
        }

        //overLoding same method to Print with 3 parameter
        public void Print(string firstName, string lastName,long mobileNumber)
        {
            Console.WriteLine(firstName + " " + lastName + "'s Mobile Number is " + mobileNumber);
        }

        //overLoding same method to Print with 3 parameter but data type is different 
        public void Print(string firstName, string lastName,string email)
        {
            Console.WriteLine(firstName + " " + lastName + "'s Email is " + email);
        }
    }
}
