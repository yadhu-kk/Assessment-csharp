using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TASK-2

namespace bankingOperations
{
    public class BankAccount
    {
        public string AccountHolder { get; set; }
        public int AccountNumber { get; set; }
        public Decimal AccountBalance { get; set; }

        public BankAccount(string accountHolder, int accountNumber, decimal accountBalance)
        {
            AccountHolder = accountHolder;
            AccountNumber = accountNumber;
            AccountBalance = accountBalance;
        }
        public void deposite(decimal amount)
        {
            AccountBalance += amount;
            Console.WriteLine($"{amount} deposited. . New balance is {AccountBalance}");
        }
        public void withdraw(decimal amount) {
            if (AccountBalance >= amount)
            {
                AccountBalance -= amount;
                Console.WriteLine($"{amount} withdrawn. .current balance is{AccountBalance}");
            }
            else
            {
                Console.WriteLine("invalid fund");
            }
        }
        public void displayAccountDetails() {
            Console.WriteLine($"Name : {AccountHolder} , No : {AccountNumber} , Balance : {AccountBalance}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount("yadhu", 22550, 1000.00m);
            Console.WriteLine("enter deposite amount : ");
            decimal depositeAmount=Convert.ToDecimal(Console.ReadLine());
            acc.deposite(depositeAmount);
            Console.WriteLine("enter valid withdraw amount : ");
            decimal withdrawAmount=Convert.ToDecimal(Console.ReadLine());
            acc.withdraw(withdrawAmount);
            acc.displayAccountDetails();
            Console.ReadLine();
        }
    }
}
