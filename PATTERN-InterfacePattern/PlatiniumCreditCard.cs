using nsICreditCard;

namespace nsPlatiniumCreditCard
{
    /// <summary>  
    /// A 'ConcreteProduct' class  
    /// </summary>  
    class PlatinumCreditCard : ICreditCard
    {
        //private readonly string _cardType;
        //private int _creditLimit;
        //private int _annualCharge;

        // Constructor

        public PlatinumCreditCard(int creditLimit, int annualCharge)
        {
            //_cardType = "Platinum";
            //_creditLimit = creditLimit;
            //_annualCharge = annualCharge;
            CardType = "Platinum";
            CreditLimit = creditLimit;
            AnnualCharge = annualCharge;
        }

        // ICreditCard Implementation

        public string CardType
        {
            //get { return _cardType; }
            get;
        }

        public int CreditLimit
        {
            //get { return _creditLimit; }
            //set { _creditLimit = value; }
            get;
            set;
        }

        public int AnnualCharge
        {
            //get { return _annualCharge; }
            //set { _annualCharge = value; }
            get;
            set;
        }

        // Platinium specific

        public string Platinium
        {
            get { return "Platinium only property"; }
        }
    }
}  
