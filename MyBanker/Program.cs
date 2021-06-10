using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBanker.Cards;

namespace MyBanker
{
    class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            int[] visaElectronPrefix = new int[] { 4026, 417500, 4508, 4844, 4923, 4917 };
            int[] mastercardPrefix = new int[] { 51, 52, 53, 54, 55 };
            int[] maestroPrefix = new int[] { 5018, 5020, 5038, 5893, 6304, 6759, 6761, 6762, 6763 };
            int visaDkPrefix = 4;
            int withdrawalcardPrefix = 2400;

            Maestro m = new Maestro(DateTime.Now.AddYears(5).AddMonths(8), true );
            VisaDK vdk = new VisaDK(DateTime.Now.AddYears(5), true );
            int prefix = rand.Next(0, maestroPrefix.Length);
            Console.WriteLine(prefix+m.CardNumber + " " + m.AccountNumber);
            Console.WriteLine(visaDkPrefix+vdk.CardNumber + " " + vdk.AccountNumber);
            Console.ReadKey();
        }
        
       
    }
}
