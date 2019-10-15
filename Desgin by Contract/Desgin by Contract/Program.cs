using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desgin_by_Contract
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acccount = new Account();

            //Example: Going bad
            //var deposit = acccount.Deposit(0);
            //Console.WriteLine("Result =" + deposit);

            //Example: Going good
            //var deposit = acccount.Deposit(200);
            //Console.WriteLine("Result =" + deposit);

            //Example: Going bad
            //var withdrawbad = acccount.Withdraw(700);

            //Example: Going good
            //var withdrawGood = acccount.Withdraw(242);
            //Console.WriteLine(withdrawGood);

            Console.ReadLine();
        }
    }
}
