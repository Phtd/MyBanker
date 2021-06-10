using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Cards
{
    class VisaElectron : Card, INoNegative, IUseLimit
    {
        private int monthlyMax = 10000;

        public VisaElectron(DateTime ExpireDate, bool AgeLimit) : base(ExpireDate, AgeLimit)
        {

        }

        public void NoNegativeMethod(double SpendAttempt)
        {
            if (Balance > SpendAttempt)
            {
                Balance = Balance - SpendAttempt;

            }
            else Console.WriteLine("You dont have enough money on your account");

        }

        public void UseLimit(double SpendAttempt)
        {

            if (SpendAttempt < this.monthlyMax)
            {
                Balance = Balance - SpendAttempt;
            }
            else Console.WriteLine("You have reached your limit for this month's spending");
          

        }
    }
}
