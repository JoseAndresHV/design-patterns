using BankFacade.Facade;
using System;

namespace BankFacade
{
    class Program
    {
        static void Main(string[] args)
        {
            Mortgage mortgage = new Mortgage();

            Customer customer = new Customer("Jose Andres Hurtado");
            bool eligible = mortgage.IsEligible(customer, 125000);

            Console.WriteLine($"\n{customer.Name} has been { (eligible ? "APPROVED" : "REJECTED") }");
        }
    }
}
