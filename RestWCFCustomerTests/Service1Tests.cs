using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestWCFCustomer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestWCFCustomer.Tests
{
    [TestClass()]
    public class Service1Tests
    {
        [TestMethod()]
        public void GetCustomersTest()
        {
            //Arrange
            Service1 test = new Service1();

            //Act
            var count = test.GetCustomers().Count();

            //Assert
            Assert.AreEqual(2, count);
            
        }
    }
}