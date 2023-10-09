using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BankAccount
{
    internal class Program
    {
    static void Main(string[] args)
        {
            string name, accountNumber;
            double balance, amount;
            char choice;
            BankAccount account;

            WriteLine("Welcome to the Ntuthuko Bank");

            do
            {
                WriteLine("\nMenu:");
                WriteLine("1. Create Account");
                WriteLine("2. Deposit");
                WriteLine("3. Withdraw");
                WriteLine("4. Display");
                WriteLine("0. Exit");

                Write("Enter your choice: ");
                choice = ReadLine()[0];

                switch (choice)
                {
                    case '1':
                        Write("Enter name: ");
                        name = ReadLine();
                        Write("Enter account number: ");
                        accountNumber = ReadLine();
                        Write("Enter initial balance: ");
                        balance = double.Parse(ReadLine());
                        account = new BankAccount(name, accountNumber, balance);
                        WriteLine("Account created successfully");
                        break;
                    case '2':
                        Write("Enter amount to deposit: ");
                        amount = double.Parse(ReadLine());
                        account.Deposit(amount);
                        break;
                    case '3':
                        Write("Enter amount to withdraw: ");
                        amount = double.Parse(ReadLine());
                        account.Withdraw(amount);
                        break;
                    case '4':
                        account.Display();
                        break;
                    case '0':
                        WriteLine("Exiting program");
                        break;
                    default:
                        WriteLine("Invalid choice");
                        break;
                }
            } while (choice != '0');
        }
    }
}
