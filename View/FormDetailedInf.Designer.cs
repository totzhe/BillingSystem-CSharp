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
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.rbtnCalls = new System.Windows.Forms.RadioButton();
            this.rbtnServices = new System.Windows.Forms.RadioButton();
            this.rbtnPayments = new System.Windows.Forms.RadioButton();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.lbNumbers = new System.Windows.Forms.ListBox();
            this.rbtnTariffs = new System.Windows.Forms.RadioButton();
            this.gbDetailType = new System.Windows.Forms.GroupBox();
            this.gbPeriod = new System.Windows.Forms.GroupBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.gbSelectNumber = new System.Windows.Forms.GroupBox();
            this.lblSelectNo = new System.Windows.Forms.Label();
            this.lblFromBalance = new System.Windows.Forms.Label();
            this.lblToBalance = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblBalanceText = new System.Windows.Forms.Label();
            this.lblBalanceToText = new System.Windows.Forms.Label();
            this.lblBalanceFromText = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
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
            this.dgvInf.AllowUserToResizeColumns = false;
            this.dgvInf.AllowUserToResizeRows = false;
            this.dgvInf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInf.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colTime,
            this.colNumber,
            this.colService,
            this.colDuration,
            this.colCost});
            this.dgvInf.Location = new System.Drawing.Point(12, 30);
            this.dgvInf.Name = "dgvInf";
            this.dgvInf.ReadOnly = true;
            this.dgvInf.RowHeadersVisible = false;
            this.dgvInf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInf.Size = new System.Drawing.Size(585, 403);
            this.dgvInf.TabIndex = 0;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Дата";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
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
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(32, 54);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(154, 20);
            this.dtpTo.TabIndex = 1;
            this.dtpTo.CloseUp += new System.EventHandler(this.dtpTo_CloseUp);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(32, 24);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(154, 20);
            this.dtpFrom.TabIndex = 2;
            this.dtpFrom.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpFrom.CloseUp += new System.EventHandler(this.dtpFrom_CloseUp);
            // 
            // rbtnCalls
            // 
            this.rbtnCalls.AutoCheck = false;
            this.rbtnCalls.AutoSize = true;
            this.rbtnCalls.Checked = true;
            this.rbtnCalls.Location = new System.Drawing.Point(9, 28);
            this.rbtnCalls.Name = "rbtnCalls";
            this.rbtnCalls.Size = new System.Drawing.Size(155, 17);
            this.rbtnCalls.TabIndex = 3;
            this.rbtnCalls.TabStop = true;
            this.rbtnCalls.Text = "Детализация разговоров";
            this.rbtnCalls.UseVisualStyleBackColor = true;
            this.rbtnCalls.Click += new System.EventHandler(this.rbtnCalls_Click);
            // 
            // rbtnServices
            // 
            this.rbtnServices.AutoCheck = false;
            this.rbtnServices.AutoSize = true;
            this.rbtnServices.Location = new System.Drawing.Point(9, 97);
            this.rbtnServices.Name = "rbtnServices";
            this.rbtnServices.Size = new System.Drawing.Size(119, 17);
            this.rbtnServices.TabIndex = 4;
            this.rbtnServices.TabStop = true;
            this.rbtnServices.Text = "История списаний";
            this.rbtnServices.UseVisualStyleBackColor = true;
            this.rbtnServices.Click += new System.EventHandler(this.rbtnServices_Click);
            // 
            // rbtnPayments
            // 
            this.rbtnPayments.AutoCheck = false;
            this.rbtnPayments.AutoSize = true;
            this.rbtnPayments.Location = new System.Drawing.Point(9, 74);
            this.rbtnPayments.Name = "rbtnPayments";
            this.rbtnPayments.Size = new System.Drawing.Size(120, 17);
            this.rbtnPayments.TabIndex = 5;
            this.rbtnPayments.TabStop = true;
            this.rbtnPayments.Text = "История платежей";
            this.rbtnPayments.UseVisualStyleBackColor = true;
            this.rbtnPayments.Click += new System.EventHandler(this.rbtnPayments_Click);
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Location = new System.Drawing.Point(607, 406);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(192, 27);
            this.btnSaveToFile.TabIndex = 6;
            this.btnSaveToFile.Text = "Сохранить в ...";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // lbNumbers
            // 
            this.lbNumbers.FormattingEnabled = true;
            this.lbNumbers.Location = new System.Drawing.Point(10, 47);
            this.lbNumbers.Name = "lbNumbers";
            this.lbNumbers.Size = new System.Drawing.Size(170, 82);
            this.lbNumbers.TabIndex = 8;
            this.lbNumbers.SelectedIndexChanged += new System.EventHandler(this.lbNumbers_SelectedIndexChanged);
            // 
            // rbtnTariffs
            // 
            this.rbtnTariffs.AutoCheck = false;
            this.rbtnTariffs.AutoSize = true;
            this.rbtnTariffs.Location = new System.Drawing.Point(9, 51);
            this.rbtnTariffs.Name = "rbtnTariffs";
            this.rbtnTariffs.Size = new System.Drawing.Size(123, 17);
            this.rbtnTariffs.TabIndex = 10;
            this.rbtnTariffs.TabStop = true;
            this.rbtnTariffs.Text = "Изменение тарифа";
            this.rbtnTariffs.UseVisualStyleBackColor = true;
            this.rbtnTariffs.Click += new System.EventHandler(this.rbtnTariffs_Click);
            // 
            // gbDetailType
            // 
            this.gbDetailType.Controls.Add(this.rbtnCalls);
            this.gbDetailType.Controls.Add(this.rbtnTariffs);
            this.gbDetailType.Controls.Add(this.rbtnServices);
            this.gbDetailType.Controls.Add(this.rbtnPayments);
            this.gbDetailType.Location = new System.Drawing.Point(607, 170);
            this.gbDetailType.Name = "gbDetailType";
            this.gbDetailType.Size = new System.Drawing.Size(192, 130);
            this.gbDetailType.TabIndex = 13;
            this.gbDetailType.TabStop = false;
            this.gbDetailType.Text = "Тип детализации";
            // 
            // gbPeriod
            // 
            this.gbPeriod.Controls.Add(this.lblTo);
            this.gbPeriod.Controls.Add(this.lblFrom);
            this.gbPeriod.Controls.Add(this.dtpFrom);
            this.gbPeriod.Controls.Add(this.dtpTo);
            this.gbPeriod.Location = new System.Drawing.Point(607, 307);
            this.gbPeriod.Name = "gbPeriod";
            this.gbPeriod.Size = new System.Drawing.Size(192, 87);
            this.gbPeriod.TabIndex = 14;
            this.gbPeriod.TabStop = false;
            this.gbPeriod.Text = "Период детализации";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(6, 56);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(24, 13);
            this.lblTo.TabIndex = 4;
            this.lblTo.Text = "По:";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(7, 27);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(17, 13);
            this.lblFrom.TabIndex = 3;
            this.lblFrom.Text = "С:";
            // 
            // gbSelectNumber
            // 
            this.gbSelectNumber.Controls.Add(this.lblSelectNo);
            this.gbSelectNumber.Controls.Add(this.lbNumbers);
            this.gbSelectNumber.Location = new System.Drawing.Point(608, 28);
            this.gbSelectNumber.Name = "gbSelectNumber";
            this.gbSelectNumber.Size = new System.Drawing.Size(191, 136);
            this.gbSelectNumber.TabIndex = 15;
            this.gbSelectNumber.TabStop = false;
            this.gbSelectNumber.Text = "Выбор номера";
            // 
            // lblSelectNo
            // 
            this.lblSelectNo.Location = new System.Drawing.Point(7, 23);
            this.lblSelectNo.Name = "lblSelectNo";
            this.lblSelectNo.Size = new System.Drawing.Size(158, 23);
            this.lblSelectNo.TabIndex = 0;
            this.lblSelectNo.Text = "Выберите номер из списка:";
            // 
            // lblFromBalance
            // 
            this.lblFromBalance.AutoSize = true;
            this.lblFromBalance.Location = new System.Drawing.Point(311, 9);
            this.lblFromBalance.Name = "lblFromBalance";
            this.lblFromBalance.Size = new System.Drawing.Size(79, 13);
            this.lblFromBalance.TabIndex = 19;
            this.lblFromBalance.Text = "lblFromBalance";
            // 
            // lblToBalance
            // 
            this.lblToBalance.AutoSize = true;
            this.lblToBalance.Location = new System.Drawing.Point(536, 9);
            this.lblToBalance.Name = "lblToBalance";
            this.lblToBalance.Size = new System.Drawing.Size(69, 13);
            this.lblToBalance.TabIndex = 20;
            this.lblToBalance.Text = "lblToBalance";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(104, 9);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(56, 13);
            this.lblBalance.TabIndex = 21;
            this.lblBalance.Text = "lblBalance";
            // 
            // lblBalanceText
            // 
            this.lblBalanceText.AutoSize = true;
            this.lblBalanceText.Location = new System.Drawing.Point(12, 9);
            this.lblBalanceText.Name = "lblBalanceText";
            this.lblBalanceText.Size = new System.Drawing.Size(94, 13);
            this.lblBalanceText.TabIndex = 22;
            this.lblBalanceText.Text = "Текущий баланс:";
            // 
            // lblBalanceToText
            // 
            this.lblBalanceToText.AutoSize = true;
            this.lblBalanceToText.Location = new System.Drawing.Point(404, 9);
            this.lblBalanceToText.Name = "lblBalanceToText";
            this.lblBalanceToText.Size = new System.Drawing.Size(134, 13);
            this.lblBalanceToText.TabIndex = 23;
            this.lblBalanceToText.Text = "Баланс в конце периода:";
            // 
            // lblBalanceFromText
            // 
            this.lblBalanceFromText.AutoSize = true;
            this.lblBalanceFromText.Location = new System.Drawing.Point(174, 9);
            this.lblBalanceFromText.Name = "lblBalanceFromText";
            this.lblBalanceFromText.Size = new System.Drawing.Size(139, 13);
            this.lblBalanceFromText.TabIndex = 24;
            this.lblBalanceFromText.Text = "Баланс в начале периода:";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "csv files (*.csv)|*.csv";
            // 
            // FormDetailedInf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 445);
            this.Controls.Add(this.lblBalanceFromText);
            this.Controls.Add(this.lblBalanceToText);
            this.Controls.Add(this.lblBalanceText);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblToBalance);
            this.Controls.Add(this.lblFromBalance);
            this.Controls.Add(this.gbSelectNumber);
            this.Controls.Add(this.gbPeriod);
            this.Controls.Add(this.gbDetailType);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.dgvInf);
            this.MaximumSize = new System.Drawing.Size(832, 483);
            this.MinimumSize = new System.Drawing.Size(832, 483);
            this.Name = "FormDetailedInf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Детализированная информация по номеру";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInf)).EndInit();
            this.gbDetailType.ResumeLayout(false);
            this.gbDetailType.PerformLayout();
            this.gbPeriod.ResumeLayout(false);
            this.gbPeriod.PerformLayout();
            this.gbSelectNumber.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInf;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.RadioButton rbtnCalls;
        private System.Windows.Forms.RadioButton rbtnServices;
        private System.Windows.Forms.RadioButton rbtnPayments;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.ListBox lbNumbers;
        private System.Windows.Forms.RadioButton rbtnTariffs;
        private System.Windows.Forms.Label lbStartDate;
        private System.Windows.Forms.GroupBox gbDetailType;
        private System.Windows.Forms.GroupBox gbPeriod;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.GroupBox gbSelectNumber;
        private System.Windows.Forms.Label lblSelectNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colService;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCost;
        private System.Windows.Forms.Label lblFromBalance;
        private System.Windows.Forms.Label lblToBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblBalanceText;
        private System.Windows.Forms.Label lblBalanceToText;
        private System.Windows.Forms.Label lblBalanceFromText;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}