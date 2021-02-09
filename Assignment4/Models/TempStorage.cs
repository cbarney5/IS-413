using System;
using System.Collections.Generic;
namespace Assignment4.Models
{
    public class TempStorage
    {   //Storage for suggested restaurants
        private static List<ApplicationResponse> applications = new List<ApplicationResponse>();

        public static IEnumerable<ApplicationResponse> Applications => applications;

        public static void AddApplication(ApplicationResponse application)
        {
            applications.Add(application);
        }
    }
}
