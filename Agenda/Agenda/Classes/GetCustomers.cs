using Agenda.Classes.Querys;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Agenda.Classes
{
    public class CustomerId
    {
        public int id { get; set; }
    }

    public class CustomerResponse
    {
        public List<CustomerId> items { get; set; }
    }

    public class Customer
    {
        public int id { get; set; }
        public string name { get; set; }
        public string salutation { get; set; }
        public string gender { get; set; }
        public string address { get; set; }
        public string postalCode { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string phoneNumber { get; set; }
        public string mobilePhoneNumber { get; set; }
        public string emailAddress { get; set; }

        public void DumpInfo()
        {
            Console.WriteLine($"id: {id}, name: {name}, salutation: {salutation}, gender: {gender}, address: {address}, postal code: {postalCode}, city: {city}, country: {country}, phone number: {phoneNumber}, mobile phone number: {mobilePhoneNumber}, email address: {emailAddress}");
        }
    }

    internal static class GetCustomers
    {
        public static void LoadCustomersFromEBoeking()
        {
            var responseBody = ApiRequest.GetRequest("/relation", new[] {"Type=P"});
            var result = JsonSerializer.Deserialize<CustomerResponse>(responseBody);
            var customers = result.items;
            Debug.WriteLine(customers);

            foreach (var customer in customers)
            {
                var detailedCustomerResponse = ApiRequest.GetRequest("/relation", id: customer.id.ToString());
                var parsedCustomer = JsonSerializer.Deserialize<Customer>(detailedCustomerResponse);
                HomePageForm.Klanten.Add(parsedCustomer);
            }
        }
    }
}
