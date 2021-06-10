using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Cards
{
    
    class Maestro : Card, INoNegative
    {
        
        public Maestro(DateTime ExpireDate, bool AgeLimit) : base(ExpireDate, AgeLimit)
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
