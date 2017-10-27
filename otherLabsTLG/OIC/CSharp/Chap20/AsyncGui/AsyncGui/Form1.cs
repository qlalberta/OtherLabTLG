using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncGui
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Thread t = Thread.CurrentThread;
			int threadId = t.ManagedThreadId;
			lblThreadId.Text = threadId.ToString();
		}

		private void cmdCall_Click(object sender, EventArgs e)
		{
			int threadId;
			int delay = Convert.ToInt32(txtDelay.Text);
			string greeting = GetGreeting(txtName.Text,
				delay,
				out threadId);
			greeting = greeting + " : " + "threadId = " + threadId;
			lblGreeting.Text = greeting;
		}

		private string GetGreeting(string name, int delay, out int threadId)
		{
			Thread.Sleep(delay * 1000);
			Thread t = Thread.CurrentThread;
			threadId = t.ManagedThreadId;
			return "Hello, " + name;
		}

		private void cmdClickMe_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Clicked!!", "Async Demonstration");
		}

		private void cmdClear_Click(object sender, EventArgs e)
		{
			lblGreeting.Text = "";
		}

		private async Task<string> GetGreetingAsync(string name, int delay)
		{
			Thread t = Thread.CurrentThread;
			int threadId = t.ManagedThreadId;
			await Task.Delay(delay * 1000);
			return "Hello, " + name + " : " + "threadId = " + threadId;
		}

		private async void cmdAsync_Click(object sender, EventArgs e)
		{
			int delay = Convert.ToInt32(txtDelay.Text);
			lblGreeting.Text = await GetGreetingAsync(txtName.Text, delay);
		}
	}
}
