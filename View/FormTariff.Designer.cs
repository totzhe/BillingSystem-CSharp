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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbDataTarrif = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTariffDescription = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTariffName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPrice = new System.Windows.Forms.DataGridView();
            this.btnDelPrice = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddPrice = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.tbPrefix = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvTariffName = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.gbDataTarrif.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrice)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTariffName)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.gbDataTarrif);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(178, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 407);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация по тарифу";
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
            // 
            // gbDataTarrif
            // 
            this.gbDataTarrif.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDataTarrif.Controls.Add(this.label2);
            this.gbDataTarrif.Controls.Add(this.tbTariffDescription);
            this.gbDataTarrif.Controls.Add(this.label1);
            this.gbDataTarrif.Controls.Add(this.tbTariffName);
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
            // tbTariffDescription
            // 
            this.tbTariffDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTariffDescription.Location = new System.Drawing.Point(6, 94);
            this.tbTariffDescription.Name = "tbTariffDescription";
            this.tbTariffDescription.Size = new System.Drawing.Size(161, 246);
            this.tbTariffDescription.TabIndex = 2;
            this.tbTariffDescription.Text = "";
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
            // tbTariffName
            // 
            this.tbTariffName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTariffName.Location = new System.Drawing.Point(6, 47);
            this.tbTariffName.Name = "tbTariffName";
            this.tbTariffName.Size = new System.Drawing.Size(161, 20);
            this.tbTariffName.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvPrice);
            this.groupBox1.Controls.Add(this.btnDelPrice);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(189, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 352);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Таблица стоимости";
            // 
            // dgvPrice
            // 
            this.dgvPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrice.Location = new System.Drawing.Point(6, 20);
            this.dgvPrice.Name = "dgvPrice";
            this.dgvPrice.Size = new System.Drawing.Size(189, 320);
            this.dgvPrice.TabIndex = 6;
            // 
            // btnDelPrice
            // 
            this.btnDelPrice.Enabled = false;
            this.btnDelPrice.Location = new System.Drawing.Point(201, 178);
            this.btnDelPrice.Name = "btnDelPrice";
            this.btnDelPrice.Size = new System.Drawing.Size(75, 23);
            this.btnDelPrice.TabIndex = 5;
            this.btnDelPrice.Text = "Удалить";
            this.btnDelPrice.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddPrice);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tbCost);
            this.groupBox3.Controls.Add(this.tbPrefix);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(201, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(142, 144);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Добавить стоимость";
            // 
            // btnAddPrice
            // 
            this.btnAddPrice.Location = new System.Drawing.Point(10, 113);
            this.btnAddPrice.Name = "btnAddPrice";
            this.btnAddPrice.Size = new System.Drawing.Size(75, 23);
            this.btnAddPrice.TabIndex = 4;
            this.btnAddPrice.Text = "Добавить";
            this.btnAddPrice.UseVisualStyleBackColor = true;
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
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(6, 87);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(130, 20);
            this.tbCost.TabIndex = 2;
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
            // dgvTariffName
            // 
            this.dgvTariffName.AllowUserToAddRows = false;
            this.dgvTariffName.AllowUserToDeleteRows = false;
            this.dgvTariffName.AllowUserToResizeColumns = false;
            this.dgvTariffName.AllowUserToResizeRows = false;
            this.dgvTariffName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvTariffName.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTariffName.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTariffName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTariffName.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.TName});
            this.dgvTariffName.Location = new System.Drawing.Point(12, 13);
            this.dgvTariffName.Name = "dgvTariffName";
            this.dgvTariffName.ReadOnly = true;
            this.dgvTariffName.RowHeadersVisible = false;
            this.dgvTariffName.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTariffName.Size = new System.Drawing.Size(160, 370);
            this.dgvTariffName.TabIndex = 13;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // TName
            // 
            this.TName.HeaderText = "Название";
            this.TName.Name = "TName";
            this.TName.ReadOnly = true;
            // 
            // FormTariff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 424);
            this.Controls.Add(this.dgvTariffName);
            this.Controls.Add(this.groupBox2);
            this.MinimumSize = new System.Drawing.Size(746, 455);
            this.Name = "FormTariff";
            this.Text = "FormEditTariff";
            this.groupBox2.ResumeLayout(false);
            this.gbDataTarrif.ResumeLayout(false);
            this.gbDataTarrif.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrice)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTariffName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbDataTarrif;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox tbTariffDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTariffName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelPrice;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAddPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.TextBox tbPrefix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPrice;
        private System.Windows.Forms.DataGridView dgvTariffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TName;

    }
}