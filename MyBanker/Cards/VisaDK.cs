using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Cards
{
    class VisaDK : Card, IUseLimit, ICredit
    {
        private int monthlyMax = 25000;
        private int creditLimit = -20000;
        public VisaDK(DateTime ExpireDate, bool AgeLimit) : base(ExpireDate, AgeLimit)
        {

        }
                                                    //Method to see if the card has reached tis monthly limit of spending
        public void UseLimit(double SpendAttempt)
        {

            if ( SpendAttempt < this.monthlyMax)
            {
                Balance = Balance - SpendAttempt;
            }
            else  Console.WriteLine("You have reached your maximum spending amount for this month");
        }
                                                     //Method from ICredit interface, checks if one has reached the limit of ones credit in the bank
        public void IsCredit(double SpendAttempt)
        {
            if (Balance > creditLimit)
            {
                if (Balance - SpendAttempt < creditLimit)
                {
                    Console.WriteLine("You have reached your credit Limit");
                }
                else Balance -= SpendAttempt;

            }
            else Console.WriteLine("You have reached your credit Limit");
        }

        public override string CardNumberGenerator()
        {
            string result = "";

            for (int j = 0; j < 15; j++)
            {
                result += rand.Next(0, 10);
            }

            return result;

        }
    }
}
