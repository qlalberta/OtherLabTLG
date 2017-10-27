using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Threading;

namespace AsyncGui
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button cmdClear;
		private System.Windows.Forms.Button cmdCall;
		private System.Windows.Forms.Label lblGreeting;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtDelay;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblThreadId;
		private System.Windows.Forms.Button cmdClickMe;
		private System.Windows.Forms.Button cmdAsync;
		internal System.Windows.Forms.Button cmdSafeAsync;
		internal System.ComponentModel.BackgroundWorker BackgroundWorker1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.cmdClear = new System.Windows.Forms.Button();
			this.cmdClickMe = new System.Windows.Forms.Button();
			this.cmdAsync = new System.Windows.Forms.Button();
			this.cmdCall = new System.Windows.Forms.Button();
			this.lblGreeting = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtDelay = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblThreadId = new System.Windows.Forms.Label();
			this.cmdSafeAsync = new System.Windows.Forms.Button();
			this.BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.SuspendLayout();
			// 
			// cmdClear
			// 
			this.cmdClear.Location = new System.Drawing.Point(116, 127);
			this.cmdClear.Name = "cmdClear";
			this.cmdClear.Size = new System.Drawing.Size(82, 23);
			this.cmdClear.TabIndex = 17;
			this.cmdClear.Text = "Clear";
			this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
			// 
			// cmdClickMe
			// 
			this.cmdClickMe.Location = new System.Drawing.Point(20, 127);
			this.cmdClickMe.Name = "cmdClickMe";
			this.cmdClickMe.Size = new System.Drawing.Size(82, 23);
			this.cmdClickMe.TabIndex = 16;
			this.cmdClickMe.Text = "Click Me";
			this.cmdClickMe.Click += new System.EventHandler(this.cmdClickMe_Click);
			// 
			// cmdAsync
			// 
			this.cmdAsync.Location = new System.Drawing.Point(214, 89);
			this.cmdAsync.Name = "cmdAsync";
			this.cmdAsync.Size = new System.Drawing.Size(94, 23);
			this.cmdAsync.TabIndex = 15;
			this.cmdAsync.Text = "Async Call";
			this.cmdAsync.Click += new System.EventHandler(this.cmdAsync_Click);
			// 
			// cmdCall
			// 
			this.cmdCall.Location = new System.Drawing.Point(217, 51);
			this.cmdCall.Name = "cmdCall";
			this.cmdCall.Size = new System.Drawing.Size(91, 23);
			this.cmdCall.TabIndex = 14;
			this.cmdCall.Text = "Call";
			this.cmdCall.Click += new System.EventHandler(this.cmdCall_Click);
			// 
			// lblGreeting
			// 
			this.lblGreeting.Location = new System.Drawing.Point(14, 89);
			this.lblGreeting.Name = "lblGreeting";
			this.lblGreeting.Size = new System.Drawing.Size(184, 23);
			this.lblGreeting.TabIndex = 13;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(105, 51);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(64, 20);
			this.txtName.TabIndex = 12;
			this.txtName.Text = "John";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(17, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 23);
			this.label2.TabIndex = 11;
			this.label2.Text = "Your name:";
			// 
			// txtDelay
			// 
			this.txtDelay.Location = new System.Drawing.Point(80, 16);
			this.txtDelay.Name = "txtDelay";
			this.txtDelay.Size = new System.Drawing.Size(48, 20);
			this.txtDelay.TabIndex = 10;
			this.txtDelay.Text = "5";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 23);
			this.label1.TabIndex = 9;
			this.label1.Text = "Delay";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(152, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 23);
			this.label3.TabIndex = 18;
			this.label3.Text = "Thread Id:";
			// 
			// lblThreadId
			// 
			this.lblThreadId.Location = new System.Drawing.Point(214, 16);
			this.lblThreadId.Name = "lblThreadId";
			this.lblThreadId.Size = new System.Drawing.Size(72, 20);
			this.lblThreadId.TabIndex = 19;
			// 
			// cmdSafeAsync
			// 
			this.cmdSafeAsync.Location = new System.Drawing.Point(214, 127);
			this.cmdSafeAsync.Name = "cmdSafeAsync";
			this.cmdSafeAsync.Size = new System.Drawing.Size(94, 23);
			this.cmdSafeAsync.TabIndex = 20;
			this.cmdSafeAsync.Text = "Call via  BW";
			this.cmdSafeAsync.UseVisualStyleBackColor = true;
			this.cmdSafeAsync.Click += new System.EventHandler(this.cmdSafeAsync_Click);
			// 
			// BackgroundWorker1
			// 
			this.BackgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
			this.BackgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(320, 173);
			this.Controls.Add(this.cmdSafeAsync);
			this.Controls.Add(this.lblThreadId);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cmdClear);
			this.Controls.Add(this.cmdClickMe);
			this.Controls.Add(this.cmdAsync);
			this.Controls.Add(this.cmdCall);
			this.Controls.Add(this.lblGreeting);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtDelay);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Async Demonstration";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		//static void Main() 
		//{
		//    Application.Run(new Form1());
		//}
		[STAThread()]
		private string GetGreeting(string name, int delay, out int threadId)
		{
			Thread.Sleep(delay * 1000);
			Thread t = Thread.CurrentThread;
			threadId = t.ManagedThreadId;
			return "Hello, " + name;
		}

		// The delegate must have the same signature as the method
		// you want to call asynchronously
		private delegate string GreetingDelegate(string name, int delay, out int threadId);
		private delegate void SetTextCallback(string MyText, Control MyControl);

		// Callback method must have same signature as AsyncCallback delegate
		private void CallbackMethod(IAsyncResult ar)
		{
			// Retrieve the delegate from the IAsyncResult
			GreetingDelegate delg = (GreetingDelegate)ar.AsyncState;

			// Call EndInvoke
			int threadId = 0;
			string greeting = delg.EndInvoke(out threadId, ar);
			//lblGreeting.Text = greeting & " : " & "threadId = " & threadId
			greeting = greeting + " : " + "threadId = " + threadId;
			SetText(greeting, lblGreeting);
		}

		//Thread-safe method for calling Windows controls
		private void SetText(string MyText, Control ctl)
		{
			// InvokeRequired compares the thread ID of the
			// calling thread to the thread ID of the creating thread.
			// If these threads are different, it returns true.
			if (ctl.InvokeRequired)
			{
				SetTextCallback d = new SetTextCallback(SetText);
				this.Invoke(d, new object[] {MyText, ctl});
			}
			else
			{
				ctl.Text = MyText;
			}
		}


		private void cmdAsync_Click(object sender, System.EventArgs e)
		{
			// Create the delegate
			GreetingDelegate delg = new GreetingDelegate(GetGreeting);

			// Make the async call
			int threadId = 0;
			int delay = Convert.ToInt32(txtDelay.Text);
			IAsyncResult ar = delg.BeginInvoke(txtName.Text, delay, out threadId, new AsyncCallback(CallbackMethod), delg);
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			Thread t = Thread.CurrentThread;
			int threadId = t.ManagedThreadId;
			lblThreadId.Text = threadId.ToString();
		}

		private void cmdCall_Click(object sender, System.EventArgs e)
		{
			int threadId = 0;
			int delay = Convert.ToInt32(txtDelay.Text);
			string greeting = GetGreeting(txtName.Text, delay, out threadId);
            greeting = greeting + " : " + "threadId = " + threadId;
            SetText(greeting, lblGreeting);
		}

		private void cmdClickMe_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show("Clicked!!", "Async Demonstration");
		}

		private void cmdClear_Click(object sender, System.EventArgs e)
		{
			lblGreeting.Text = "";
		}

		private void cmdSafeAsync_Click(object sender, System.EventArgs e)
		{
			BackgroundWorker1.RunWorkerAsync();

		}

		private void BackgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			int threadId = 0;
			int delay = Convert.ToInt32(txtDelay.Text);
			string answer = GetGreeting(txtName.Text, delay, out threadId);
			answer = answer + " : " + "threadId = " + threadId;
			e.Result = answer;
		}

		private void BackgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
		{
			lblGreeting.Text = e.Result.ToString();
		}

		[STAThread]
		static void Main()
		{
			Application.Run(new Form1());
		}

	}
}
