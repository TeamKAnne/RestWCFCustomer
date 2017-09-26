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
    public class CostumerTests
    {
       

        [TestMethod()]
        public void CostumerTest()
        {
            //Arrange
            Customer c = new Customer();


            //Act

            c.Id = 2;
            int idtest = c.Id;

            //Assert
            Assert.AreEqual(2,idtest);
        }
    }
}