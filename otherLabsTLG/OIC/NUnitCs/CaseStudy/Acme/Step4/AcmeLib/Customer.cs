// Customer.cs

using System;
using System.Collections.Generic;

public interface ICustomer
{
	int RegisterCustomer(string firstName, string lastName, string emailAddress);
	void UnregisterCustomer(int id);
	Customer[] GetCustomer(int id);
	void ChangeEmailAddress(int id, string emailAddress);
}

public class Customer
{
	public int CustomerId;
	public string FirstName;
	public string LastName;
	public string EmailAddress;
	static private int nextCustId = 1;
	public Customer(string first, string last, string email)
	{
		CustomerId = nextCustId++;
		FirstName = first;
		LastName = last;
		EmailAddress = email;
	}
	public Customer()
	{
	}
	public Customer(int id)
	{
		CustomerId = id;
		FirstName = "";
		LastName = "";
		EmailAddress = "";
	}
	public override bool Equals(object obj)
	{
		Customer cust = (Customer)obj;
		return (cust.CustomerId == CustomerId);
	}
}

public class Customers : ICustomer
{
	List<Customer> custs;
	public Customers()
	{
		custs = new List<Customer>();
	}
	public int RegisterCustomer(string firstName, string lastName,
		string emailAddress)
	{
		Customer cust = new Customer(firstName, lastName, emailAddress);
		custs.Add(cust);
		return cust.CustomerId;
	}
	public void UnregisterCustomer(int id)
	{
		Customer cust = new Customer(id);
		custs.Remove(cust);
	}

	public void ChangeEmailAddress(int id, string emailAddress)
	{
		int index = FindId(id);
		if (index == -1)
		{
			throw new Exception("id " + id + " not found");
		}
		else
		{
			Customer cust = (Customer) custs[index];
			cust.EmailAddress = emailAddress;
		}
	}

	public Customer[] GetCustomer(int id)
	{
		Customer[] arr = null;
		if (id == -1)
		{
			arr = new Customer[custs.Count];
			int i = 0;
			foreach (Customer cust in custs)
			{
				arr[i] = cust;
				i += 1;
			}
		}
		else
		{
			int index = FindId(id);
			if (index == -1)
			{
				throw new Exception("id " + id + " not found");
			}
			arr = new Customer[1];
			arr[0] = (Customer) custs[index];
		}
		return arr;
	}

	public int FindId(int id)
	{
		Customer cust = new Customer(id);
		return custs.IndexOf(cust);
	}
}
