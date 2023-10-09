using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BankAccount
{
    internal class BankAccount
    {
        public string name;
        public string accountNumber;
        public double balance;

        // Constructor
        public BankAccount(string name, string accountNumber, double balance)
        {
            name = name;
            accountNumber = accountNumber;
            balance = balance;
        }

        // Deposit function
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                WriteLine($"Deposited {amount:C}. New balance is {balance:C}");
            }
            else
            {
                WriteLine("Amount to deposit must be greater than 0");
            }
        }

        // Withdraw function
        public void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                WriteLine($"Withdrawn {amount:C}. New balance is {balance:C}");
            }
            else
            {
                WriteLine("Insufficient balance");
            }
        }

        // Display function
        public void Display()
        {
            WriteLine($"Account Holder: {name}");
            WriteLine($"Account Number: {accountNumber}");
            WriteLine($"Balance: {balance:C}");
        }
    }
}
