using System;

using Conductus.PATTERN.Factory.MONEYBACKCREDITCARD;
using Conductus.PATTERN.Factory.PLATINIUMCREDITCARD;
using Conductus.PATTERN.Factory.TITAINIUMCREDITCARD;

namespace Conductus.PATTERN.Factory.CREDITCARD
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditCardFactory factory = null;
            Console.Write("Enter the card type you would like to visit: ");
            string car = Console.ReadLine();

            switch (car.ToLower())
            {
                case "moneyback":
                    factory = new MoneybackCreditCardFactory(50000, 0);
                    break;
                case "titanium":
                    factory = new TitaniumCreditCardFactory(100000, 500);
                    break;
                case "platinum":
                    factory = new PlatinumCreditCardFactory(500000, 1000);
                    break;
                default:
                    break;
            }

            ICreditCard creditCard = factory.GetCreditCard();
            Console.WriteLine("\nYour card details are below : \n");
            Console.WriteLine("Card Type: {0}\nCredit Limit: {1}\nAnnual Charge: {2}",
                creditCard.CardType, creditCard.CreditLimit, creditCard.AnnualCharge);
            Console.ReadKey();
        }
    }
}
