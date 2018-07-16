using System;

namespace DesignPatterns.Patterns.FacadeDesign
{
    /// <summary>
    ///     The Credit class.
    /// </summary>
    class Credit
    {
        /// <summary>
        ///     Checks if a Customer has good credits.
        /// </summary>
        /// <param name="c">The Customer.</param>
        /// <returns>Flag indicating whether customer has good credits.</returns>
        public bool HasGoodCredit(Customer c)
        {
            Console.WriteLine("Check credit for " + c.Name);
            return true;
        }
    }
}
