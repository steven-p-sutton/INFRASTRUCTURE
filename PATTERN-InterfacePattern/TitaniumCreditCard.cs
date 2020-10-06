using nsICreditCard;

namespace nsTitainiumCreditCard
{
    /// <summary>  
    /// A 'ConcreteProduct' class  
    /// </summary>  
    class TitaniumCreditCard : ICreditCard
    {
        //private readonly string _cardType;
        //private int _creditLimit;
        //private int _annualCharge;

        // Constructor

        public TitaniumCreditCard(int creditLimit, int annualCharge)
        {
            //_cardType = "Titanium";
            //_creditLimit = creditLimit;
            //_annualCharge = annualCharge;
            CardType = "Titanium";
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

        // Titanium specific

        public string Titanium
        {
            get { return "Titainium only property"; }
        }
    }
}  
