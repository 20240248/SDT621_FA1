namespace Question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== CTU SIMPLE ATM SYSTEM =====");

            // Declare variables
            string name;
            double balance;
            double withdawAmount;

            while (true)
            {
                Console.WriteLine("\nHI, WHAT IS YOUR NAME?");
                name = Console.ReadLine();
                // Ensure user enters a valid name
                if (!string.IsNullOrWhiteSpace(name))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid name.");
                }
            }

            Console.WriteLine($"\nWELCOME {name.ToUpper()}");

            // Get account balance from user
            while (true)
            {
                Console.Write($"Enter account balance: ");
                // Ensure user enters a valid balance
                if (double.TryParse(Console.ReadLine(), out balance))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid balance.");
                }
            }

            // Get withdrawal amount from user
            while (true)
            {
                Console.Write($"Enter withdrawal amount: ");
                // Ensure user enters a valid withdrawal amount
                if (double.TryParse(Console.ReadLine(), out withdawAmount))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid withdrawal amount.");
                }
            }

            // Display output
            Console.WriteLine("\nWithdrawal successul!");
            Console.WriteLine($"Updated Balance: {balance - withdawAmount:F2}");
            Console.WriteLine($"Transaction Time: {DateTime.Now}");

        }
    }
}
