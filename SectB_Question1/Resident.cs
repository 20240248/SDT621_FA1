using System;
using System.Collections.Generic;
using System.Text;

namespace SectB_Question1
{
    public class Resident
    {
        private string Name;
        private string Address;
        private string AccountNumber;
        private double MonthlyUtilityUsage;

        public Resident() { }

        public string GetName() 
        {
            return this.Name;
        }

        public void SetName()
        {
            while (true)
            {
                Console.Write("Name: ");
                this.Name = Console.ReadLine();
                // Ensure user enters a valid name
                if (!string.IsNullOrWhiteSpace(this.Name))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid name.");
                }
            }
        }

        public void SetAddress()
        {
            while (true)
            {
                Console.Write("Address: ");
                this.Address = Console.ReadLine();
                // Ensure user enters a valid address
                if (!string.IsNullOrWhiteSpace(this.Address))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid address.");
                }
            }
        }

        public void SetAccountNumber()
        {
            while (true)
            {
                Console.Write("Account Number: ");
                this.AccountNumber = Console.ReadLine();
                // Ensure user enters a valid account number
                if (!string.IsNullOrWhiteSpace(this.AccountNumber))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid account number.");
                }
            }
        }

        public void SetMonthlyUtilityUsage()
        {
            while (true)
            {
                Console.Write("Monthly Utility Usage (kWh or litres): ");
                // Ensure user enters a valid monthly utility usage number
                if (double.TryParse(Console.ReadLine(), out this.MonthlyUtilityUsage))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }
    }
}
