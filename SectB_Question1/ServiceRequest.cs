using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace SectB_Question1
{
    public class ServiceRequest
    {
        private string RequestType;
        private Enums.PriorityLevels PriorityLevel;
        private Enums.SeverityLevels SeverityLevel;
        private int ResolutionTime; // in hours
        private Resident Resident;

        public ServiceRequest() { }

        public Enums.PriorityLevels GetPriorityLevel()
        {
            return this.PriorityLevel;
        }

        public Enums.SeverityLevels GetSeverityLevel()
        {
            return this.SeverityLevel;
        }

        public int GetResolutionTime()
        {
            return this.ResolutionTime;
        }

        public string GetRequestType()
        {
            return this.RequestType;
        }

        public Resident GetResident()
        {
            return this.Resident;
        }

        public void SetRequestType()
        {
            while (true)
            {
                Console.Write("Request Type (e.g., Water Outage, Burst Pipe): ");
                // Ensure user enters a valid request type
                if (!string.IsNullOrWhiteSpace(Console.ReadLine()))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid request type.");
                }
            }
        }

        public void SetResident(Resident resident)
        {
            this.Resident = resident;
        }

        public void SetPriorityLevel()
        {
            while (true)
            {
                Console.Write("Priority Level (1-5): ");
                if (int.TryParse(Console.ReadLine(), out int priority) && priority >= 1 && priority <= 5)
                {
                    this.PriorityLevel = (Enums.PriorityLevels)priority;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
                }
            }
        }

        public void SetSeverityLevel()
        {
            while (true)
            {
                Console.Write("Severity Level (1-10): ");
                if (int.TryParse(Console.ReadLine(), out int severity) && severity >= 1 && severity <= 10)
                {
                    this.SeverityLevel = (Enums.SeverityLevels)severity;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 10.");
                }
            }
        }

        public void SetResolutionTime()
        {
            while (true)
            {
                Console.Write("Estimated Resolution hours: ");
                if (int.TryParse(Console.ReadLine(), out int resolutionTime) && resolutionTime >= 0)
                {
                    this.ResolutionTime = resolutionTime;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a non-negative number.");
                }
            }
        }
    }
}