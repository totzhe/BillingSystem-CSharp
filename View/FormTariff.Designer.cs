namespace BillingSystem.View
{
    partial class FormTariff
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
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbDataTarrif = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.gbCost = new System.Windows.Forms.GroupBox();
            this.dgvPrice = new System.Windows.Forms.DataGridView();
            this.prefix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCostDel = new System.Windows.Forms.Button();
            this.gbAddCost = new System.Windows.Forms.GroupBox();
            this.btnCostAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbPrefix = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvNameTariff = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameTariff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.gbInfo.SuspendLayout();
            this.gbDataTarrif.SuspendLayout();
            this.gbCost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrice)).BeginInit();
            this.gbAddCost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNameTariff)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInfo
            // 
            this.gbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInfo.Controls.Add(this.btnSave);
            this.gbInfo.Controls.Add(this.gbDataTarrif);
            this.gbInfo.Controls.Add(this.btnImport);
            this.gbInfo.Controls.Add(this.gbCost);
            this.gbInfo.Location = new System.Drawing.Point(178, 12);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(544, 407);
            this.gbInfo.TabIndex = 11;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Информация по тарифу";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(6, 377);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbDataTarrif
            // 
            this.gbDataTarrif.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDataTarrif.Controls.Add(this.label2);
            this.gbDataTarrif.Controls.Add(this.tbDescription);
            this.gbDataTarrif.Controls.Add(this.label1);
            this.gbDataTarrif.Controls.Add(this.tbName);
            this.gbDataTarrif.Location = new System.Drawing.Point(6, 19);
            this.gbDataTarrif.Name = "gbDataTarrif";
            this.gbDataTarrif.Size = new System.Drawing.Size(177, 352);
            this.gbDataTarrif.TabIndex = 1;
            this.gbDataTarrif.TabStop = false;
            this.gbDataTarrif.Text = "Данные по тарифу";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Описание";
            // 
            // tbDescription
            // 
            this.tbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescription.Location = new System.Drawing.Point(6, 94);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(161, 246);
            this.tbDescription.TabIndex = 2;
            this.tbDescription.Text = "";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Location = new System.Drawing.Point(6, 47);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(161, 20);
            this.tbName.TabIndex = 0;
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.Location = new System.Drawing.Point(440, 378);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(98, 23);
            this.btnImport.TabIndex = 10;
            this.btnImport.Text = "Импортировать";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // gbCost
            // 
            this.gbCost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCost.Controls.Add(this.dgvPrice);
            this.gbCost.Controls.Add(this.btnCostDel);
            this.gbCost.Controls.Add(this.gbAddCost);
            this.gbCost.Location = new System.Drawing.Point(189, 19);
            this.gbCost.Name = "gbCost";
            this.gbCost.Size = new System.Drawing.Size(349, 352);
            this.gbCost.TabIndex = 5;
            this.gbCost.TabStop = false;
            this.gbCost.Text = "Таблица стоимости";
            // 
            // dgvPrice
            // 
            this.dgvPrice.AllowUserToAddRows = false;
            this.dgvPrice.AllowUserToDeleteRows = false;
            this.dgvPrice.AllowUserToResizeColumns = false;
            this.dgvPrice.AllowUserToResizeRows = false;
            this.dgvPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvPrice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prefix,
            this.price});
            this.dgvPrice.Location = new System.Drawing.Point(6, 20);
            this.dgvPrice.Name = "dgvPrice";
            this.dgvPrice.RowHeadersVisible = false;
            this.dgvPrice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrice.Size = new System.Drawing.Size(189, 320);
            this.dgvPrice.TabIndex = 6;
            // 
            // prefix
            // 
            this.prefix.HeaderText = "Префикс";
            this.prefix.Name = "prefix";
            this.prefix.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Цена";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // btnCostDel
            // 
            this.btnCostDel.Enabled = false;
            this.btnCostDel.Location = new System.Drawing.Point(207, 187);
            this.btnCostDel.Name = "btnCostDel";
            this.btnCostDel.Size = new System.Drawing.Size(75, 23);
            this.btnCostDel.TabIndex = 5;
            this.btnCostDel.Text = "Удалить";
            this.btnCostDel.UseVisualStyleBackColor = true;
            // 
            // gbAddCost
            // 
            this.gbAddCost.Controls.Add(this.btnCostAdd);
            this.gbAddCost.Controls.Add(this.label4);
            this.gbAddCost.Controls.Add(this.tbPrice);
            this.gbAddCost.Controls.Add(this.tbPrefix);
            this.gbAddCost.Controls.Add(this.label3);
            this.gbAddCost.Location = new System.Drawing.Point(201, 28);
            this.gbAddCost.Name = "gbAddCost";
            this.gbAddCost.Size = new System.Drawing.Size(142, 144);
            this.gbAddCost.TabIndex = 3;
            this.gbAddCost.TabStop = false;
            this.gbAddCost.Text = "Добавить стоимость";
            // 
            // btnCostAdd
            // 
            this.btnCostAdd.Location = new System.Drawing.Point(10, 113);
            this.btnCostAdd.Name = "btnCostAdd";
            this.btnCostAdd.Size = new System.Drawing.Size(75, 23);
            this.btnCostAdd.TabIndex = 4;
            this.btnCostAdd.Text = "Добавить";
            this.btnCostAdd.UseVisualStyleBackColor = true;
            this.btnCostAdd.Click += new System.EventHandler(this.btnCostAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Цена";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(6, 87);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(130, 20);
            this.tbPrice.TabIndex = 2;
            // 
            // tbPrefix
            // 
            this.tbPrefix.Location = new System.Drawing.Point(6, 42);
            this.tbPrefix.Name = "tbPrefix";
            this.tbPrefix.Size = new System.Drawing.Size(130, 20);
            this.tbPrefix.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Префикс";
            // 
            // dgvNameTariff
            // 
            this.dgvNameTariff.AllowUserToAddRows = false;
            this.dgvNameTariff.AllowUserToDeleteRows = false;
            this.dgvNameTariff.AllowUserToResizeColumns = false;
            this.dgvNameTariff.AllowUserToResizeRows = false;
            this.dgvNameTariff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvNameTariff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNameTariff.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNameTariff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNameTariff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.NameTariff});
            this.dgvNameTariff.Location = new System.Drawing.Point(12, 13);
            this.dgvNameTariff.MultiSelect = false;
            this.dgvNameTariff.Name = "dgvNameTariff";
            this.dgvNameTariff.RowHeadersVisible = false;
            this.dgvNameTariff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNameTariff.Size = new System.Drawing.Size(160, 370);
            this.dgvNameTariff.TabIndex = 13;
            this.dgvNameTariff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNameTariff_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // NameTariff
            // 
            this.NameTariff.HeaderText = "Название";
            this.NameTariff.Name = "NameTariff";
            this.NameTariff.ReadOnly = true;
            this.NameTariff.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FormTariff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 424);
            this.Controls.Add(this.dgvNameTariff);
            this.Controls.Add(this.gbInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(746, 455);
            this.Name = "FormTariff";
            this.gbInfo.ResumeLayout(false);
            this.gbDataTarrif.ResumeLayout(false);
            this.gbDataTarrif.PerformLayout();
            this.gbCost.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrice)).EndInit();
            this.gbAddCost.ResumeLayout(false);
            this.gbAddCost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNameTariff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbDataTarrif;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox tbDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.GroupBox gbCost;
        private System.Windows.Forms.Button btnCostDel;
        private System.Windows.Forms.GroupBox gbAddCost;
        private System.Windows.Forms.Button btnCostAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbPrefix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.DataGridView dgvPrice;
        private System.Windows.Forms.DataGridView dgvNameTariff;
        private System.Windows.Forms.DataGridViewTextBoxColumn prefix;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameTariff;
        private System.Windows.Forms.OpenFileDialog openFileDialog;

    }
}