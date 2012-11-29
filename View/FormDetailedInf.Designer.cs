namespace BillingSystem.View
{
    partial class FormDetailedInf
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
            this.dgvInf = new System.Windows.Forms.DataGridView();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.rbCalls = new System.Windows.Forms.RadioButton();
            this.rbServices = new System.Windows.Forms.RadioButton();
            this.rbPayments = new System.Windows.Forms.RadioButton();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.lbNumbers = new System.Windows.Forms.ListBox();
            this.rbTariffs = new System.Windows.Forms.RadioButton();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.gbDetailType = new System.Windows.Forms.GroupBox();
            this.gbPeriod = new System.Windows.Forms.GroupBox();
            this.lbTo = new System.Windows.Forms.Label();
            this.lbFrom = new System.Windows.Forms.Label();
            this.gbSelectNumber = new System.Windows.Forms.GroupBox();
            this.lbSelectNo = new System.Windows.Forms.Label();
            this.lbSNP = new System.Windows.Forms.Label();
            this.lbFullName = new System.Windows.Forms.Label();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInf)).BeginInit();
            this.gbDetailType.SuspendLayout();
            this.gbPeriod.SuspendLayout();
            this.gbSelectNumber.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInf
            // 
            this.dgvInf.AllowUserToAddRows = false;
            this.dgvInf.AllowUserToDeleteRows = false;
            this.dgvInf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colTime,
            this.colNumber,
            this.colService,
            this.colDuration,
            this.colCost});
            this.dgvInf.Location = new System.Drawing.Point(12, 47);
            this.dgvInf.Name = "dgvInf";
            this.dgvInf.ReadOnly = true;
            this.dgvInf.RowHeadersVisible = false;
            this.dgvInf.Size = new System.Drawing.Size(585, 403);
            this.dgvInf.TabIndex = 0;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(32, 54);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(154, 20);
            this.dtpTo.TabIndex = 1;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(32, 24);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(154, 20);
            this.dtpFrom.TabIndex = 2;
            // 
            // rbCalls
            // 
            this.rbCalls.AutoSize = true;
            this.rbCalls.Location = new System.Drawing.Point(9, 28);
            this.rbCalls.Name = "rbCalls";
            this.rbCalls.Size = new System.Drawing.Size(155, 17);
            this.rbCalls.TabIndex = 3;
            this.rbCalls.TabStop = true;
            this.rbCalls.Text = "Детализация разговоров";
            this.rbCalls.UseVisualStyleBackColor = true;
            // 
            // rbServices
            // 
            this.rbServices.AutoSize = true;
            this.rbServices.Location = new System.Drawing.Point(9, 97);
            this.rbServices.Name = "rbServices";
            this.rbServices.Size = new System.Drawing.Size(137, 17);
            this.rbServices.TabIndex = 4;
            this.rbServices.TabStop = true;
            this.rbServices.Text = "Управление услугами";
            this.rbServices.UseVisualStyleBackColor = true;
            // 
            // rbPayments
            // 
            this.rbPayments.AutoSize = true;
            this.rbPayments.Location = new System.Drawing.Point(9, 74);
            this.rbPayments.Name = "rbPayments";
            this.rbPayments.Size = new System.Drawing.Size(120, 17);
            this.rbPayments.TabIndex = 5;
            this.rbPayments.TabStop = true;
            this.rbPayments.Text = "История платежей";
            this.rbPayments.UseVisualStyleBackColor = true;
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Location = new System.Drawing.Point(607, 427);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(192, 23);
            this.btnSaveToFile.TabIndex = 6;
            this.btnSaveToFile.Text = "Сохранить в ...";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // lbNumbers
            // 
            this.lbNumbers.FormattingEnabled = true;
            this.lbNumbers.Location = new System.Drawing.Point(9, 41);
            this.lbNumbers.Name = "lbNumbers";
            this.lbNumbers.Size = new System.Drawing.Size(170, 82);
            this.lbNumbers.TabIndex = 8;
            this.lbNumbers.SelectedIndexChanged += new System.EventHandler(this.lbNumbers_SelectedIndexChanged);
            // 
            // rbTariffs
            // 
            this.rbTariffs.AutoSize = true;
            this.rbTariffs.Location = new System.Drawing.Point(9, 51);
            this.rbTariffs.Name = "rbTariffs";
            this.rbTariffs.Size = new System.Drawing.Size(123, 17);
            this.rbTariffs.TabIndex = 10;
            this.rbTariffs.TabStop = true;
            this.rbTariffs.Text = "Изменение тарифа";
            this.rbTariffs.UseVisualStyleBackColor = true;
            // 
            // lbStartDate
            // 
            this.lbStartDate.AutoSize = true;
            this.lbStartDate.Location = new System.Drawing.Point(465, 160);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(0, 13);
            this.lbStartDate.TabIndex = 11;
            // 
            // gbDetailType
            // 
            this.gbDetailType.Controls.Add(this.rbCalls);
            this.gbDetailType.Controls.Add(this.rbTariffs);
            this.gbDetailType.Controls.Add(this.rbServices);
            this.gbDetailType.Controls.Add(this.rbPayments);
            this.gbDetailType.Location = new System.Drawing.Point(607, 187);
            this.gbDetailType.Name = "gbDetailType";
            this.gbDetailType.Size = new System.Drawing.Size(192, 130);
            this.gbDetailType.TabIndex = 13;
            this.gbDetailType.TabStop = false;
            this.gbDetailType.Text = "Тип детализации";
            // 
            // gbPeriod
            // 
            this.gbPeriod.Controls.Add(this.lbTo);
            this.gbPeriod.Controls.Add(this.lbFrom);
            this.gbPeriod.Controls.Add(this.dtpFrom);
            this.gbPeriod.Controls.Add(this.dtpTo);
            this.gbPeriod.Location = new System.Drawing.Point(607, 324);
            this.gbPeriod.Name = "gbPeriod";
            this.gbPeriod.Size = new System.Drawing.Size(192, 87);
            this.gbPeriod.TabIndex = 14;
            this.gbPeriod.TabStop = false;
            this.gbPeriod.Text = "Период детализации";
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.Location = new System.Drawing.Point(6, 56);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(24, 13);
            this.lbTo.TabIndex = 4;
            this.lbTo.Text = "По:";
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.Location = new System.Drawing.Point(7, 27);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(17, 13);
            this.lbFrom.TabIndex = 3;
            this.lbFrom.Text = "С:";
            // 
            // gbSelectNumber
            // 
            this.gbSelectNumber.Controls.Add(this.lbSelectNo);
            this.gbSelectNumber.Controls.Add(this.lbNumbers);
            this.gbSelectNumber.Location = new System.Drawing.Point(607, 45);
            this.gbSelectNumber.Name = "gbSelectNumber";
            this.gbSelectNumber.Size = new System.Drawing.Size(191, 135);
            this.gbSelectNumber.TabIndex = 15;
            this.gbSelectNumber.TabStop = false;
            this.gbSelectNumber.Text = "Выбор номера";
            // 
            // lbSelectNo
            // 
            this.lbSelectNo.AutoSize = true;
            this.lbSelectNo.Location = new System.Drawing.Point(6, 24);
            this.lbSelectNo.Name = "lbSelectNo";
            this.lbSelectNo.Size = new System.Drawing.Size(176, 13);
            this.lbSelectNo.TabIndex = 9;
            this.lbSelectNo.Text = "Выберите один номер из списка:";
            // 
            // lbSNP
            // 
            this.lbSNP.AutoSize = true;
            this.lbSNP.Location = new System.Drawing.Point(18, 16);
            this.lbSNP.Name = "lbSNP";
            this.lbSNP.Size = new System.Drawing.Size(37, 13);
            this.lbSNP.TabIndex = 16;
            this.lbSNP.Text = "ФИО:";
            // 
            // lbFullName
            // 
            this.lbFullName.Location = new System.Drawing.Point(62, 16);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(256, 13);
            this.lbFullName.TabIndex = 17;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Дата";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.Width = 80;
            // 
            // colTime
            // 
            this.colTime.HeaderText = "Время";
            this.colTime.Name = "colTime";
            this.colTime.ReadOnly = true;
            // 
            // colNumber
            // 
            this.colNumber.HeaderText = "Номер";
            this.colNumber.Name = "colNumber";
            this.colNumber.ReadOnly = true;
            // 
            // colService
            // 
            this.colService.HeaderText = "Тип";
            this.colService.Name = "colService";
            this.colService.ReadOnly = true;
            // 
            // colDuration
            // 
            this.colDuration.HeaderText = "Длительность";
            this.colDuration.Name = "colDuration";
            this.colDuration.ReadOnly = true;
            // 
            // colCost
            // 
            this.colCost.HeaderText = "Стоимость";
            this.colCost.Name = "colCost";
            this.colCost.ReadOnly = true;
            // 
            // FormDetailedInf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 477);
            this.Controls.Add(this.lbFullName);
            this.Controls.Add(this.lbSNP);
            this.Controls.Add(this.gbSelectNumber);
            this.Controls.Add(this.gbPeriod);
            this.Controls.Add(this.gbDetailType);
            this.Controls.Add(this.lbStartDate);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.dgvInf);
            this.Name = "FormDetailedInf";
            this.Text = "Детализированная информация по номеру";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInf)).EndInit();
            this.gbDetailType.ResumeLayout(false);
            this.gbDetailType.PerformLayout();
            this.gbPeriod.ResumeLayout(false);
            this.gbPeriod.PerformLayout();
            this.gbSelectNumber.ResumeLayout(false);
            this.gbSelectNumber.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInf;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.RadioButton rbCalls;
        private System.Windows.Forms.RadioButton rbServices;
        private System.Windows.Forms.RadioButton rbPayments;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.ListBox lbNumbers;
        private System.Windows.Forms.RadioButton rbTariffs;
        private System.Windows.Forms.Label lbStartDate;
        private System.Windows.Forms.GroupBox gbDetailType;
        private System.Windows.Forms.GroupBox gbPeriod;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.GroupBox gbSelectNumber;
        private System.Windows.Forms.Label lbSelectNo;
        private System.Windows.Forms.Label lbSNP;
        private System.Windows.Forms.Label lbFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colService;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCost;
    }
}