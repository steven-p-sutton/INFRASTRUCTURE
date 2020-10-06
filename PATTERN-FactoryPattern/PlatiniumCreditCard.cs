using ns.ICreditCard;

namespace PlatiniumCreditCard
{
    /// <summary>  
    /// A 'ConcreteProduct' class  
    /// </summary>  
    class PlatinumCreditCard : ICreditCard
    {
        private readonly string _cardType;
        private int _creditLimit;
        private int _annualCharge;

        public PlatinumCreditCard(int creditLimit, int annualCharge)
        {
            _cardType = "Platinum";
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
