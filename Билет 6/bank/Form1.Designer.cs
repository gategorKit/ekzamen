namespace bank
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
            this.bankDGV = new System.Windows.Forms.DataGridView();
            this.getFromAccountButton = new System.Windows.Forms.Button();
            this.addToAccountButton = new System.Windows.Forms.Button();
            this.transferMoneyButton = new System.Windows.Forms.Button();
            this.clearAccountButton = new System.Windows.Forms.Button();
            this.addToAccountTB = new System.Windows.Forms.TextBox();
            this.getFromAccountTB = new System.Windows.Forms.TextBox();
            this.moneyTransferTB = new System.Windows.Forms.TextBox();
            this.accountIDTB = new System.Windows.Forms.TextBox();
            this.AmountOfAccsInBankLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bankDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // bankDGV
            // 
            this.bankDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bankDGV.Location = new System.Drawing.Point(12, 54);
            this.bankDGV.Name = "bankDGV";
            this.bankDGV.Size = new System.Drawing.Size(776, 290);
            this.bankDGV.TabIndex = 0;
            // 
            // getFromAccountButton
            // 
            this.getFromAccountButton.Location = new System.Drawing.Point(22, 378);
            this.getFromAccountButton.Name = "getFromAccountButton";
            this.getFromAccountButton.Size = new System.Drawing.Size(120, 23);
            this.getFromAccountButton.TabIndex = 1;
            this.getFromAccountButton.Text = "Снять со счёта";
            this.getFromAccountButton.UseVisualStyleBackColor = true;
            this.getFromAccountButton.Click += new System.EventHandler(this.ButtonEvents_Click);
            // 
            // addToAccountButton
            // 
            this.addToAccountButton.Location = new System.Drawing.Point(22, 350);
            this.addToAccountButton.Name = "addToAccountButton";
            this.addToAccountButton.Size = new System.Drawing.Size(120, 23);
            this.addToAccountButton.TabIndex = 2;
            this.addToAccountButton.Text = "Положить на счёт";
            this.addToAccountButton.UseVisualStyleBackColor = true;
            this.addToAccountButton.Click += new System.EventHandler(this.ButtonEvents_Click);
            // 
            // transferMoneyButton
            // 
            this.transferMoneyButton.Location = new System.Drawing.Point(22, 436);
            this.transferMoneyButton.Name = "transferMoneyButton";
            this.transferMoneyButton.Size = new System.Drawing.Size(120, 23);
            this.transferMoneyButton.TabIndex = 3;
            this.transferMoneyButton.Text = "Перевод со счёта";
            this.transferMoneyButton.UseVisualStyleBackColor = true;
            this.transferMoneyButton.Click += new System.EventHandler(this.ButtonEvents_Click);
            // 
            // clearAccountButton
            // 
            this.clearAccountButton.Location = new System.Drawing.Point(22, 407);
            this.clearAccountButton.Name = "clearAccountButton";
            this.clearAccountButton.Size = new System.Drawing.Size(120, 23);
            this.clearAccountButton.TabIndex = 4;
            this.clearAccountButton.Text = "Обнуление счёта";
            this.clearAccountButton.UseVisualStyleBackColor = true;
            this.clearAccountButton.Click += new System.EventHandler(this.clearAccountButton_Click);
            // 
            // addToAccountTB
            // 
            this.addToAccountTB.Location = new System.Drawing.Point(148, 352);
            this.addToAccountTB.Name = "addToAccountTB";
            this.addToAccountTB.Size = new System.Drawing.Size(116, 20);
            this.addToAccountTB.TabIndex = 5;
            // 
            // getFromAccountTB
            // 
            this.getFromAccountTB.Location = new System.Drawing.Point(148, 380);
            this.getFromAccountTB.Name = "getFromAccountTB";
            this.getFromAccountTB.Size = new System.Drawing.Size(116, 20);
            this.getFromAccountTB.TabIndex = 6;
            // 
            // moneyTransferTB
            // 
            this.moneyTransferTB.Location = new System.Drawing.Point(148, 439);
            this.moneyTransferTB.Name = "moneyTransferTB";
            this.moneyTransferTB.Size = new System.Drawing.Size(116, 20);
            this.moneyTransferTB.TabIndex = 8;
            // 
            // accountIDTB
            // 
            this.accountIDTB.Location = new System.Drawing.Point(148, 461);
            this.accountIDTB.Name = "accountIDTB";
            this.accountIDTB.Size = new System.Drawing.Size(116, 20);
            this.accountIDTB.TabIndex = 9;
            // 
            // AmountOfAccsInBankLabel
            // 
            this.AmountOfAccsInBankLabel.AutoSize = true;
            this.AmountOfAccsInBankLabel.Location = new System.Drawing.Point(12, 38);
            this.AmountOfAccsInBankLabel.Name = "AmountOfAccsInBankLabel";
            this.AmountOfAccsInBankLabel.Size = new System.Drawing.Size(122, 13);
            this.AmountOfAccsInBankLabel.TabIndex = 10;
            this.AmountOfAccsInBankLabel.Text = "Всего счетов в банке: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Номер счёта перевода";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AmountOfAccsInBankLabel);
            this.Controls.Add(this.accountIDTB);
            this.Controls.Add(this.moneyTransferTB);
            this.Controls.Add(this.getFromAccountTB);
            this.Controls.Add(this.addToAccountTB);
            this.Controls.Add(this.clearAccountButton);
            this.Controls.Add(this.transferMoneyButton);
            this.Controls.Add(this.addToAccountButton);
            this.Controls.Add(this.getFromAccountButton);
            this.Controls.Add(this.bankDGV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bankDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button getFromAccountButton;
        private System.Windows.Forms.Button addToAccountButton;
        private System.Windows.Forms.Button transferMoneyButton;
        private System.Windows.Forms.Button clearAccountButton;
        private System.Windows.Forms.TextBox addToAccountTB;
        private System.Windows.Forms.TextBox getFromAccountTB;
        private System.Windows.Forms.TextBox moneyTransferTB;
        private System.Windows.Forms.TextBox accountIDTB;
        private System.Windows.Forms.Label AmountOfAccsInBankLabel;
        public System.Windows.Forms.DataGridView bankDGV;
        private System.Windows.Forms.Label label1;
    }
}

