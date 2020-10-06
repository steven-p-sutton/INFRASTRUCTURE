using ns.ICreditCard;

namespace PlatiniumCreditCard
{
    class PlatinumCreditCardFactory : ICreditCardFactory
    {
        private int _creditLimit;
        private int _annualCharge;

        public PlatinumCreditCardFactory(int creditLimit, int annualCharge)
        {
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }

        public ICreditCard GetCreditCard()
        {
            return new PlatinumCreditCard(_creditLimit, _annualCharge);
        }
    }
}
