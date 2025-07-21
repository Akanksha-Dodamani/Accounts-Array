using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ArrayOfAccounts
{
    public class Account
    {
        public double balance { get; set; }
        public string accountNumber { get; set; }
        public string name { get; set; }
        public string accountType { get; set; }

        public Account() { }
        public void AccountDetailsInput()
        {
            // take account details and validate it
            Console.Write("Account Number: ");
            accountNumber = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(accountNumber))
            {
                Console.Write("Invalid. Re-enter Account Number: ");
                accountNumber = Console.ReadLine();
            }

            Console.Write("Account Holder Name: ");
            name = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(name))
            {
                Console.Write("Invalid. Re-enter Account Holder Name: ");
                name = Console.ReadLine();
            }

            Console.Write("Account Type (savings/current): ");
            accountType = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(accountType) || (accountType.ToLower() != "savings" && accountType.ToLower() != "current"))
            {
                Console.Write("Invalid. Re-enter Bank type: ");
                accountType = Console.ReadLine();
            }

            Console.Write("Opening Balance (Minimum amount should be 500): ");
            if (double.TryParse(Console.ReadLine(), out double bal) && bal >= 500)
            {
                balance = bal;
                return;
            }
            Console.Write("Invalid. Re-enter Opening Balance: ");
        }
        public void AccountDetails()
        {
            Console.WriteLine($"Account number: {accountNumber}, Name: {name}, AccountType: {accountType}, Balance: {balance}");
        }
    }
}
