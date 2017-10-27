using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleBank
{
	public partial class BankForm : Form
	{
		public BankForm()
		{
			InitializeComponent();
		}

		private Account currAccount;

		private void BankForm_Load(object sender, EventArgs e)
		{
			listAccounts.Items.Add(new Account("Amy", 100M));
			listAccounts.Items.Add(new Account("Bob", 200M));
			listAccounts.Items.Add(new Account("Carl", 300M));
			btnClose.Enabled = false;
		}

		private void btnOpen_Click(object sender, EventArgs e)
		{
			try
			{
				string owner = txtOwner.Text;
				decimal balance = Convert.ToDecimal(txtBalance.Text);
				currAccount = new Account(owner, balance);
				listAccounts.Items.Add(currAccount);
				btnClose.Enabled = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Simple Bank");
			}
		}

		private void listAccounts_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listAccounts.SelectedIndex != -1)
			{
				currAccount = (Account)listAccounts.SelectedItem;
				txtOwner.Text = currAccount.ToString();
				txtBalance.Text = currAccount.Balance.ToString();
				btnClose.Enabled = true;
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			listAccounts.Items.Remove(currAccount);
			txtOwner.Text = "";
			txtBalance.Text = "";
			btnClose.Enabled = false;
		}
	}
}