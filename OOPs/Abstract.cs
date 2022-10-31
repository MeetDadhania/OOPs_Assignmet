using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    interface IIntrestRate
    {
        void MoneytoPay(int amount);
    }

    class Year2021 : IIntrestRate
    {
        public void MoneytoPay(int amount)
        {
            Console.WriteLine("Amount To Pay is " + (amount + amount*0.12));
        }
    }

    class Year2022 : IIntrestRate
    {
        public void MoneytoPay(int amount)
        {
            Console.WriteLine("Amount To Pay is " + (amount + amount * 0.24));
        }
    }
}
