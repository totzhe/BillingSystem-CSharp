﻿namespace BillingSystem.View
{
    partial class FormMonthlyInfo
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
            this.lblChargesSum = new System.Windows.Forms.Label();
            this.lblPaymentsSum = new System.Windows.Forms.Label();
            this.gbPayments = new System.Windows.Forms.GroupBox();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpMonthlyInfo = new System.Windows.Forms.GroupBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.lblSelectMonth = new System.Windows.Forms.Label();
            this.gbCharges = new System.Windows.Forms.GroupBox();
            this.dgvCharges = new System.Windows.Forms.DataGridView();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDigits = new System.Windows.Forms.GroupBox();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalLiquidate = new System.Windows.Forms.Label();
            this.lblLiquidate = new System.Windows.Forms.Label();
            this.lblTotalCompounded = new System.Windows.Forms.Label();
            this.lblCompounded = new System.Windows.Forms.Label();
            this.gbPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.gpMonthlyInfo.SuspendLayout();
            this.gbCharges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCharges)).BeginInit();
            this.gbDigits.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblChargesSum
            // 
            this.lblChargesSum.AutoSize = true;
            this.lblChargesSum.Location = new System.Drawing.Point(90, 165);
            this.lblChargesSum.Name = "lblChargesSum";
            this.lblChargesSum.Size = new System.Drawing.Size(0, 13);
            this.lblChargesSum.TabIndex = 7;
            // 
            // lblPaymentsSum
            // 
            this.lblPaymentsSum.AutoSize = true;
            this.lblPaymentsSum.Location = new System.Drawing.Point(669, 165);
            this.lblPaymentsSum.Name = "lblPaymentsSum";
            this.lblPaymentsSum.Size = new System.Drawing.Size(0, 13);
            this.lblPaymentsSum.TabIndex = 8;
            // 
            // gbPayments
            // 
            this.gbPayments.Controls.Add(this.dgvPayments);
            this.gbPayments.Location = new System.Drawing.Point(245, 118);
            this.gbPayments.Name = "gbPayments";
            this.gbPayments.Size = new System.Drawing.Size(265, 332);
            this.gbPayments.TabIndex = 10;
            this.gbPayments.TabStop = false;
            this.gbPayments.Text = "Платежи";
            // 
            // dgvPayments
            // 
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AllowUserToDeleteRows = false;
            this.dgvPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvPayments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvPayments.Location = new System.Drawing.Point(9, 19);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.ReadOnly = true;
            this.dgvPayments.RowHeadersVisible = false;
            this.dgvPayments.Size = new System.Drawing.Size(246, 300);
            this.dgvPayments.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.FillWeight = 139.0863F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Абонент";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.FillWeight = 60.91371F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Сумма";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 60;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // gpMonthlyInfo
            // 
            this.gpMonthlyInfo.Controls.Add(this.lblYear);
            this.gpMonthlyInfo.Controls.Add(this.cbYear);
            this.gpMonthlyInfo.Controls.Add(this.cbMonth);
            this.gpMonthlyInfo.Controls.Add(this.lblSelectMonth);
            this.gpMonthlyInfo.Location = new System.Drawing.Point(12, 12);
            this.gpMonthlyInfo.Name = "gpMonthlyInfo";
            this.gpMonthlyInfo.Size = new System.Drawing.Size(214, 104);
            this.gpMonthlyInfo.TabIndex = 11;
            this.gpMonthlyInfo.TabStop = false;
            this.gpMonthlyInfo.Text = "Выбор месяца и года";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(13, 66);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(28, 13);
            this.lblYear.TabIndex = 14;
            this.lblYear.Text = "Год:";
            // 
            // cbYear
            // 
            this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(70, 63);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(131, 21);
            this.cbYear.TabIndex = 13;
            this.cbYear.SelectedIndexChanged += new System.EventHandler(this.SelectedMonthChanged);
            // 
            // cbMonth
            // 
            this.cbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Location = new System.Drawing.Point(70, 27);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(131, 21);
            this.cbMonth.TabIndex = 12;
            this.cbMonth.SelectedIndexChanged += new System.EventHandler(this.SelectedMonthChanged);
            // 
            // lblSelectMonth
            // 
            this.lblSelectMonth.AutoSize = true;
            this.lblSelectMonth.Location = new System.Drawing.Point(13, 30);
            this.lblSelectMonth.Name = "lblSelectMonth";
            this.lblSelectMonth.Size = new System.Drawing.Size(43, 13);
            this.lblSelectMonth.TabIndex = 0;
            this.lblSelectMonth.Text = "Месяц:";
            // 
            // gbCharges
            // 
            this.gbCharges.Controls.Add(this.dgvCharges);
            this.gbCharges.Location = new System.Drawing.Point(12, 118);
            this.gbCharges.Name = "gbCharges";
            this.gbCharges.Size = new System.Drawing.Size(214, 332);
            this.gbCharges.TabIndex = 9;
            this.gbCharges.TabStop = false;
            this.gbCharges.Text = "Списания";
            // 
            // dgvCharges
            // 
            this.dgvCharges.AllowUserToAddRows = false;
            this.dgvCharges.AllowUserToDeleteRows = false;
            this.dgvCharges.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvCharges.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.phoneNumber,
            this.sum});
            this.dgvCharges.Location = new System.Drawing.Point(10, 19);
            this.dgvCharges.Name = "dgvCharges";
            this.dgvCharges.ReadOnly = true;
            this.dgvCharges.RowHeadersVisible = false;
            this.dgvCharges.Size = new System.Drawing.Size(191, 300);
            this.dgvCharges.TabIndex = 4;
            // 
            // phoneNumber
            // 
            this.phoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phoneNumber.FillWeight = 121.8274F;
            this.phoneNumber.HeaderText = "Номер телефона";
            this.phoneNumber.MinimumWidth = 100;
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.ReadOnly = true;
            // 
            // sum
            // 
            this.sum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sum.FillWeight = 78.1726F;
            this.sum.HeaderText = "Сумма";
            this.sum.MinimumWidth = 60;
            this.sum.Name = "sum";
            this.sum.ReadOnly = true;
            // 
            // gbDigits
            // 
            this.gbDigits.Controls.Add(this.lblTotalCost);
            this.gbDigits.Controls.Add(this.lblTotal);
            this.gbDigits.Controls.Add(this.lblTotalLiquidate);
            this.gbDigits.Controls.Add(this.lblLiquidate);
            this.gbDigits.Controls.Add(this.lblTotalCompounded);
            this.gbDigits.Controls.Add(this.lblCompounded);
            this.gbDigits.Location = new System.Drawing.Point(245, 12);
            this.gbDigits.Name = "gbDigits";
            this.gbDigits.Size = new System.Drawing.Size(265, 104);
            this.gbDigits.TabIndex = 12;
            this.gbDigits.TabStop = false;
            this.gbDigits.Text = "Средства";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalCost.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTotalCost.Location = new System.Drawing.Point(162, 80);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(29, 13);
            this.lblTotalCost.TabIndex = 7;
            this.lblTotalCost.Text = "sum";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotal.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTotal.Location = new System.Drawing.Point(16, 80);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(102, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Всего к оплате:";
            // 
            // lblTotalLiquidate
            // 
            this.lblTotalLiquidate.AutoSize = true;
            this.lblTotalLiquidate.Location = new System.Drawing.Point(165, 53);
            this.lblTotalLiquidate.Name = "lblTotalLiquidate";
            this.lblTotalLiquidate.Size = new System.Drawing.Size(26, 13);
            this.lblTotalLiquidate.TabIndex = 5;
            this.lblTotalLiquidate.Text = "sum";
            // 
            // lblLiquidate
            // 
            this.lblLiquidate.AutoSize = true;
            this.lblLiquidate.Location = new System.Drawing.Point(16, 53);
            this.lblLiquidate.Name = "lblLiquidate";
            this.lblLiquidate.Size = new System.Drawing.Size(137, 13);
            this.lblLiquidate.TabIndex = 4;
            this.lblLiquidate.Text = "Оплачено в этом месяце:";
            // 
            // lblTotalCompounded
            // 
            this.lblTotalCompounded.AutoSize = true;
            this.lblTotalCompounded.Location = new System.Drawing.Point(165, 27);
            this.lblTotalCompounded.Name = "lblTotalCompounded";
            this.lblTotalCompounded.Size = new System.Drawing.Size(26, 13);
            this.lblTotalCompounded.TabIndex = 3;
            this.lblTotalCompounded.Text = "sum";
            // 
            // lblCompounded
            // 
            this.lblCompounded.AutoSize = true;
            this.lblCompounded.Location = new System.Drawing.Point(16, 27);
            this.lblCompounded.Name = "lblCompounded";
            this.lblCompounded.Size = new System.Drawing.Size(115, 13);
            this.lblCompounded.TabIndex = 2;
            this.lblCompounded.Text = "Начислено за месяц:";
            // 
            // FormMonthlyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 462);
            this.Controls.Add(this.gbDigits);
            this.Controls.Add(this.gpMonthlyInfo);
            this.Controls.Add(this.gbCharges);
            this.Controls.Add(this.gbPayments);
            this.Controls.Add(this.lblPaymentsSum);
            this.Controls.Add(this.lblChargesSum);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(550, 500);
            this.Name = "FormMonthlyInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Просмотр статистики за месяц";
            this.gbPayments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.gpMonthlyInfo.ResumeLayout(false);
            this.gpMonthlyInfo.PerformLayout();
            this.gbCharges.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCharges)).EndInit();
            this.gbDigits.ResumeLayout(false);
            this.gbDigits.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChargesSum;
        private System.Windows.Forms.Label lblPaymentsSum;
        private System.Windows.Forms.GroupBox gbPayments;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.GroupBox gpMonthlyInfo;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.Label lblSelectMonth;
        private System.Windows.Forms.GroupBox gbCharges;
        private System.Windows.Forms.DataGridView dgvCharges;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn sum;
        private System.Windows.Forms.GroupBox gbDigits;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalLiquidate;
        private System.Windows.Forms.Label lblLiquidate;
        private System.Windows.Forms.Label lblTotalCompounded;
        private System.Windows.Forms.Label lblCompounded;
    }
}