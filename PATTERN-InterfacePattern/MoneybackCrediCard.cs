using nsICreditCard;

namespace nsMoneyBackCreditCard
{
    /// <summary>  
    /// A 'ConcreteProduct' class  
    /// </summary>  
    class MoneyBackCreditCard : ICreditCard
    {
        //private readonly string _cardType;
        //private int _creditLimit;
        //private int _annualCharge;

        // Constructor

        public MoneyBackCreditCard(int creditLimit, int annualCharge)
        {
            //_cardType = "MoneyBack";
            //_creditLimit = creditLimit;
            //_annualCharge = annualCharge;
            CardType = "MoneyBack";
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

        // Moneyback Specific

        public string MoneyBack
        {
            get { return "MoneyBack only property"; }
        }
    }
}
