using System;
using System.Collections.Generic;
using System.Text;

namespace SectB_Question1
{
    public class UtilitiesManager
    {
        private ServiceRequest HighestPriorityServiceRequest;

        public void SetHighestPriorityServiceRequest(ServiceRequest serviceRequest)
        {
            this.HighestPriorityServiceRequest = serviceRequest;
        }

        public ServiceRequest GetHighestPriorityServiceRequest()
        {
            return this.HighestPriorityServiceRequest;
        }

        private int CalculateUrgencyScore(ServiceRequest serviceRequest)
        {
            int urgencyScore = (int)serviceRequest.GetPriorityLevel() * (int)serviceRequest.GetSeverityLevel() * serviceRequest.GetResolutionTime();
            return urgencyScore;
        }

        private void DisplayServiceRequestDetails(ServiceRequest serviceRequest)
        {
            Console.WriteLine("\n-- Service Request Details --");
            Console.WriteLine($"Request Type: {serviceRequest.GetRequestType()}");
            Console.WriteLine($"Priority Level: {(int)serviceRequest.GetPriorityLevel()}");
            Console.WriteLine($"Severity Level: {(int)serviceRequest.GetSeverityLevel()}");
            Console.WriteLine($"Resolution Time: {serviceRequest.GetResolutionTime()} hours");
        }

        public void DisplayServiceRequestQueue(List<ServiceRequest> serviceRequests)
        {
            Console.WriteLine("\n=== List of Service Requests (Sorted by urgency) ===");
            SortServiceRequestsByUrgency(serviceRequests);
            foreach (ServiceRequest serviceRequest in serviceRequests)
            {
                DisplayServiceRequestDetails(serviceRequest);
                Console.WriteLine($"Urgency Score: {CalculateUrgencyScore(serviceRequest)}");
            }
            SetHighestPriorityServiceRequest(serviceRequests[0]);
        }

        public void SortServiceRequestsByUrgency(List<ServiceRequest> serviceRequests)
        {
            serviceRequests.Sort((sr1, sr2) => CalculateUrgencyScore(sr2).CompareTo(CalculateUrgencyScore(sr1)));
        }

        public void GenerateServiceReport(ServiceRequest serviceRequest)
        {
            Console.WriteLine("\n=== Service Request Report ===");
            Console.WriteLine($"Resident: {serviceRequest.GetResident().GetName()}");
            Console.WriteLine($"Request Type: {serviceRequest.GetRequestType()}");
            Console.WriteLine($"Urgency Score: {CalculateUrgencyScore(serviceRequest)}");
            Console.WriteLine($"Adjusted Resolution: {serviceRequest.GetResolutionTime()} hours");
        }

        public void GenerateFinalMunicipalSummary(List<ServiceRequest> serviceRequests)
        {
            Console.WriteLine("\n=== Final Municipal Summary ===");
            Console.WriteLine($"Highest priority issue: {this.GetHighestPriorityServiceRequest().GetRequestType()}");
            
            foreach (var serviceRequest in serviceRequests)
            {
                GenerateServiceReport(serviceRequest);
            }
        }
    }
}
