using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdDeposit_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(txtAmount.Text);
            int balance = Convert.ToInt32(txtBalance.Text);
            balance += amount;
            txtBalance.Text = Convert.ToString(balance);
        }

        private void cmdWithdraw_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(txtAmount.Text);
            int balance = Convert.ToInt32(txtBalance.Text);
            balance -= amount;
            txtBalance.Text = Convert.ToString(balance);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtAmount.Text = "25";
            txtBalance.Text = "100";
        }
    }
}
