using Conductus.PATTERN.Factory.CREDITCARD;

namespace Conductus.PATTERN.Factory.TITAINIUMCREDITCARD
{
    /// <summary>  
    /// A 'ConcreteProduct' class  
    /// </summary>  
    class TitaniumCreditCard : ICreditCard
    {
        private readonly string _cardType;
        private int _creditLimit;
        private int _annualCharge;

        public TitaniumCreditCard(int creditLimit, int annualCharge)
        {
            _cardType = "Titanium";
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }

        public string CardType
        {
            get { return _cardType; }
        }

        public int CreditLimit
        {
            get { return _creditLimit; }
            set { _creditLimit = value; }
        }

        public int AnnualCharge
        {
            get { return _annualCharge; }
            set { _annualCharge = value; }
        }
    }
}  
