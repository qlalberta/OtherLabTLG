﻿using System;
using NUnit.Framework;

namespace AcmeTest
{
	[TestFixture]
	public class CustomerFixture
	{
		private void ShowCustomer(Customer cust)
		{
			Console.WriteLine("id = {0}", cust.CustomerId);
			Console.WriteLine("first = {0}", cust.FirstName);
			Console.WriteLine("last = {0}", cust.LastName);
			Console.WriteLine("email = {0}", cust.EmailAddress);
		}
		[Test]
		public void OneCustomer()
		{
			Customer cust = new Customer("Joe", "Blow", "foo@bar.com");
			ShowCustomer(cust);
			Assert.AreEqual(cust.FirstName, "Joe", "FirstName not equal");
			Assert.AreEqual(cust.LastName, "Blow", "LastName not equal");
			Assert.AreEqual(cust.EmailAddress, "foo@bar.com", "EmailAddress not equal");
		}
		[Test]
		public void TwoCustomers()
		{
			Customer cust1 = new Customer("Joe", "Blow", "foo@bar.com");
			ShowCustomer(cust1);
			Customer cust2 = new Customer("Amy", "Smith", "amy@foo.com");
			ShowCustomer(cust2);
			Assert.AreNotEqual(cust1.CustomerId, cust2.CustomerId);
		}
	}
}
