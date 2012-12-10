namespace BillingSystem.View
{
    partial class FormCallsImport
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.dgvImportCalls = new System.Windows.Forms.DataGridView();
            this.fromNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRnd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportCalls)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOpenFile.Location = new System.Drawing.Point(13, 340);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(101, 23);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Открыть файл";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // dgvImportCalls
            // 
            this.dgvImportCalls.AllowUserToAddRows = false;
            this.dgvImportCalls.AllowUserToDeleteRows = false;
            this.dgvImportCalls.AllowUserToResizeColumns = false;
            this.dgvImportCalls.AllowUserToResizeRows = false;
            this.dgvImportCalls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvImportCalls.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvImportCalls.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvImportCalls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImportCalls.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fromNumber,
            this.toNumber,
            this.start_time,
            this.end_time});
            this.dgvImportCalls.Location = new System.Drawing.Point(13, 13);
            this.dgvImportCalls.Name = "dgvImportCalls";
            this.dgvImportCalls.RowHeadersVisible = false;
            this.dgvImportCalls.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvImportCalls.Size = new System.Drawing.Size(513, 321);
            this.dgvImportCalls.TabIndex = 1;
            // 
            // fromNumber
            // 
            this.fromNumber.HeaderText = "С номера";
            this.fromNumber.Name = "fromNumber";
            // 
            // toNumber
            // 
            this.toNumber.HeaderText = "На номер";
            this.toNumber.Name = "toNumber";
            // 
            // start_time
            // 
            this.start_time.HeaderText = "Время начала";
            this.start_time.Name = "start_time";
            // 
            // end_time
            // 
            this.end_time.HeaderText = "Время заверешения";
            this.end_time.Name = "end_time";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(450, 340);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRnd
            // 
            this.btnRnd.Location = new System.Drawing.Point(120, 340);
            this.btnRnd.Name = "btnRnd";
            this.btnRnd.Size = new System.Drawing.Size(75, 23);
            this.btnRnd.TabIndex = 3;
            this.btnRnd.Text = "Рандом";
            this.btnRnd.UseVisualStyleBackColor = true;
            this.btnRnd.Click += new System.EventHandler(this.btnRnd_Click);
            // 
            // FormCallsImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 376);
            this.Controls.Add(this.btnRnd);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvImportCalls);
            this.Controls.Add(this.btnOpenFile);
            this.MinimumSize = new System.Drawing.Size(554, 414);
            this.Name = "FormCallsImport";
            this.Text = "Импорт пользовательских звонков";
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportCalls)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.DataGridView dgvImportCalls;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn toNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn start_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_time;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRnd;
    }
}