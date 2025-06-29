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
        public double balance;
        public string accountNumber, name, accountType;
        public Account()
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
            while (!double.TryParse(Console.ReadLine(), out balance) || balance < 500)
            {
                Console.Write("Invalid. Re-enter Opening Balance: ");
                balance = double.Parse(Console.ReadLine());
            }
        }
        public void studentDetails()
        {
            Console.WriteLine($"Account number: {accountNumber}, Name: {name}, AccountType: {accountType}, Balance: {balance}");
        }
    }
}
