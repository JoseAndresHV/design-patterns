using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankFacade
{
    public class Bank
    {
        public bool HasSuficientSavings(Customer customer, int amount)
        {
            Console.WriteLine($"Check bank for { customer }");
            return true;
        }
    }
}
