using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Cards
{
    class Mastercard : Card
    {
        private int dailyMax = 5000;
        private int monthlyMax = 30000;
        private int creditLimit = -40000;
        public Mastercard(DateTime ExpireDate, bool AgeLimit) : base(ExpireDate, AgeLimit)
        {

        }
                                                    //Checks if ones has reached their monthly or daily spending limit
        public void UseLimit(double SpendAttempt)
        {

            if (SpendAttempt < this.dailyMax && SpendAttempt < this.monthlyMax)
            {
                Balance = Balance - SpendAttempt;
            }
            else if (SpendAttempt > this.dailyMax)
            {
                Console.WriteLine("You have reached your daily limit for spending");
            }
            else  Console.WriteLine("You have reached your maximum spending amount for this month");
        }
                                                        //Method to check if limit for credit has been reached
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
    }
}


