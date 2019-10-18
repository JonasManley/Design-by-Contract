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

        /// <summary>
        /// Allow user to deposit money into their accounts and the balance will incease 
        /// </summary>
        /// <param name="amount">the amount of money the user would like to deposit</param>
        /// <returns></returns>
        public double Deposit(double amount)
        {
            var value = amount;
            Contract.Requires(amount > 0, "amount is less then/or 0");
            Contract.Ensures(Contract.Result<double>() >= 0);
            Contract.EnsuresOnThrow<ArgumentException>(Contract.OldValue<double>(value) == amount);

            if (amount > _balance) throw new Exception("ERROR! amount exceeds the balance, not possible...");
            var NewBalance =_balance + amount;

            return NewBalance;
        }

        /// <summary>
        /// Allow user to withdraw money from their accounts and the balance will deincease with the descired amount
        /// </summary>
        /// <param name="amount">the amount of money the user would like to withdraw</param>
        /// <returns></returns>
        public double Withdraw(double amount)
        {
            var value = amount;
            Contract.Requires(amount > 0, "amount is less then/or 0");
            Contract.Requires(_balance > amount);     
            Contract.Ensures(Contract.Result<double>() >= 0);
            Contract.EnsuresOnThrow<ArgumentException>(Contract.OldValue<double>(value) == amount);

            if (amount < 0) throw new Exception("ERROR! amount cannot be negative, please try agian...");
            var NewBalance = _balance - amount;

            return NewBalance;
        }
    }
}
