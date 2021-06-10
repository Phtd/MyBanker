using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class Card : Account
    {
        private DateTime expireDate;
        private bool ageLimit;
        private string cardNumber;


        public DateTime ExpireDate
        {
            get { return expireDate; }
            set { expireDate = value; }
        }
        public string CardNumber
        {
            get { return cardNumber; }
            set { cardNumber = value; }
        }
        public bool AgeLimit
        {
            get { return ageLimit; }
            set { ageLimit = value; }
        }

        public static Random rand = new Random();

        public Card(DateTime ExpireDate, bool AgeLimit) : base(500000000000, "Patrick Heesch", 25)
        {
            expireDate = ExpireDate;
            ageLimit = AgeLimit;
            cardNumber = CardNumberGenerator();
        }
        public virtual string CardNumberGenerator()
        {
            string result = "";

            for (int j = 0; j < 12; j++)
            {
                result += rand.Next(0, 10);
            }

            return result;

        }
    }
}