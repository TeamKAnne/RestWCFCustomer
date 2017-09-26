using ClientCustomer.CustomerService;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClientCustomer
{
    class Program
    {
        private static async Task<IList<Customer>> GetCustomersAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                string content = await client.GetStringAsync("http://restwcfcustomer20170926015151.azurewebsites.net/CustomerHandler.svc/customers/");
                IList<Customer> cList = JsonConvert.DeserializeObject<IList<Customer>>(content);
                return cList;
            }
        }


        static void Main(string[] args)
        {
            foreach (var kunder in GetCustomersAsync().Result)
            {
                Console.WriteLine(kunder.Id + kunder.FirstName + kunder.LastName + kunder.Year);
            }
            Console.ReadLine();
        }
    }
}
