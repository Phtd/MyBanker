using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class Account:User
    {
        static Random rand = new Random();
        private string accountNumber;
        private double balance;
        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public Account( double Balance, string Name, int Age) :base(Name, Age)
        {
            accountNumber = AccountNumberGenerator();
            balance = Balance;
        }
        string AccountNumberGenerator()
        {
            string result = "";
            for (int i = 0; i < 10; i++)
            {
                result += rand.Next(0, 10);

            }
            return 3520 + result;
        }
    }
}
