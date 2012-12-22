namespace BillingSystem.View
{
    partial class FormDeposit
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
            this.btnPutMoney = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblCurBalance = new System.Windows.Forms.Label();
            this.gbPutMoney = new System.Windows.Forms.GroupBox();
            this.mtbSum = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPutMoney.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPutMoney
            // 
            this.btnPutMoney.Location = new System.Drawing.Point(9, 96);
            this.btnPutMoney.Name = "btnPutMoney";
            this.btnPutMoney.Size = new System.Drawing.Size(133, 27);
            this.btnPutMoney.TabIndex = 0;
            this.btnPutMoney.Text = "Внести средства";
            this.btnPutMoney.UseVisualStyleBackColor = true;
            this.btnPutMoney.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(156, 96);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 27);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(111, 26);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(45, 13);
            this.lblBalance.TabIndex = 3;
            this.lblBalance.Text = "balance";
            // 
            // lblCurBalance
            // 
            this.lblCurBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurBalance.AutoSize = true;
            this.lblCurBalance.Location = new System.Drawing.Point(8, 26);
            this.lblCurBalance.Name = "lblCurBalance";
            this.lblCurBalance.Size = new System.Drawing.Size(94, 13);
            this.lblCurBalance.TabIndex = 4;
            this.lblCurBalance.Text = "Текущий баланс:";
            // 
            // gbPutMoney
            // 
            this.gbPutMoney.Controls.Add(this.mtbSum);
            this.gbPutMoney.Controls.Add(this.label1);
            this.gbPutMoney.Controls.Add(this.btnPutMoney);
            this.gbPutMoney.Controls.Add(this.lblBalance);
            this.gbPutMoney.Controls.Add(this.lblCurBalance);
            this.gbPutMoney.Controls.Add(this.btnCancel);
            this.gbPutMoney.Location = new System.Drawing.Point(12, 12);
            this.gbPutMoney.MaximumSize = new System.Drawing.Size(258, 136);
            this.gbPutMoney.MinimumSize = new System.Drawing.Size(258, 136);
            this.gbPutMoney.Name = "gbPutMoney";
            this.gbPutMoney.Size = new System.Drawing.Size(258, 136);
            this.gbPutMoney.TabIndex = 5;
            this.gbPutMoney.TabStop = false;
            this.gbPutMoney.Text = "Внесение средств на счет";
            // 
            // mtbSum
            // 
            this.mtbSum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.mtbSum.Location = new System.Drawing.Point(112, 53);
            this.mtbSum.Mask = "0000";
            this.mtbSum.Name = "mtbSum";
            this.mtbSum.Size = new System.Drawing.Size(137, 20);
            this.mtbSum.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Вносимая сумма:";
            // 
            // FormDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 165);
            this.Controls.Add(this.gbPutMoney);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(299, 203);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(299, 203);
            this.Name = "FormDeposit";
            this.Text = "Пополнение счета абонента";
            this.gbPutMoney.ResumeLayout(false);
            this.gbPutMoney.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPutMoney;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblCurBalance;
        private System.Windows.Forms.GroupBox gbPutMoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbSum;
    }
}