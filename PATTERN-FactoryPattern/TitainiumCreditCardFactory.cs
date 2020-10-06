using ns.ICreditCard;

namespace TitainiumCreditCard
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
