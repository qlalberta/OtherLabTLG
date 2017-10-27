namespace AsyncGui
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
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
			this.lblThreadId = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cmdClear = new System.Windows.Forms.Button();
			this.cmdClickMe = new System.Windows.Forms.Button();
			this.cmdAsync = new System.Windows.Forms.Button();
			this.cmdCall = new System.Windows.Forms.Button();
			this.lblGreeting = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtDelay = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblThreadId
			// 
			this.lblThreadId.Location = new System.Drawing.Point(212, 16);
			this.lblThreadId.Name = "lblThreadId";
			this.lblThreadId.Size = new System.Drawing.Size(72, 23);
			this.lblThreadId.TabIndex = 30;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(148, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 23);
			this.label3.TabIndex = 29;
			this.label3.Text = "Thread Id:";
			// 
			// cmdClear
			// 
			this.cmdClear.Location = new System.Drawing.Point(111, 144);
			this.cmdClear.Name = "cmdClear";
			this.cmdClear.Size = new System.Drawing.Size(75, 23);
			this.cmdClear.TabIndex = 28;
			this.cmdClear.Text = "Clear";
			this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
			// 
			// cmdClickMe
			// 
			this.cmdClickMe.Location = new System.Drawing.Point(15, 144);
			this.cmdClickMe.Name = "cmdClickMe";
			this.cmdClickMe.Size = new System.Drawing.Size(75, 23);
			this.cmdClickMe.TabIndex = 27;
			this.cmdClickMe.Text = "Click Me";
			this.cmdClickMe.Click += new System.EventHandler(this.cmdClickMe_Click);
			// 
			// cmdAsync
			// 
			this.cmdAsync.Location = new System.Drawing.Point(209, 96);
			this.cmdAsync.Name = "cmdAsync";
			this.cmdAsync.Size = new System.Drawing.Size(75, 23);
			this.cmdAsync.TabIndex = 26;
			this.cmdAsync.Text = "Async Call";
			this.cmdAsync.Click += new System.EventHandler(this.cmdAsync_Click);
			// 
			// cmdCall
			// 
			this.cmdCall.Location = new System.Drawing.Point(209, 56);
			this.cmdCall.Name = "cmdCall";
			this.cmdCall.Size = new System.Drawing.Size(75, 23);
			this.cmdCall.TabIndex = 25;
			this.cmdCall.Text = "Call";
			this.cmdCall.Click += new System.EventHandler(this.cmdCall_Click);
			// 
			// lblGreeting
			// 
			this.lblGreeting.Location = new System.Drawing.Point(12, 96);
			this.lblGreeting.Name = "lblGreeting";
			this.lblGreeting.Size = new System.Drawing.Size(184, 23);
			this.lblGreeting.TabIndex = 24;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(100, 56);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(64, 20);
			this.txtName.TabIndex = 23;
			this.txtName.Text = "John";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 23);
			this.label2.TabIndex = 22;
			this.label2.Text = "Your name:";
			// 
			// txtDelay
			// 
			this.txtDelay.Location = new System.Drawing.Point(76, 16);
			this.txtDelay.Name = "txtDelay";
			this.txtDelay.Size = new System.Drawing.Size(48, 20);
			this.txtDelay.TabIndex = 21;
			this.txtDelay.Text = "5";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 23);
			this.label1.TabIndex = 20;
			this.label1.Text = "Delay";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(305, 181);
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

		private System.Windows.Forms.Label lblThreadId;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button cmdClear;
		private System.Windows.Forms.Button cmdClickMe;
		private System.Windows.Forms.Button cmdAsync;
		private System.Windows.Forms.Button cmdCall;
		private System.Windows.Forms.Label lblGreeting;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtDelay;
		private System.Windows.Forms.Label label1;
	}
}

