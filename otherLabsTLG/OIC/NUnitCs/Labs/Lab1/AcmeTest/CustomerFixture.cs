using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AcmeTest
{
    [TestFixture]
    public class CustomerFixture
    {
        private void ShowCustomer(Customer cust)
        {
            //Console.WriteLine("id = {0}", cust.CustomerId);
            //Console.WriteLine("First name = {0}", cust.FirstName);
            //Console.WriteLine("Last name = {0}", cust.LastName);
            //Console.WriteLine("Email address = {0}", cust.EmailAddress);
            Assert.Warn("id = {0}", cust.CustomerId);
            Assert.Warn("First name = {0}", cust.FirstName);
            Assert.Warn("Last name = {0}", cust.LastName);
            Assert.Warn("Email address = {0}", cust.EmailAddress);
        }
        [Test]
        public void OneCustomer()
        {
            Customer cust = new Customer("Jenny", "Smith", "JSmith@test.com");
            ShowCustomer(cust);
        }
        [Test]
        //public void AnotherCustomer()
        //{
        //    Customer cust = new Customer("Jennie", "Shanklin", "JSmith@test.com");
        //    ShowCustomer(cust);
        //    Assert.Warn("Id = {0}", cust.CustomerId);
        //}
    }
}
