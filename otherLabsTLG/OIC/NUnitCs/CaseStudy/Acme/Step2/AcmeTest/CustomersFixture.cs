using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace AcmeTest
{
	[TestFixture]
	class CustomersFixture
	{
		private Customers custs;

		private void ShowCustomerArray(Customer[] arr)
		{
			if (custs == null)
			{
				Console.WriteLine("<null>");
				return;
			}
			for (int i = 0; i < arr.Length; i++)
			{
				string id = arr[i].CustomerId.ToString();
				string first = arr[i].FirstName.PadRight(12);
				string last = arr[i].LastName.PadRight(12);
				string email = arr[i].EmailAddress.PadRight(20);
				string str = id + "   " + first + "   " + last + "   " + email;
				Console.WriteLine(str);
			}
		}

		[SetUp]
		public void InitCustomers()
		{
			custs = new Customers();
			Console.WriteLine("Customers instance created");
		}

		[Test]
		public void OneCustomer()	//1
		{
			int id = custs.RegisterCustomer("Joe", "Blow", "foo@bar.com");
			Customer[] arr = custs.GetCustomer(id);
			ShowCustomerArray(arr);
			Assert.AreEqual(arr[0].FirstName, "Joe");
			Assert.AreEqual(arr[0].LastName, "Blow");
			Assert.AreEqual(arr[0].EmailAddress, "foo@bar.com");
		}
		[Test]
		public void TwoCustomers()	//2
		{
			int id1 = custs.RegisterCustomer("Joe", "Blow", "foo@bar.com");
			int id2 = custs.RegisterCustomer("Amy", "Smith", "amy@bar.com");
			Customer[] arr = custs.GetCustomer(-1);
			ShowCustomerArray(arr);
			Assert.AreEqual(arr[0].FirstName, "Joe");
			Assert.AreEqual(arr[0].LastName, "Blow");
			Assert.AreEqual(arr[0].EmailAddress, "foo@bar.com");
			Assert.AreEqual(arr[1].FirstName, "Amy");
			Assert.AreEqual(arr[1].LastName, "Smith");
			Assert.AreEqual(arr[1].EmailAddress, "amy@bar.com");
		}
		[Test]
		public void OneCustomerEmail()	//3
		{
			int id = custs.RegisterCustomer("Joe", "Blow", "foo@bar.com");
			Customer[] arr = custs.GetCustomer(id);
			ShowCustomerArray(arr);
			custs.ChangeEmailAddress(id, "new@bar.com");
			arr = custs.GetCustomer(id);
			ShowCustomerArray(arr);
			Assert.AreEqual(arr[0].EmailAddress, "new@bar.com");
		}
		[Test]
		public void NoCustomers()	//4
		{
			Customer[] arr = custs.GetCustomer(-1);
			ShowCustomerArray(arr);
			Assert.AreEqual(0, arr.Length);
		}
		[Test]
		public void RegUnreg()		//5
		{
			int id = custs.RegisterCustomer("John", "Doe", "");
			custs.UnregisterCustomer(id);
			Customer[] arr = custs.GetCustomer(-1);
			Assert.AreEqual(0, arr.Length);
		}
		[Test]
		public void Reg3UnregFirst()	//6
		{
			int id1 = custs.RegisterCustomer("John", "Doe", "");
			int id2 = custs.RegisterCustomer("John2", "Doe2", "");
			int id3 = custs.RegisterCustomer("John3", "Doe3", "");
			custs.UnregisterCustomer(id1);
			Customer[] arr = custs.GetCustomer(-1);
			Assert.AreEqual(arr[0].FirstName, "John2");
			Assert.AreEqual(arr[0].LastName, "Doe2");
			Assert.AreEqual(arr[0].EmailAddress, "");
			Assert.AreEqual(arr[1].FirstName, "John3");
			Assert.AreEqual(arr[1].LastName, "Doe3");
			Assert.AreEqual(arr[1].EmailAddress, "");
		}
		[Test]
		public void Reg3UnregLast()	//7
		{
			int id1 = custs.RegisterCustomer("John", "Doe", "");
			int id2 = custs.RegisterCustomer("John2", "Doe2", "");
			int id3 = custs.RegisterCustomer("John3", "Doe3", "");
			custs.UnregisterCustomer(id3);
			Customer[] arr = custs.GetCustomer(-1);
			Assert.AreEqual(arr[0].FirstName, "John");
			Assert.AreEqual(arr[0].LastName, "Doe");
			Assert.AreEqual(arr[0].EmailAddress, "");
			Assert.AreEqual(arr[1].FirstName, "John2");
			Assert.AreEqual(arr[1].LastName, "Doe2");
			Assert.AreEqual(arr[1].EmailAddress, "");
		}
		[Test]
		[Ignore]
		public void Reg100()	//8
		{
			for (int i = 0; i < 100; i++)
			{
				custs.RegisterCustomer("Joe", "Smith", "joe@big.com");
			}
			Customer[] arr = custs.GetCustomer(-1);
			Assert.AreEqual(arr.Length, 100);
		}
		[Test]
		[Ignore]
		public void RegUnreg100()	//9
		{
			int[] ids = new int[100];
			for (int i = 0; i < 100; i++)
			{
				ids[i] = custs.RegisterCustomer("Joe", "Smith", "joe@big.com");
			}
			for (int i = 0; i < 100; i++)
			{
				custs.UnregisterCustomer(ids[i]);
			}
			Customer[] arr = custs.GetCustomer(-1);
			Assert.AreEqual(arr.Length, 0);
		}
	}
}
