using Conductus.PATTERN.Factory.CREDITCARD; 

namespace Conductus.PATTERN.Factory.MONEYBACKCREDITCARD
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
