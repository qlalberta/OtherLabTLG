using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AcmeTest
{
    [TestFixture]
    class CustomersFixture
    {
        private Customers cust = new Customers();
        private void ShowCustomerArray(Customer[] arr)
        {
            if (cust == null)
                Console.WriteLine("No customers.");
            else
                for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i].CustomerId);
            
        }

    }
}
