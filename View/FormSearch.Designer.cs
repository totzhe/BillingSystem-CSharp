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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewSearchResults = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubscriberSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubscriberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubscriberPatronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumbers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxDebt = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelDebt = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSaveToCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddSubscriber = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEditSubscriber = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInfoSubscriber = new System.Windows.Forms.ToolStripMenuItem();
            this.тарифыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddTariff = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEditTariff = new System.Windows.Forms.ToolStripMenuItem();
            this.инструментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDeposit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCharge = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCallsImport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.импортТарифовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMonthlyInfo = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchResults)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewSearchResults
            // 
            this.dataGridViewSearchResults.AllowUserToAddRows = false;
            this.dataGridViewSearchResults.AllowUserToDeleteRows = false;
            this.dataGridViewSearchResults.AllowUserToResizeColumns = false;
            this.dataGridViewSearchResults.AllowUserToResizeRows = false;
            this.dataGridViewSearchResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSearchResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSearchResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.SubscriberSurname,
            this.SubscriberName,
            this.SubscriberPatronymic,
            this.PhoneNumbers,
            this.Debt});
            this.dataGridViewSearchResults.Location = new System.Drawing.Point(12, 41);
            this.dataGridViewSearchResults.Name = "dataGridViewSearchResults";
            this.dataGridViewSearchResults.ReadOnly = true;
            this.dataGridViewSearchResults.RowHeadersVisible = false;
            this.dataGridViewSearchResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSearchResults.Size = new System.Drawing.Size(712, 508);
            this.dataGridViewSearchResults.TabIndex = 4;
            this.dataGridViewSearchResults.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSearchResults_CellDoubleClick);
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
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PhoneNumbers.DefaultCellStyle = dataGridViewCellStyle1;
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
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxName.Location = new System.Drawing.Point(6, 89);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(155, 20);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxPatronymic.Location = new System.Drawing.Point(6, 135);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(151, 20);
            this.textBoxPatronymic.TabIndex = 6;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxSurname.Location = new System.Drawing.Point(6, 41);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(155, 20);
            this.textBoxSurname.TabIndex = 7;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(6, 185);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(151, 20);
            this.textBoxPhoneNumber.TabIndex = 8;
            // 
            // textBoxDebt
            // 
            this.textBoxDebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxDebt.Location = new System.Drawing.Point(6, 239);
            this.textBoxDebt.Name = "textBoxDebt";
            this.textBoxDebt.Size = new System.Drawing.Size(151, 20);
            this.textBoxDebt.TabIndex = 9;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelName.Location = new System.Drawing.Point(6, 73);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 10;
            this.labelName.Text = "Имя";
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelPatronymic.Location = new System.Drawing.Point(6, 119);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(54, 13);
            this.labelPatronymic.TabIndex = 11;
            this.labelPatronymic.Text = "Отчество";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelSurname.Location = new System.Drawing.Point(6, 25);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(56, 13);
            this.labelSurname.TabIndex = 12;
            this.labelSurname.Text = "Фамилия";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelPhoneNumber.Location = new System.Drawing.Point(6, 169);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(93, 13);
            this.labelPhoneNumber.TabIndex = 13;
            this.labelPhoneNumber.Text = "Номер телефона";
            // 
            // labelDebt
            // 
            this.labelDebt.AutoSize = true;
            this.labelDebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelDebt.Location = new System.Drawing.Point(6, 223);
            this.labelDebt.Name = "labelDebt";
            this.labelDebt.Size = new System.Drawing.Size(87, 13);
            this.labelDebt.TabIndex = 14;
            this.labelDebt.Text = "Задолженность";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "csv files (*.csv)|*.csv";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.labelSurname);
            this.groupBox1.Controls.Add(this.textBoxSurname);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.textBoxPatronymic);
            this.groupBox1.Controls.Add(this.textBoxPhoneNumber);
            this.groupBox1.Controls.Add(this.textBoxDebt);
            this.groupBox1.Controls.Add(this.labelDebt);
            this.groupBox1.Controls.Add(this.labelPatronymic);
            this.groupBox1.Controls.Add(this.labelPhoneNumber);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Location = new System.Drawing.Point(730, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 305);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтр";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::BillingSystem.Properties.Resources.google_custom_search;
            this.btnSearch.Location = new System.Drawing.Point(9, 276);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSearch.Size = new System.Drawing.Size(148, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.пользователиToolStripMenuItem,
            this.тарифыToolStripMenuItem,
            this.инструментыToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(908, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSaveToCSV});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // tsmSaveToCSV
            // 
            this.tsmSaveToCSV.Image = global::BillingSystem.Properties.Resources.script_save;
            this.tsmSaveToCSV.Name = "tsmSaveToCSV";
            this.tsmSaveToCSV.Size = new System.Drawing.Size(165, 22);
            this.tsmSaveToCSV.Text = "Сохранить в CSV";
            this.tsmSaveToCSV.Click += new System.EventHandler(this.tsmSaveToCSV_Click);
            // 
            // пользователиToolStripMenuItem
            // 
            this.пользователиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAddSubscriber,
            this.tsmEditSubscriber,
            this.tsmInfoSubscriber});
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.пользователиToolStripMenuItem.Text = "Пользователи";
            // 
            // tsmAddSubscriber
            // 
            this.tsmAddSubscriber.Image = global::BillingSystem.Properties.Resources.user_add;
            this.tsmAddSubscriber.Name = "tsmAddSubscriber";
            this.tsmAddSubscriber.Size = new System.Drawing.Size(236, 22);
            this.tsmAddSubscriber.Text = "Добавить пользователя";
            this.tsmAddSubscriber.Click += new System.EventHandler(this.tsmAddSubscriber_Click);
            // 
            // tsmEditSubscriber
            // 
            this.tsmEditSubscriber.Image = global::BillingSystem.Properties.Resources.user_edit;
            this.tsmEditSubscriber.Name = "tsmEditSubscriber";
            this.tsmEditSubscriber.Size = new System.Drawing.Size(236, 22);
            this.tsmEditSubscriber.Text = "Редактировать пользователя";
            this.tsmEditSubscriber.Click += new System.EventHandler(this.tsmEditSubscriber_Click);
            // 
            // tsmInfoSubscriber
            // 
            this.tsmInfoSubscriber.Image = global::BillingSystem.Properties.Resources.user_go;
            this.tsmInfoSubscriber.Name = "tsmInfoSubscriber";
            this.tsmInfoSubscriber.Size = new System.Drawing.Size(236, 22);
            this.tsmInfoSubscriber.Text = "Информация о пользователе";
            this.tsmInfoSubscriber.Click += new System.EventHandler(this.tsmInfoSubscriber_Click);
            // 
            // тарифыToolStripMenuItem
            // 
            this.тарифыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAddTariff,
            this.tsmEditTariff});
            this.тарифыToolStripMenuItem.Name = "тарифыToolStripMenuItem";
            this.тарифыToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.тарифыToolStripMenuItem.Text = "Тарифы";
            // 
            // tsmAddTariff
            // 
            this.tsmAddTariff.Image = global::BillingSystem.Properties.Resources.telephone_add;
            this.tsmAddTariff.Name = "tsmAddTariff";
            this.tsmAddTariff.Size = new System.Drawing.Size(174, 22);
            this.tsmAddTariff.Text = "Добавить тариф";
            // 
            // tsmEditTariff
            // 
            this.tsmEditTariff.Image = global::BillingSystem.Properties.Resources.telephone_edit;
            this.tsmEditTariff.Name = "tsmEditTariff";
            this.tsmEditTariff.Size = new System.Drawing.Size(174, 22);
            this.tsmEditTariff.Text = "Изменить тарифы";
            this.tsmEditTariff.Click += new System.EventHandler(this.tsmEditTariff_Click);
            // 
            // инструментыToolStripMenuItem
            // 
            this.инструментыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDeposit,
            this.tsmCharge,
            this.tsmMonthlyInfo});
            this.инструментыToolStripMenuItem.Name = "инструментыToolStripMenuItem";
            this.инструментыToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.инструментыToolStripMenuItem.Text = "Инструменты";
            // 
            // tsmDeposit
            // 
            this.tsmDeposit.Image = global::BillingSystem.Properties.Resources.money_add;
            this.tsmDeposit.Name = "tsmDeposit";
            this.tsmDeposit.Size = new System.Drawing.Size(186, 22);
            this.tsmDeposit.Text = "Пополнить счет";
            this.tsmDeposit.Click += new System.EventHandler(this.tsmDeposit_Click);
            // 
            // tsmCharge
            // 
            this.tsmCharge.Image = global::BillingSystem.Properties.Resources.moneybox;
            this.tsmCharge.Name = "tsmCharge";
            this.tsmCharge.Size = new System.Drawing.Size(186, 22);
            this.tsmCharge.Text = "Обсчитать";
            this.tsmCharge.Click += new System.EventHandler(this.tsmCharge_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCallsImport,
            this.toolStripSeparator1,
            this.импортТарифовToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(113, 20);
            this.toolStripMenuItem1.Text = "Экспорт/Импорт";
            // 
            // tsmCallsImport
            // 
            this.tsmCallsImport.Image = global::BillingSystem.Properties.Resources.document_import;
            this.tsmCallsImport.Name = "tsmCallsImport";
            this.tsmCallsImport.Size = new System.Drawing.Size(168, 22);
            this.tsmCallsImport.Text = "Импорт звонков";
            this.tsmCallsImport.Click += new System.EventHandler(this.tsmCallsImport_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // импортТарифовToolStripMenuItem
            // 
            this.импортТарифовToolStripMenuItem.Image = global::BillingSystem.Properties.Resources.document_import;
            this.импортТарифовToolStripMenuItem.Name = "импортТарифовToolStripMenuItem";
            this.импортТарифовToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.импортТарифовToolStripMenuItem.Text = "Импорт тарифов";
            // 
            // tsmMonthlyInfo
            // 
            this.tsmMonthlyInfo.Name = "tsmMonthlyInfo";
            this.tsmMonthlyInfo.Size = new System.Drawing.Size(186, 22);
            this.tsmMonthlyInfo.Text = "Статистика за месяц";
            this.tsmMonthlyInfo.Click += new System.EventHandler(this.tsmMonthlyInfo_Click);
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 562);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewSearchResults);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormSearch";
            this.Text = "Биллинговая система";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchResults)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridViewSearchResults;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxDebt;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelDebt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubscriberSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubscriberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubscriberPatronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumbers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debt;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmCallsImport;
        private System.Windows.Forms.ToolStripMenuItem тарифыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmAddTariff;
        private System.Windows.Forms.ToolStripMenuItem tsmEditTariff;
        private System.Windows.Forms.ToolStripMenuItem инструментыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmDeposit;
        private System.Windows.Forms.ToolStripMenuItem tsmCharge;
        private System.Windows.Forms.ToolStripMenuItem импортТарифовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmAddSubscriber;
        private System.Windows.Forms.ToolStripMenuItem tsmEditSubscriber;
        private System.Windows.Forms.ToolStripMenuItem tsmInfoSubscriber;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmSaveToCSV;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmMonthlyInfo;

    }
}

