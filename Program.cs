using System;
using Microsoft.OData.SampleService.Models.TripPin;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo_OData_services
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementing OData Services");
            ListPeople().Wait();
        }
       static async Task ListPeople()
        {
            var serviceRoot = "https://services.odata.org/V4/TripPinServiceRW/";
            var context = new DefaultContainer(new Uri(serviceRoot));

            IEnumerable<Person> people = await context.People.ExecuteAsync();
            foreach (var person in people)
            {
                Console.WriteLine("{0} {1}", person.FirstName, person.LastName);
            }
        }
    }
}
