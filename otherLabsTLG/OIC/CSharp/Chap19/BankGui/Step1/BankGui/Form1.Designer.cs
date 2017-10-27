namespace BankGui
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
            this.cmdWithdraw = new System.Windows.Forms.Button();
            this.cmdDeposit = new System.Windows.Forms.Button();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdWithdraw
            // 
            this.cmdWithdraw.Location = new System.Drawing.Point(126, 114);
            this.cmdWithdraw.Name = "cmdWithdraw";
            this.cmdWithdraw.Size = new System.Drawing.Size(75, 23);
            this.cmdWithdraw.TabIndex = 21;
            this.cmdWithdraw.Text = "Withdraw";
            this.cmdWithdraw.Click += new System.EventHandler(this.cmdWithdraw_Click);
            // 
            // cmdDeposit
            // 
            this.cmdDeposit.Location = new System.Drawing.Point(22, 114);
            this.cmdDeposit.Name = "cmdDeposit";
            this.cmdDeposit.Size = new System.Drawing.Size(75, 23);
            this.cmdDeposit.TabIndex = 20;
            this.cmdDeposit.Text = "Deposit";
            this.cmdDeposit.Click += new System.EventHandler(this.cmdDeposit_Click);
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(102, 66);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(64, 20);
            this.txtBalance.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(22, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Balance";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(102, 18);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(64, 20);
            this.txtAmount.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Amount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 161);
            this.Controls.Add(this.cmdWithdraw);
            this.Controls.Add(this.cmdDeposit);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bank Account";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdWithdraw;
        private System.Windows.Forms.Button cmdDeposit;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label1;
    }
}

