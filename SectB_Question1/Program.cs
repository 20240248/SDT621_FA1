namespace SectB_Question1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Welcome to Emfuleni Municipality Service Desk ===");
            Console.Write("How many residents do you want to register? ");
            int amountResidents;
            int.TryParse(Console.ReadLine(), out amountResidents);


            List<Resident> residents = new List<Resident>();
            for (int i = 1; i <= amountResidents; i++) 
            {
                Resident newResident = new Resident();

                Console.WriteLine($"\n--- Resident {i} ---");

                newResident.SetName();
                newResident.SetAddress();
                newResident.SetAccountNumber();
                newResident.SetMonthlyUtilityUsage();
                residents.Add(newResident);
            }

            Console.Write("\nHow many service requests do you want to log? ");
            int amountServiceRequests;
            int.TryParse(Console.ReadLine(), out amountServiceRequests);

            List<ServiceRequest> serviceRequests = new List<ServiceRequest>();
            for (int i = 1; i <= amountServiceRequests; i++)
            {
                ServiceRequest newServiceRequest = new ServiceRequest();

                Console.WriteLine($"\n--- Service Request {i} ---");

                
                while (true)
                {
                    Console.Write($"Select resident by number (1 - {residents.Count}): ");
                    
                    if (!int.TryParse(Console.ReadLine(), out int residentNumber) || residentNumber < residents.Count || residentNumber >= 0)
                    {
                        newServiceRequest.SetResident(residents[residentNumber - 1]);
                        break;
                    }

                    Console.WriteLine($"Please enter a valid resident number");
                }
                newServiceRequest.SetRequestType();
                newServiceRequest.SetPriorityLevel();
                newServiceRequest.SetSeverityLevel();
                newServiceRequest.SetResolutionTime();

                serviceRequests.Add(newServiceRequest);
            }

            UtilitiesManager utilitiesManager = new UtilitiesManager();
            utilitiesManager.DisplayServiceRequestQueue(serviceRequests);

            Console.WriteLine("\nPlease select a service request to process:");
            List<ServiceRequest> solvedServiceRequests = new List<ServiceRequest>();
            while (serviceRequests.Count != 0)
            {
                int selectedIndex = -1;

                while (true)
                {
                    Console.Write($"Select service request by number (1 - {serviceRequests.Count}): ");

                    if (int.TryParse(Console.ReadLine(), out int inputNumber) && inputNumber >= 1 && inputNumber <= serviceRequests.Count)
                    {
                        selectedIndex = inputNumber - 1;
                        break;
                    }

                    Console.WriteLine($"Invalid entry. Please enter a number between 1 and {serviceRequests.Count}.");
                }

                var selectedRequest = serviceRequests[selectedIndex];
                utilitiesManager.GenerateServiceReport(selectedRequest);
                solvedServiceRequests.Add(selectedRequest);
                serviceRequests.RemoveAt(selectedIndex);
            }
            
            utilitiesManager.GenerateFinalMunicipalSummary(solvedServiceRequests);

            Console.WriteLine("\nThank you for using the Emfuleni Municipality Service Desk");

        }
    }
}
