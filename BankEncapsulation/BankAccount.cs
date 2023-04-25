﻿using System;
namespace BankEncapsulation
{
	internal class BankAccount
	{
		public BankAccount()
		{
		}
		private double balance = 0;

		public void Deposit(double amount)
		{
			balance += amount;
		}

        public void Withdraw(double amount)
        {
            balance -= amount;

        }

        public double GetBalance()
		{
			return balance;
		}

		

	}
}

