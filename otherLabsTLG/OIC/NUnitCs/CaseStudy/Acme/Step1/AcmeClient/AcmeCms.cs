using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AcmeClient
{
	public partial class AcmeCms : Form
	{
		public AcmeCms()
		{
			InitializeComponent();
		}

		private Customers custs;

		private void ShowCustomerArray(Customer[] array)
		{
			listCustomers.Items.Clear();
			if (array == null)
			{
				throw new Exception("customer list is null");
			}
			foreach (Customer cust in array)
			{
				string id = cust.CustomerId.ToString();
				string first = cust.FirstName;
				string last = cust.LastName;
				string email = cust.EmailAddress;
				string str = id + " " + first + " " + last + " " + email;
				listCustomers.Items.Add(str);
			}
		}

		private void AcmeCms_Load(object sender, EventArgs e)
		{
			custs = new Customers();
			custs.RegisterCustomer("Rocket", "Squirrel", "rocky@frosbitefalls.com");
			custs.RegisterCustomer("Bullwinkle", "Moose", "moose@whatsamatteru.edu");
			ShowCustomerArray(custs.GetCustomer(-1));
		}

		private void cmdRegister_Click(object sender, EventArgs e)
		{
			int id = custs.RegisterCustomer(txtFirstName.Text,
				txtLastName.Text, txtEmailAddress.Text);
			txtId.Text = id.ToString();
			ShowCustomerArray(custs.GetCustomer(-1));
		}

		private void listCustomers_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listCustomers.SelectedIndex != -1)
			{
				string selected = (string)listCustomers.SelectedItem;
				char[] sep = new char[] { ' ' };
				string[] fields;
				fields = selected.Split(sep);
				txtId.Text = fields[0];
				txtFirstName.Text = fields[1];
				txtLastName.Text = fields[2];
				txtEmailAddress.Text = fields[3];
			}
		}

		private void cmdUnregister_Click(object sender, EventArgs e)
		{
			if (txtId.Text != "")
			{
				int id = Convert.ToInt32(txtId.Text);
				custs.UnregisterCustomer(id);
				txtId.Text = "";
				txtFirstName.Text = "";
				txtLastName.Text = "";
				txtEmailAddress.Text = "";
				ShowCustomerArray(custs.GetCustomer(-1));
			}
		}

		private void cmdChangeEmail_Click(object sender, EventArgs e)
		{
			if (txtId.Text != "")
			{
				int id = Convert.ToInt32(txtId.Text);
				custs.ChangeEmailAddress(id, txtEmailAddress.Text);
				ShowCustomerArray(custs.GetCustomer(-1));
			}
		}
	}
}