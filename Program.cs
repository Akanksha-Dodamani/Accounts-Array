namespace ArrayOfAccounts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AccountManagement accountManager = new AccountManagement();
            // show the menu for all other operations other than exit
            int choice;
            do
            {
                Console.WriteLine("What do you wish to do ?");
                Console.WriteLine("1. Create an account");
                Console.WriteLine("2. Display Balance");
                Console.WriteLine("3. Deposit");
                Console.WriteLine("4. Withdraw");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.Write("Invalid choice, Re-enter choice: ");
                }
                switch (choice)
                {
                    case 1:
                        accountManager.CreateAccount();
                        break;
                    case 2:
                        accountManager.DisplayBalance();
                        break;
                    case 3:
                        accountManager.Deposit();
                        break;
                    case 4:
                        accountManager.Withdraw();
                        break;
                    case 5:
                        Console.WriteLine("Thank you! Exiting");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            } while (choice != 5);
        }
    }
}
