using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RestWCFCustomer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : ICustomer
    {
        private static List<Customer> cList = new List<Customer>()
        { new Customer(1, "Anne", "Bent", 2015), new Customer(2, "kasper", "Haj", 2017)};



        public List<Customer> GetCustomers()
        {
            return cList;

        }

        public void CreateCustomer(Customer c)
        {
           
                foreach (var k in cList)
                {
                    if(c.Id == k.Id)
                    {
                        throw new ArgumentException("Id eksistere allerede.");
                    }
                    else
                    {
                        cList.Add(c);
                    }
                }
            }



        public void DeleteCustomer(int id)
        {
            foreach (var k1 in cList)
            {
                if (id != k1.Id)
                {
                    throw new ArgumentException("Id eksisterer ikke");
                }
                cList.RemoveAll(p => p.Id == id);
            }
            
        }

        public String GetCustomer(int id)
        {

            String str = "";
            foreach (var k2 in cList)
            {
                if (id != k2.Id)
                {
                    throw new ArgumentException("No id Match");
                }

                str = Convert.ToString(k2.FirstName) + Convert.ToString(k2.LastName) + Convert.ToString(k2.Year);
            }

            return str;

        }

        public void UpdateCustomer(Customer c, int id)
        {
            if (!cList.Contains(c))
            {
                throw new ArgumentException();
            }
            var customer = cList.Find(p => p.Id == c.Id);
            customer.Id = c.Id;
            customer.FirstName = c.FirstName;
            customer.LastName = c.LastName;
            customer.Year = c.Year;
        }

    }

 
    
}
