using System;

namespace DesignPatterns.Patterns.FacadeDesign
{
    /// <summary>
    ///     The Loan Class.
    /// </summary>
    class Loan
    {
        /// <summary>
        ///     Checks if the customer has bad loans.
        /// </summary>
        /// <param name="c">The Customer.</param>
        /// <returns>A flag indicating whether a customer has any bad loans.</returns>
        public bool HasNoBadLoans(Customer c)
        {
            Console.WriteLine("Check loans for " + c.Name);
            return true;
        }
    }
}
