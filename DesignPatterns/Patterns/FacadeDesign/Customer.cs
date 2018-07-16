namespace DesignPatterns.Patterns.FacadeDesign
{
    /// <summary>
    ///     The Customer Class.
    /// </summary>
    class Customer
    {
        /// <summary>
        ///     Gets or sets the customer name.
        /// </summary>
        public string Name { get; set; }

        // Constructor
        public Customer(string name)
        {
            this.Name = name;
        }        
    }
}
