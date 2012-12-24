namespace BillingSystem.View
{
    partial class FormSelectTariff
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
            this.cbTariff = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.lblCurrentTariffName = new System.Windows.Forms.Label();
            this.gbCurrentNumberInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSelectNewTariff = new System.Windows.Forms.Label();
            this.lblCurTariff = new System.Windows.Forms.Label();
            this.gbCurrentNumberInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbTariff
            // 
            this.cbTariff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTariff.FormattingEnabled = true;
            this.cbTariff.Location = new System.Drawing.Point(116, 52);
            this.cbTariff.Name = "cbTariff";
            this.cbTariff.Size = new System.Drawing.Size(153, 21);
            this.cbTariff.TabIndex = 0;
            this.cbTariff.SelectedIndexChanged += new System.EventHandler(this.comboBoxTariff_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(170, 270);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(156, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(12, 270);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(141, 23);
            this.btnOK.TabIndex = 19;
            this.btnOK.Text = "Применить";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(15, 105);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(288, 124);
            this.textBoxDescription.TabIndex = 21;
            // 
            // lblCurrentTariffName
            // 
            this.lblCurrentTariffName.AutoSize = true;
            this.lblCurrentTariffName.Location = new System.Drawing.Point(113, 28);
            this.lblCurrentTariffName.Name = "lblCurrentTariffName";
            this.lblCurrentTariffName.Size = new System.Drawing.Size(55, 13);
            this.lblCurrentTariffName.TabIndex = 22;
            this.lblCurrentTariffName.Text = "tariffName";
            // 
            // gbCurrentNumberInfo
            // 
            this.gbCurrentNumberInfo.Controls.Add(this.label1);
            this.gbCurrentNumberInfo.Controls.Add(this.cbTariff);
            this.gbCurrentNumberInfo.Controls.Add(this.lblSelectNewTariff);
            this.gbCurrentNumberInfo.Controls.Add(this.lblCurTariff);
            this.gbCurrentNumberInfo.Controls.Add(this.textBoxDescription);
            this.gbCurrentNumberInfo.Controls.Add(this.lblCurrentTariffName);
            this.gbCurrentNumberInfo.Location = new System.Drawing.Point(12, 12);
            this.gbCurrentNumberInfo.Name = "gbCurrentNumberInfo";
            this.gbCurrentNumberInfo.Size = new System.Drawing.Size(314, 241);
            this.gbCurrentNumberInfo.TabIndex = 23;
            this.gbCurrentNumberInfo.TabStop = false;
            this.gbCurrentNumberInfo.Text = "Изменение тарифа";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Описание:";
            // 
            // lblSelectNewTariff
            // 
            this.lblSelectNewTariff.AutoSize = true;
            this.lblSelectNewTariff.Location = new System.Drawing.Point(12, 55);
            this.lblSelectNewTariff.Name = "lblSelectNewTariff";
            this.lblSelectNewTariff.Size = new System.Drawing.Size(78, 13);
            this.lblSelectNewTariff.TabIndex = 24;
            this.lblSelectNewTariff.Text = "Новый тариф:";
            // 
            // lblCurTariff
            // 
            this.lblCurTariff.AutoSize = true;
            this.lblCurTariff.Location = new System.Drawing.Point(12, 28);
            this.lblCurTariff.Name = "lblCurTariff";
            this.lblCurTariff.Size = new System.Drawing.Size(89, 13);
            this.lblCurTariff.TabIndex = 23;
            this.lblCurTariff.Text = "Текущий тариф:";
            // 
            // FormSelectTariff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 305);
            this.Controls.Add(this.gbCurrentNumberInfo);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(359, 343);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(359, 343);
            this.Name = "FormSelectTariff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выбор тарифа: ";
            this.gbCurrentNumberInfo.ResumeLayout(false);
            this.gbCurrentNumberInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTariff;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label lblCurrentTariffName;
        private System.Windows.Forms.GroupBox gbCurrentNumberInfo;
        private System.Windows.Forms.Label lblCurTariff;
        private System.Windows.Forms.Label lblSelectNewTariff;
        private System.Windows.Forms.Label label1;
    }
}