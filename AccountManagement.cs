using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ArrayOfAccounts
{
    public class AccountManagement
    {
        public double balance, amount;
        public static int accountSize = 0;
        private Account[] accounts;
        private readonly string filePath = @"C:\Users\akanksha.dodamani\Downloads\Account.json";

        public AccountManagement()
        {
            LoadAccounts();
        }
        public void LoadAccounts()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                accounts = JsonSerializer.Deserialize<Account[]>(json);
                if (accounts.Length == 0)
                {
                    Console.WriteLine("No data exists!!");
                    return;
                }
                foreach (var account in accounts)
                {
                    account.AccountDetails();
                }
                return;
            }
            Console.WriteLine("No file exists!!");
        }
        public void SaveAccounts()
        {
            string json = JsonSerializer.Serialize(accounts, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }
        public void CreateAccount()
        {
            Console.Write("How many number of accounts do you want to create? ");
            accountSize = int.Parse(Console.ReadLine());
            Account[] newAccounts = new Account[accountSize];
            for (int i = 0; i < accountSize; i++)
            {
                Console.WriteLine("Welcome! Enter Account Details to create new Account");
                newAccounts[i] = new Account();
                newAccounts[i].AccountDetailsInput();
                Console.WriteLine("Account successfully created!");
            }
            if (accounts != null && accounts.Length > 0)
            {
                accounts = accounts.Concat(newAccounts).ToArray();
            }
            else
            {
                accounts = newAccounts;
            }
            SaveAccounts();
            Console.WriteLine();
            foreach (var account in accounts)
            {
                account.AccountDetails();
            }
        }
        public void DisplayBalance()
        {
            string inputAccount;
            Console.Write("Account number: ");
            inputAccount = Console.ReadLine();
            for (int i = 0; i < accountSize; i++)
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
            for (int i = 0; i < accountSize; i++)
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
            {
                string inputAccount;
                Console.Write("Account number: ");
                inputAccount = Console.ReadLine();
                for (int i = 0; i < accountSize; i++)
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
}
