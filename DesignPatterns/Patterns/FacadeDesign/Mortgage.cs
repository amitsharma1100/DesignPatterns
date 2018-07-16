using System;

namespace DesignPatterns.Patterns.FacadeDesign
{
    /// <summary>
    ///     The Facade Class.
    /// </summary>
    class Mortgage
    {
        private Bank _bank = new Bank();
        private Loan _loan = new Loan();
        private Credit _credit = new Credit();

        /// <summary>
        ///     Checks if the Customer is eligible for mortgage.
        /// </summary>
        /// <param name="cust">The Customer.</param>
        /// <param name="amount">The Amount.</param>
        /// <returns>A flag indicating whether a customer is eligible for mortgage.</returns>
        public bool IsEligible(Customer cust, int amount)
        {
            Console.WriteLine("{0} applies for {1:C} loan\n",
              cust.Name, amount);

            bool eligible = true;

            if (!_bank.HasSufficientSavings(cust, amount))
            {
                eligible = false;
            }
            else if (!_loan.HasNoBadLoans(cust))
            {
                eligible = false;
            }
            else if (!_credit.HasGoodCredit(cust))
            {
                eligible = false;
            }

            return eligible;
        }
    }
}
