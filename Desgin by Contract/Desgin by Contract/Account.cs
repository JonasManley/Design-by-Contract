using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace Desgin_by_Contract
{
    class Account
    {
        public double _balance =  500;

        public Account()
        {
           
        }


        public double Deposit(double amount)
        {
            var value = amount;
            Contract.Requires(amount > 0, "amount is less then/or 0");
            Contract.Ensures(Contract.Result<double>() >= 0);
            Contract.EnsuresOnThrow<ArgumentException>(Contract.OldValue<double>(value) == amount);

            var NewBalance =_balance + amount;

            return NewBalance;
        }

        public double Withdraw(double amount)
        {
            var value = amount;
            Contract.Requires(amount > 0, "amount is less then/or 0");
            Contract.Requires(_balance > amount);     
            Contract.Ensures(Contract.Result<double>() >= 0);
            Contract.EnsuresOnThrow<ArgumentException>(Contract.OldValue<double>(value) == amount);

            var NewBalance = _balance - amount;

            return NewBalance;
        }
    }
}
