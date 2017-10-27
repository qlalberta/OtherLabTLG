namespace AcmeClient
{
	partial class AcmeCms
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
			this.cmdChangeEmail = new System.Windows.Forms.Button();
			this.cmdUnregister = new System.Windows.Forms.Button();
			this.cmdRegister = new System.Windows.Forms.Button();
			this.listCustomers = new System.Windows.Forms.ListBox();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtEmailAddress = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cmdChangeEmail
			// 
			this.cmdChangeEmail.Location = new System.Drawing.Point(307, 179);
			this.cmdChangeEmail.Name = "cmdChangeEmail";
			this.cmdChangeEmail.Size = new System.Drawing.Size(88, 23);
			this.cmdChangeEmail.TabIndex = 23;
			this.cmdChangeEmail.Text = "Change Email";
			this.cmdChangeEmail.Click += new System.EventHandler(this.cmdChangeEmail_Click);
			// 
			// cmdUnregister
			// 
			this.cmdUnregister.Location = new System.Drawing.Point(307, 139);
			this.cmdUnregister.Name = "cmdUnregister";
			this.cmdUnregister.Size = new System.Drawing.Size(88, 23);
			this.cmdUnregister.TabIndex = 22;
			this.cmdUnregister.Text = "Unregister";
			this.cmdUnregister.Click += new System.EventHandler(this.cmdUnregister_Click);
			// 
			// cmdRegister
			// 
			this.cmdRegister.Location = new System.Drawing.Point(307, 99);
			this.cmdRegister.Name = "cmdRegister";
			this.cmdRegister.Size = new System.Drawing.Size(88, 23);
			this.cmdRegister.TabIndex = 21;
			this.cmdRegister.Text = "Register";
			this.cmdRegister.Click += new System.EventHandler(this.cmdRegister_Click);
			// 
			// listCustomers
			// 
			this.listCustomers.Location = new System.Drawing.Point(27, 99);
			this.listCustomers.Name = "listCustomers";
			this.listCustomers.Size = new System.Drawing.Size(256, 108);
			this.listCustomers.TabIndex = 20;
			this.listCustomers.SelectedIndexChanged += new System.EventHandler(this.listCustomers_SelectedIndexChanged);
			// 
			// txtLastName
			// 
			this.txtLastName.Location = new System.Drawing.Point(299, 59);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(100, 20);
			this.txtLastName.TabIndex = 19;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(219, 59);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 23);
			this.label4.TabIndex = 18;
			this.label4.Text = "Last Name";
			// 
			// txtFirstName
			// 
			this.txtFirstName.Location = new System.Drawing.Point(99, 59);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(100, 20);
			this.txtFirstName.TabIndex = 17;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(19, 59);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 23);
			this.label3.TabIndex = 16;
			this.label3.Text = "First Name";
			// 
			// txtEmailAddress
			// 
			this.txtEmailAddress.Location = new System.Drawing.Point(215, 19);
			this.txtEmailAddress.Name = "txtEmailAddress";
			this.txtEmailAddress.Size = new System.Drawing.Size(184, 20);
			this.txtEmailAddress.TabIndex = 15;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(123, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 23);
			this.label2.TabIndex = 14;
			this.label2.Text = "Email Address";
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(59, 19);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(40, 20);
			this.txtId.TabIndex = 13;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(19, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 23);
			this.label1.TabIndex = 12;
			this.label1.Text = "Id";
			// 
			// AcmeCms
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(426, 232);
			this.Controls.Add(this.cmdChangeEmail);
			this.Controls.Add(this.cmdUnregister);
			this.Controls.Add(this.cmdRegister);
			this.Controls.Add(this.listCustomers);
			this.Controls.Add(this.txtLastName);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtFirstName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtEmailAddress);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.label1);
			this.Name = "AcmeCms";
			this.Text = "Acme Customer Management System";
			this.Load += new System.EventHandler(this.AcmeCms_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button cmdChangeEmail;
		private System.Windows.Forms.Button cmdUnregister;
		private System.Windows.Forms.Button cmdRegister;
		private System.Windows.Forms.ListBox listCustomers;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtEmailAddress;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Label label1;
	}
}

