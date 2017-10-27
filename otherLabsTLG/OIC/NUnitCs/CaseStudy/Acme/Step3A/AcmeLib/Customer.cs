// Customer.cs

using System;
using System.Collections;

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
}

public class Customers : ICustomer
{
	ArrayList custs;
	public Customers()
	{
		custs = new ArrayList();
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
		/*
		int index = FindId(id);
		if (index == -1)
		{
			throw new Exception("id " + id + " not found");
		}
		// move up array elements to fill deleted item
		for (int i = index; i < nextc - 1; i++)
		{
			customers[i] = customers[i + 1];
		}
		nextc--;
		 * */
	}

	public void ChangeEmailAddress(int id, string emailAddress)
	{
		/*
		int index = FindId(id);
		if (index == -1)
		{
			throw new Exception("id " + id + " not found");
		}
		else
		{
			Customer cust = customers[index];
			cust.EmailAddress = emailAddress;
		}
		return;
		 * */
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
			/*
		else
		{
			int index = FindId(id);
			if (index == -1)
			{
				throw new Exception("id " + id + " not found");
			}
			custs = new Customer[1];
			custs[0] = customers[index];
		}
		return custs;
		 * */
		return arr;
	}

	public int FindId(int id)
	{
		/*
		for (int i = 0; i < nextc; i++)
		{
			if (customers[i].CustomerId == id)
			{
				return i;
			}
		}
		 * */
		return -1;
	}
}
