namespace SimpleBank
{
	partial class BankForm
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
			this.listAccounts = new System.Windows.Forms.ListBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtBalance = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtOwner = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtAmount = new System.Windows.Forms.TextBox();
			this.btnDeposit = new System.Windows.Forms.Button();
			this.btnWithdraw = new System.Windows.Forms.Button();
			this.btnOpen = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// listAccounts
			// 
			this.listAccounts.FormattingEnabled = true;
			this.listAccounts.Location = new System.Drawing.Point(21, 24);
			this.listAccounts.Name = "listAccounts";
			this.listAccounts.Size = new System.Drawing.Size(120, 95);
			this.listAccounts.TabIndex = 0;
			this.listAccounts.SelectedIndexChanged += new System.EventHandler(this.listAccounts_SelectedIndexChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtBalance);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtOwner);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(157, 24);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(171, 95);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Account Information";
			// 
			// txtBalance
			// 
			this.txtBalance.Location = new System.Drawing.Point(74, 55);
			this.txtBalance.Name = "txtBalance";
			this.txtBalance.Size = new System.Drawing.Size(81, 20);
			this.txtBalance.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Balance";
			// 
			// txtOwner
			// 
			this.txtOwner.Location = new System.Drawing.Point(74, 29);
			this.txtOwner.Name = "txtOwner";
			this.txtOwner.Size = new System.Drawing.Size(81, 20);
			this.txtOwner.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Owner";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(21, 138);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(101, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Transaction amount";
			// 
			// txtAmount
			// 
			this.txtAmount.Location = new System.Drawing.Point(157, 138);
			this.txtAmount.Name = "txtAmount";
			this.txtAmount.Size = new System.Drawing.Size(100, 20);
			this.txtAmount.TabIndex = 3;
			// 
			// btnDeposit
			// 
			this.btnDeposit.Location = new System.Drawing.Point(201, 177);
			this.btnDeposit.Name = "btnDeposit";
			this.btnDeposit.Size = new System.Drawing.Size(68, 23);
			this.btnDeposit.TabIndex = 4;
			this.btnDeposit.Text = "Deposit";
			this.btnDeposit.UseVisualStyleBackColor = true;
			// 
			// btnWithdraw
			// 
			this.btnWithdraw.Location = new System.Drawing.Point(287, 177);
			this.btnWithdraw.Name = "btnWithdraw";
			this.btnWithdraw.Size = new System.Drawing.Size(68, 23);
			this.btnWithdraw.TabIndex = 5;
			this.btnWithdraw.Text = "Withdraw";
			this.btnWithdraw.UseVisualStyleBackColor = true;
			// 
			// btnOpen
			// 
			this.btnOpen.Location = new System.Drawing.Point(24, 177);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(68, 23);
			this.btnOpen.TabIndex = 6;
			this.btnOpen.Text = "Open";
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(112, 177);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(68, 23);
			this.btnClose.TabIndex = 7;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// BankForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(381, 223);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnOpen);
			this.Controls.Add(this.btnWithdraw);
			this.Controls.Add(this.btnDeposit);
			this.Controls.Add(this.txtAmount);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.listAccounts);
			this.Name = "BankForm";
			this.Text = "Simple Bank";
			this.Load += new System.EventHandler(this.BankForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listAccounts;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtBalance;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtOwner;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtAmount;
		private System.Windows.Forms.Button btnDeposit;
		private System.Windows.Forms.Button btnWithdraw;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.Button btnClose;
	}
}

