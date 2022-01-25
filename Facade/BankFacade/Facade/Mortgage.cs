using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankFacade.Facade
{
    public class Mortgage
    {
        private readonly Bank _bank = new Bank();
        private readonly Loan _loan = new Loan();
        private readonly Credit _credit = new Credit();

        public bool IsEligible(Customer customer, int amount)
        {
            Console.WriteLine("{0} applies for {1:C} loan\n", customer, amount);

            // Check creditworthyness of applicant
            bool eligible = (_bank.HasSuficientSavings(customer, amount) &&
                _loan.HasNoBadLoans(customer) && _credit.HasGoodCredit(customer)) ?
                true : false;

            return eligible;
        }
    }
}
