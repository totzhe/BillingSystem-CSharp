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
            this.dataGridViewInf = new System.Windows.Forms.DataGridView();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.radioButtonCalls = new System.Windows.Forms.RadioButton();
            this.radioButtonOperations = new System.Windows.Forms.RadioButton();
            this.radioButtonTariffs = new System.Windows.Forms.RadioButton();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.listBoxPhoneNumbers = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInf)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInf
            // 
            this.dataGridViewInf.AllowUserToAddRows = false;
            this.dataGridViewInf.AllowUserToDeleteRows = false;
            this.dataGridViewInf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInf.Location = new System.Drawing.Point(12, 83);
            this.dataGridViewInf.Name = "dataGridViewInf";
            this.dataGridViewInf.ReadOnly = true;
            this.dataGridViewInf.Size = new System.Drawing.Size(497, 383);
            this.dataGridViewInf.TabIndex = 0;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(12, 28);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFrom.TabIndex = 1;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(218, 28);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTo.TabIndex = 2;
            // 
            // radioButtonCalls
            // 
            this.radioButtonCalls.AutoSize = true;
            this.radioButtonCalls.Location = new System.Drawing.Point(424, 28);
            this.radioButtonCalls.Name = "radioButtonCalls";
            this.radioButtonCalls.Size = new System.Drawing.Size(85, 17);
            this.radioButtonCalls.TabIndex = 3;
            this.radioButtonCalls.TabStop = true;
            this.radioButtonCalls.Text = "radioButton1";
            this.radioButtonCalls.UseVisualStyleBackColor = true;
            // 
            // radioButtonOperations
            // 
            this.radioButtonOperations.AutoSize = true;
            this.radioButtonOperations.Location = new System.Drawing.Point(515, 28);
            this.radioButtonOperations.Name = "radioButtonOperations";
            this.radioButtonOperations.Size = new System.Drawing.Size(85, 17);
            this.radioButtonOperations.TabIndex = 4;
            this.radioButtonOperations.TabStop = true;
            this.radioButtonOperations.Text = "radioButton2";
            this.radioButtonOperations.UseVisualStyleBackColor = true;
            // 
            // radioButtonTariffs
            // 
            this.radioButtonTariffs.AutoSize = true;
            this.radioButtonTariffs.Location = new System.Drawing.Point(606, 28);
            this.radioButtonTariffs.Name = "radioButtonTariffs";
            this.radioButtonTariffs.Size = new System.Drawing.Size(85, 17);
            this.radioButtonTariffs.TabIndex = 5;
            this.radioButtonTariffs.TabStop = true;
            this.radioButtonTariffs.Text = "radioButton3";
            this.radioButtonTariffs.UseVisualStyleBackColor = true;
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Location = new System.Drawing.Point(598, 51);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(93, 23);
            this.btnSaveToFile.TabIndex = 6;
            this.btnSaveToFile.Text = "btnSaveToFile";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            // 
            // listBoxPhoneNumbers
            // 
            this.listBoxPhoneNumbers.FormattingEnabled = true;
            this.listBoxPhoneNumbers.Items.AddRange(new object[] {
            "+79083435679",
            "+79789544353",
            "+79544878756"});
            this.listBoxPhoneNumbers.Location = new System.Drawing.Point(535, 120);
            this.listBoxPhoneNumbers.Name = "listBoxPhoneNumbers";
            this.listBoxPhoneNumbers.Size = new System.Drawing.Size(120, 95);
            this.listBoxPhoneNumbers.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(515, 50);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "button1";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FormDetailedInf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 478);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.listBoxPhoneNumbers);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.radioButtonTariffs);
            this.Controls.Add(this.radioButtonOperations);
            this.Controls.Add(this.radioButtonCalls);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.dataGridViewInf);
            this.Name = "FormDetailedInf";
            this.Text = "FormDetailedInf";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInf;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.RadioButton radioButtonCalls;
        private System.Windows.Forms.RadioButton radioButtonOperations;
        private System.Windows.Forms.RadioButton radioButtonTariffs;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.ListBox listBoxPhoneNumbers;
        private System.Windows.Forms.Button btnSearch;
    }
}