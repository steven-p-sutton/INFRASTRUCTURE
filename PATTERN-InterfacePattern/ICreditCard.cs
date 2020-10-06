namespace nsICreditCard
{
    /// <summary>  
    /// The 'Card' Interface Class  
    /// </summary>  
    interface ICreditCard
    {
        string CardType { get; }
        int CreditLimit { get; set; }
        int AnnualCharge { get; set; }

    }
}

