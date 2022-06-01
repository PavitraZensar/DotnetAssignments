using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public interface CreditCard
    {
        string GetCardType();
        float GetCreditLimit();
        int GetAnnualFees();
    }

    public class Platinum : CreditCard
    {
        public int GetAnnualFees()
        {
            return 5000;
        }

        public string GetCardType()
        {
            return " Platinum Card";
        }

        public float GetCreditLimit()
        {
            return 50000;
        }
    }

    public class Titanium : CreditCard
    {
        public int GetAnnualFees()
        {
            return 6000;
        }

        public string GetCardType()
        {
            return "Titanium Card";
        }

        public float GetCreditLimit()
        {
            return 60000;
        }
    }

    public class MoneyBack : CreditCard
    {
        public int GetAnnualFees()
        {
            return 7000;
        }

        public string GetCardType()
        {
            return " MoneyBack Card";
        }

        public float GetCreditLimit()
        {
            return 70000;
        }
    }


    public abstract class CreditCardFactory
    {
        protected abstract CreditCard CreateCard();

        public CreditCard GenerateCard()
        {
            return this.CreateCard();
        }
        internal static object CreditCard(string choice)
        {
            throw (new NotImplementedException());
        }


    }


    public class MoneybackFactory : CreditCardFactory
    {
        protected override CreditCard CreateCard()
        {
            CreditCard ctype = new MoneyBack();
            return ctype;
        }
    }

    public class TitaniumFactory : CreditCardFactory
    {
        protected override CreditCard CreateCard()
        {
            CreditCard ctype = new Titanium();
            return ctype;
        }

    }

    public class PlatinumFactory : CreditCardFactory
    {
        protected override CreditCard CreateCard()
        {
            CreditCard ctype = new Platinum();
            return ctype;
        }
    }
    class Program
    {
        static void Main()
        {                   
        CreditCard cc = new PlatinumFactory().GenerateCard();
        if (cc != null)
        {
           Console.WriteLine("Card Type is : " + " " + cc.GetCardType());
           Console.WriteLine("Credit Limit is :" + " " + cc.GetCreditLimit());
           Console.WriteLine("Annual Fees is: " + " " + cc.GetAnnualFees());
        }
         else
         {
             Console.WriteLine("Invalid Card Type");
         }
         Console.WriteLine("---------------------------");
         cc = new TitaniumFactory().GenerateCard();
         if (cc != null)
         {
                  Console.WriteLine("Card Type is : " + " " + cc.GetCardType());
                  Console.WriteLine("Credit Limit is :" + " " + cc.GetCreditLimit());
                  Console.WriteLine("Annual Fees is: " + " " + cc.GetAnnualFees());
         }
         else
         {
             Console.WriteLine("Invalid Card Type");
         }
             Console.WriteLine("---------------------------");
             cc = new MoneybackFactory().GenerateCard();
        if (cc != null)
         {
             Console.WriteLine("Card Type is : " + " " + cc.GetCardType());
             Console.WriteLine("Credit Limit is :" + " " + cc.GetCreditLimit());
             Console.WriteLine("Annual Fees is: " + " " + cc.GetAnnualFees());
         }
         else
         {
             Console.WriteLine("Invalid Card Type........");
         }

         Console.ReadLine();
    }
    }






















































































































































    /* class Program
     {
         static void Main()
         {
             bool null = false;
             while (=null)
             {
                 Console.WriteLine();
                 Console.WriteLine("Platinum Card");
                 Console.WriteLine("Titanium Card");
                 Console.WriteLine("MoneyBack Card");
                 Console.WriteLine("NUll");
                 Console.WriteLine();
                 Console.Write("Select Card Type :");
                 string choice = Console.ReadLine();
                 if (choice == "null")
                 {
                     null = true;
                 }

                 else
                 {
                     var credit = CreditCardFactory.CreditCard(choice);
                     Console.WriteLine("CardType: { credit.CardType}\nCardLimit is: { credit.CardLimit}\n and the AnnualCharge is: { credit.AnnualCharge}");
                 }
                 Console.WriteLine();
                 Console.WriteLine("Press Enter for Menu");
                 Console.ReadLine();
                 Console.Clear();
             }
         }
     }*/
}



