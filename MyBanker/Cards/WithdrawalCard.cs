using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Cards
{
    class WithdrawalCard : Card, INoNegative
    {

        public WithdrawalCard(DateTime ExpireDate, bool AgeLimit) : base(ExpireDate, AgeLimit)
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
    }
}
