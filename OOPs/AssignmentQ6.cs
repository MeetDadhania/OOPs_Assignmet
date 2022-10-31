using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public class Teachers
    {
        public string firstName;
        public string lastName;
        private string email;

        public string Email 
        {
            get { return email; }
            set { email = value; }
        }

        //Not accessible from outside of the class 
        private void PrintDetails()
        {
            Console.WriteLine(firstName + " " + lastName + "'s email is " + email);
        }

        //can be access by only its child classes
        protected void ShowDetails()
        {
            PrintDetails();
        }

        //can be access from anywhere inside or outside of the class
        public void DisplayDetails() 
        {
            PrintDetails();
        }
    }
}
