using System;
using Conductus.PATTERN.Interface.CREDITCARD;
using Conductus.PATTERN.Interface.MONEYBACKCREDITCARD;
using Conductus.PATTERN.Interface.PLATINIUMCREDITCARD;
using Conductus.PATTERN.Interface.TITAINIUMCREDITCARD;

// An example of interface pattern without using factory objects as per PATTERN-Factory example

// Also shows how objects derrived from the interface class can add their own methods & properties so
// long as the interface contract is implementated. The object varienats can be detected and processed 
// specifically for each object type

namespace InterfacePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditCard card = null;
            Console.Write("Enter the card type you would like to visit: ");
            string car = Console.ReadLine();

            switch (car.ToLower())
            {
                case "moneyback":
                    card = new MoneyBackCreditCard(50000, 0);
                    break;
                case "titanium":
                    card = new TitaniumCreditCard(100000, 500);
                    break;
                case "platinum":
                    card = new PlatinumCreditCard(500000, 1000);
                    break;
                default:
                    break;
            }

            Console.WriteLine("\nYour card details are below : \n");
            Console.WriteLine("Card Type: {0}\nCredit Limit: {1}\nAnnual Charge: {2}",
                card.CardType, card.CreditLimit, card.AnnualCharge);

            // Varient object handling. Objects implementating an interface contract can have
            // additional properties and methods over and above the interface specification contract

            // Detect an object type then call it's specific property

            if (card is MoneyBackCreditCard moneyBackCard)
            {
                Console.WriteLine("\nMoneyBack Specific : {0}\n", moneyBackCard.MoneyBack);
            }
            if (card is TitaniumCreditCard titaniumCard)
            {
                Console.WriteLine("\nTitanium Specific : {0}\n", titaniumCard.Titanium);
            }
            if (card is PlatinumCreditCard platiniumCard)
            {
                Console.WriteLine("\nPlatinium Specific : {0}\n", platiniumCard.Platinium);
            }
            Console.ReadKey();
        }
    }
}
