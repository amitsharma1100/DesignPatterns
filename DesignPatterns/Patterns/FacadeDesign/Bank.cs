using System;

namespace DesignPatterns.Patterns.FacadeDesign
{
    /// <summary>
    ///     The Bank Class.
    /// </summary>
    class Bank
    {
        /// <summary>
        ///     Checks if a customer has sufficient balance.
        /// </summary>
        /// <param name="c">The Customer.</param>
        /// <param name="amount">The Amoount.</param>
        /// <returns>A flag indicating whether a customer has sufficients savings.</returns>
        public bool HasSufficientSavings(Customer c, int amount)
        {
            Console.WriteLine("Check bank for " + c.Name);
            return true;
        }
    }
}
