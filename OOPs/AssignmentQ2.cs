using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public class Students
    {
        public void Print(string firstName)
        {
            Console.WriteLine("First Name is "+firstName);
        }

        public void Print(string firstName,string lastName)
        {
            Console.WriteLine("First Name is " + firstName + " And LastName is " + lastName);
        }

        public void Print(string firstName, string lastName,long mobileNumber)
        {
            Console.WriteLine(firstName + " " + lastName + "'s Mobile Number is " + mobileNumber);
        }

        public void Print(string firstName, string lastName,string email)
        {
            Console.WriteLine(firstName + " " + lastName + "'s Email is " + email);
        }
    }
}
