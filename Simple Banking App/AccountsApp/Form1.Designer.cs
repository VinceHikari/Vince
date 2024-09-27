namespace AccountsApp
{
    partial class BankingApp
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
            this.checkingRadio = new System.Windows.Forms.RadioButton();
            this.savingsRadio = new System.Windows.Forms.RadioButton();
            this.accountGroup = new System.Windows.Forms.GroupBox();
            this.accountField = new System.Windows.Forms.TextBox();
            this.withdrawField = new System.Windows.Forms.TextBox();
            this.balanceField = new System.Windows.Forms.TextBox();
            this.clientField = new System.Windows.Forms.TextBox();
            this.interestField = new System.Windows.Forms.TextBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblInterest = new System.Windows.Forms.Label();
            this.lblDaily = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.groupAccount = new System.Windows.Forms.GroupBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkingRadio
            // 
            this.checkingRadio.AutoSize = true;
            this.checkingRadio.Location = new System.Drawing.Point(558, 140);
            this.checkingRadio.Name = "checkingRadio";
            this.checkingRadio.Size = new System.Drawing.Size(84, 20);
            this.checkingRadio.TabIndex = 0;
            this.checkingRadio.TabStop = true;
            this.checkingRadio.Text = "Checking";
            this.checkingRadio.UseVisualStyleBackColor = true;
            this.checkingRadio.CheckedChanged += new System.EventHandler(this.checkingRadio_CheckedChanged);
            // 
            // savingsRadio
            // 
            this.savingsRadio.AutoSize = true;
            this.savingsRadio.Location = new System.Drawing.Point(558, 175);
            this.savingsRadio.Name = "savingsRadio";
            this.savingsRadio.Size = new System.Drawing.Size(77, 20);
            this.savingsRadio.TabIndex = 1;
            this.savingsRadio.TabStop = true;
            this.savingsRadio.Text = "Savings";
            this.savingsRadio.UseVisualStyleBackColor = true;
            this.savingsRadio.CheckedChanged += new System.EventHandler(this.savingsRadio_CheckedChanged);
            // 
            // accountGroup
            // 
            this.accountGroup.Location = new System.Drawing.Point(506, 106);
            this.accountGroup.Name = "accountGroup";
            this.accountGroup.Size = new System.Drawing.Size(250, 106);
            this.accountGroup.TabIndex = 2;
            this.accountGroup.TabStop = false;
            this.accountGroup.Text = "Type of Account";
            // 
            // accountField
            // 
            this.accountField.Location = new System.Drawing.Point(205, 106);
            this.accountField.Name = "accountField";
            this.accountField.Size = new System.Drawing.Size(134, 22);
            this.accountField.TabIndex = 3;
            this.accountField.Tag = "";
            // 
            // withdrawField
            // 
            this.withdrawField.Location = new System.Drawing.Point(205, 258);
            this.withdrawField.Name = "withdrawField";
            this.withdrawField.Size = new System.Drawing.Size(134, 22);
            this.withdrawField.TabIndex = 4;
            this.withdrawField.Tag = "";
            this.withdrawField.Text = "10";
            // 
            // balanceField
            // 
            this.balanceField.Location = new System.Drawing.Point(205, 211);
            this.balanceField.Name = "balanceField";
            this.balanceField.Size = new System.Drawing.Size(134, 22);
            this.balanceField.TabIndex = 5;
            this.balanceField.Tag = "";
            // 
            // clientField
            // 
            this.clientField.Location = new System.Drawing.Point(205, 157);
            this.clientField.Name = "clientField";
            this.clientField.Size = new System.Drawing.Size(243, 22);
            this.clientField.TabIndex = 6;
            this.clientField.Tag = "";
            // 
            // interestField
            // 
            this.interestField.Location = new System.Drawing.Point(205, 320);
            this.interestField.Name = "interestField";
            this.interestField.Size = new System.Drawing.Size(134, 22);
            this.interestField.TabIndex = 7;
            this.interestField.Tag = "";
            this.interestField.Text = "2.4";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(54, 106);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(109, 16);
            this.lblAccount.TabIndex = 8;
            this.lblAccount.Text = "Account Number:";
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Location = new System.Drawing.Point(78, 320);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(85, 16);
            this.lblInterest.TabIndex = 9;
            this.lblInterest.Text = "Interest Rate:";
            // 
            // lblDaily
            // 
            this.lblDaily.AutoSize = true;
            this.lblDaily.Location = new System.Drawing.Point(34, 264);
            this.lblDaily.Name = "lblDaily";
            this.lblDaily.Size = new System.Drawing.Size(129, 16);
            this.lblDaily.TabIndex = 10;
            this.lblDaily.Text = "Daily Withdraw Limit:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(103, 211);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(60, 16);
            this.lblBalance.TabIndex = 11;
            this.lblBalance.Text = "Balance:";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(80, 160);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(83, 16);
            this.lblClient.TabIndex = 12;
            this.lblClient.Text = "Client Name:";
            // 
            // groupAccount
            // 
            this.groupAccount.Location = new System.Drawing.Point(12, 12);
            this.groupAccount.Name = "groupAccount";
            this.groupAccount.Size = new System.Drawing.Size(776, 355);
            this.groupAccount.TabIndex = 13;
            this.groupAccount.TabStop = false;
            this.groupAccount.Text = "Account Details";
            // 
            // buttonCreate
            // 
            this.buttonCreate.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCreate.Location = new System.Drawing.Point(595, 389);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(193, 59);
            this.buttonCreate.TabIndex = 14;
            this.buttonCreate.Text = "Create Account";
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // BankingApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 462);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblDaily);
            this.Controls.Add(this.lblInterest);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.interestField);
            this.Controls.Add(this.clientField);
            this.Controls.Add(this.balanceField);
            this.Controls.Add(this.withdrawField);
            this.Controls.Add(this.accountField);
            this.Controls.Add(this.savingsRadio);
            this.Controls.Add(this.checkingRadio);
            this.Controls.Add(this.accountGroup);
            this.Controls.Add(this.groupAccount);
            this.Name = "BankingApp";
            this.Text = "Bank of Mom and Dad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton checkingRadio;
        private System.Windows.Forms.RadioButton savingsRadio;
        private System.Windows.Forms.GroupBox accountGroup;
        private System.Windows.Forms.TextBox accountField;
        private System.Windows.Forms.TextBox withdrawField;
        private System.Windows.Forms.TextBox balanceField;
        private System.Windows.Forms.TextBox clientField;
        private System.Windows.Forms.TextBox interestField;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.Label lblDaily;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.GroupBox groupAccount;
        private System.Windows.Forms.Button buttonCreate;
    }
}

