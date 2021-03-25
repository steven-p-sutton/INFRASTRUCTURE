using Conductus.PATTERN.Factory.CREDITCARD;

namespace Conductus.PATTERN.Factory.TITAINIUMCREDITCARD
{
    class TitaniumCreditCardFactory : ICreditCardFactory
    {
        private int _creditLimit;
        private int _annualCharge;

        public TitaniumCreditCardFactory(int creditLimit, int annualCharge)
        {
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }

        public ICreditCard GetCreditCard()
        {
            return new TitaniumCreditCard(_creditLimit, _annualCharge);
        }
    }
} 
