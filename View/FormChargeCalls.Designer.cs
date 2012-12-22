namespace BillingSystem.View
{
    partial class FormChargeCalls
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
            this.dgvCharges = new System.Windows.Forms.DataGridView();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnCharge = new System.Windows.Forms.Button();
            this.dateTimePickerMonth = new System.Windows.Forms.DateTimePicker();
            this.gbCharge = new System.Windows.Forms.GroupBox();
            this.lblDateSelect = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCharges)).BeginInit();
            this.gbCharge.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCharges
            // 
            this.dgvCharges.AllowUserToAddRows = false;
            this.dgvCharges.AllowUserToDeleteRows = false;
            this.dgvCharges.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCharges.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvCharges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCharges.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.phoneNumber,
            this.sum});
            this.dgvCharges.Location = new System.Drawing.Point(16, 50);
            this.dgvCharges.Name = "dgvCharges";
            this.dgvCharges.ReadOnly = true;
            this.dgvCharges.RowHeadersVisible = false;
            this.dgvCharges.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCharges.Size = new System.Drawing.Size(345, 349);
            this.dgvCharges.TabIndex = 0;
            // 
            // phoneNumber
            // 
            this.phoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phoneNumber.HeaderText = "Номер телефона";
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.ReadOnly = true;
            // 
            // sum
            // 
            this.sum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sum.HeaderText = "Сумма";
            this.sum.Name = "sum";
            this.sum.ReadOnly = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(16, 406);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(164, 28);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Расчет";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnCharge
            // 
            this.btnCharge.Location = new System.Drawing.Point(205, 406);
            this.btnCharge.Name = "btnCharge";
            this.btnCharge.Size = new System.Drawing.Size(160, 28);
            this.btnCharge.TabIndex = 2;
            this.btnCharge.Text = "Списать";
            this.btnCharge.UseVisualStyleBackColor = true;
            this.btnCharge.Click += new System.EventHandler(this.btnCharge_Click);
            // 
            // dateTimePickerMonth
            // 
            this.dateTimePickerMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerMonth.Location = new System.Drawing.Point(115, 24);
            this.dateTimePickerMonth.Name = "dateTimePickerMonth";
            this.dateTimePickerMonth.Size = new System.Drawing.Size(246, 20);
            this.dateTimePickerMonth.TabIndex = 3;
            // 
            // gbCharge
            // 
            this.gbCharge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCharge.Controls.Add(this.lblDateSelect);
            this.gbCharge.Controls.Add(this.btnCalculate);
            this.gbCharge.Controls.Add(this.dgvCharges);
            this.gbCharge.Controls.Add(this.btnCharge);
            this.gbCharge.Controls.Add(this.dateTimePickerMonth);
            this.gbCharge.Location = new System.Drawing.Point(12, 12);
            this.gbCharge.Name = "gbCharge";
            this.gbCharge.Size = new System.Drawing.Size(382, 450);
            this.gbCharge.TabIndex = 4;
            this.gbCharge.TabStop = false;
            this.gbCharge.Text = "Списание со счета";
            // 
            // lblDateSelect
            // 
            this.lblDateSelect.AutoSize = true;
            this.lblDateSelect.Location = new System.Drawing.Point(15, 27);
            this.lblDateSelect.Name = "lblDateSelect";
            this.lblDateSelect.Size = new System.Drawing.Size(85, 13);
            this.lblDateSelect.TabIndex = 4;
            this.lblDateSelect.Text = "Выберите дату:";
            // 
            // FormChargeCalls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 474);
            this.Controls.Add(this.gbCharge);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(430, 512);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(430, 512);
            this.Name = "FormChargeCalls";
            this.Text = "Списание средств со счетов";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCharges)).EndInit();
            this.gbCharge.ResumeLayout(false);
            this.gbCharge.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCharges;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn sum;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnCharge;
        private System.Windows.Forms.DateTimePicker dateTimePickerMonth;
        private System.Windows.Forms.GroupBox gbCharge;
        private System.Windows.Forms.Label lblDateSelect;
    }
}