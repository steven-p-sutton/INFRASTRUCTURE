namespace Conductus.PATTERN.Factory.CREDITCARD
{
    /// <summary>  
    /// The 'Product' Abstract Class  
    /// </summary>  
    interface ICreditCard
    {
        string CardType { get; }
        int CreditLimit { get; set; }
        int AnnualCharge { get; set; }
    }
}
