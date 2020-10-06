using ns.ICreditCard;

namespace MoneybackCreditCard
{
    /// <summary>  
    /// A 'ConcreteCreator' class  
    /// </summary>  
    class MoneybackCreditCardFactory : ICreditCardFactory
    {
        private int _creditLimit;
        private int _annualCharge;

        public MoneybackCreditCardFactory(int creditLimit, int annualCharge)
        {
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }

        public ICreditCard GetCreditCard()
        {
            return new MoneybackCreditCard(_creditLimit, _annualCharge);
        }
    }
}  
