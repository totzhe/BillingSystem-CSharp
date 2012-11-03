namespace BillingSystem
{
    partial class FormSearch
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDetailedInf = new System.Windows.Forms.Button();
            this.dataGridViewSearchResults = new System.Windows.Forms.DataGridView();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxDebt = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubscriberSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubscriberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubscriberPatronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumbers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchResults)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(927, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(927, 41);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(927, 79);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(102, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDetailedInf
            // 
            this.btnDetailedInf.Location = new System.Drawing.Point(927, 108);
            this.btnDetailedInf.Name = "btnDetailedInf";
            this.btnDetailedInf.Size = new System.Drawing.Size(91, 23);
            this.btnDetailedInf.TabIndex = 3;
            this.btnDetailedInf.Text = "Информация";
            this.btnDetailedInf.UseVisualStyleBackColor = true;
            this.btnDetailedInf.Click += new System.EventHandler(this.btnDetailedInf_Click);
            // 
            // dataGridViewSearchResults
            // 
            this.dataGridViewSearchResults.AllowUserToAddRows = false;
            this.dataGridViewSearchResults.AllowUserToDeleteRows = false;
            this.dataGridViewSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.SubscriberSurname,
            this.SubscriberName,
            this.SubscriberPatronymic,
            this.PhoneNumbers,
            this.Debt});
            this.dataGridViewSearchResults.Location = new System.Drawing.Point(88, 79);
            this.dataGridViewSearchResults.Name = "dataGridViewSearchResults";
            this.dataGridViewSearchResults.ReadOnly = true;
            this.dataGridViewSearchResults.Size = new System.Drawing.Size(806, 408);
            this.dataGridViewSearchResults.TabIndex = 4;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(101, 15);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Location = new System.Drawing.Point(238, 12);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(100, 20);
            this.textBoxPatronymic.TabIndex = 6;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(358, 12);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 20);
            this.textBoxSurname.TabIndex = 7;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(488, 12);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(146, 20);
            this.textBoxPhoneNumber.TabIndex = 8;
            // 
            // textBoxDebt
            // 
            this.textBoxDebt.Location = new System.Drawing.Point(671, 12);
            this.textBoxDebt.Name = "textBoxDebt";
            this.textBoxDebt.Size = new System.Drawing.Size(100, 20);
            this.textBoxDebt.TabIndex = 9;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // SubscriberSurname
            // 
            this.SubscriberSurname.HeaderText = "Фамилия";
            this.SubscriberSurname.Name = "SubscriberSurname";
            this.SubscriberSurname.ReadOnly = true;
            // 
            // SubscriberName
            // 
            this.SubscriberName.HeaderText = "Имя";
            this.SubscriberName.Name = "SubscriberName";
            this.SubscriberName.ReadOnly = true;
            // 
            // SubscriberPatronymic
            // 
            this.SubscriberPatronymic.HeaderText = "Отчество";
            this.SubscriberPatronymic.Name = "SubscriberPatronymic";
            this.SubscriberPatronymic.ReadOnly = true;
            // 
            // PhoneNumbers
            // 
            this.PhoneNumbers.HeaderText = "Телефоны";
            this.PhoneNumbers.Name = "PhoneNumbers";
            this.PhoneNumbers.ReadOnly = true;
            // 
            // Debt
            // 
            this.Debt.HeaderText = "Задолженность";
            this.Debt.Name = "Debt";
            this.Debt.ReadOnly = true;
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 531);
            this.Controls.Add(this.textBoxDebt);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxPatronymic);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.dataGridViewSearchResults);
            this.Controls.Add(this.btnDetailedInf);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearch);
            this.Name = "FormSearch";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDetailedInf;
        private System.Windows.Forms.DataGridView dataGridViewSearchResults;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxDebt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubscriberSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubscriberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubscriberPatronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumbers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debt;

    }
}

