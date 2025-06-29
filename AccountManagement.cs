using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfAccounts
{
    public class AccountManagement
    {
        public double balance, amount;
        public static int accountCount = 0, size = 0;
        Account[] accounts;
        public void CreateAccount()
        {
            Console.Write("How many number of accounts do you want to create? ");
            size = int.Parse(Console.ReadLine());
            accounts = new Account[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Welcome! Enter Account Details to create new Account");
                accounts[accountCount] = new Account();
                accountCount++;
                Console.WriteLine("Account successfully created!");
                Console.WriteLine();
            }
            foreach (var account in accounts)
            {
                account.studentDetails();
            }
        }
        public void DisplayBalance()
        {
            string inputAccount;
            Console.Write("Account number: ");
            inputAccount = Console.ReadLine();
            for (int i = 0; i < size; i++)
            {
                if (inputAccount == accounts[i].accountNumber)
                {
                    Console.WriteLine($"Balance: {accounts[i].balance}");
                    Console.WriteLine();
                    return;
                }
            }
            Console.WriteLine("Given account number does not exist!!");
        }
        public void Deposit()
        {
            string inputAccount;
            Console.Write("Account number: ");
            inputAccount = Console.ReadLine();
            for (int i = 0; i < size; i++)
            {
                if (accounts[i].accountNumber == inputAccount)
                {
                    Console.WriteLine("Your account balance is: " + accounts[i].balance);
                    Console.Write("Enter Amount to deposit: ");
                    double.TryParse(Console.ReadLine(), out amount);
                    accounts[i].balance += amount;
                    Console.WriteLine("Amount deposited successfully!");
                    Console.WriteLine("Your updated account balance is: " + accounts[i].balance);
                    return;
                }
            }
            Console.WriteLine("Given account number does not exist!!");
        }
        public void Withdraw()
        {
            string inputAccount;
            Console.Write("Account number: ");
            inputAccount = Console.ReadLine();
            for (int i = 0; i < size; i++)
            {
                if (accounts[i].accountNumber == inputAccount)
                {
                    Console.WriteLine("Your account balance is: " + accounts[i].balance);
                    Console.Write("Enter Amount to withdraw: ");
                    double.TryParse(Console.ReadLine(), out amount);
                    accounts[i].balance -= amount;
                    Console.WriteLine("Amount withdrawn successfully!");
                    Console.WriteLine("Your updated account balance is: " + accounts[i].balance);
                    return;
                }
            }
            Console.WriteLine("Given account number does not exist!!");
        }

    }
}
