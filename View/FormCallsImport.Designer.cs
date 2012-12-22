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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCallsImport));
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
            this.openFileDialog.DefaultExt = "csv";
            this.openFileDialog.FileName = "openFileDialog";
            resources.ApplyResources(this.openFileDialog, "openFileDialog");
            // 
            // btnOpenFile
            // 
            resources.ApplyResources(this.btnOpenFile, "btnOpenFile");
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // dgvImportCalls
            // 
            this.dgvImportCalls.AllowUserToAddRows = false;
            this.dgvImportCalls.AllowUserToDeleteRows = false;
            this.dgvImportCalls.AllowUserToResizeColumns = false;
            this.dgvImportCalls.AllowUserToResizeRows = false;
            resources.ApplyResources(this.dgvImportCalls, "dgvImportCalls");
            this.dgvImportCalls.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvImportCalls.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvImportCalls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImportCalls.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fromNumber,
            this.toNumber,
            this.start_time,
            this.end_time});
            this.dgvImportCalls.Name = "dgvImportCalls";
            this.dgvImportCalls.RowHeadersVisible = false;
            this.dgvImportCalls.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // fromNumber
            // 
            resources.ApplyResources(this.fromNumber, "fromNumber");
            this.fromNumber.Name = "fromNumber";
            // 
            // toNumber
            // 
            resources.ApplyResources(this.toNumber, "toNumber");
            this.toNumber.Name = "toNumber";
            // 
            // start_time
            // 
            resources.ApplyResources(this.start_time, "start_time");
            this.start_time.Name = "start_time";
            // 
            // end_time
            // 
            resources.ApplyResources(this.end_time, "end_time");
            this.end_time.Name = "end_time";
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRnd
            // 
            resources.ApplyResources(this.btnRnd, "btnRnd");
            this.btnRnd.Name = "btnRnd";
            this.btnRnd.UseVisualStyleBackColor = true;
            this.btnRnd.Click += new System.EventHandler(this.btnRnd_Click);
            // 
            // FormCallsImport
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRnd);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvImportCalls);
            this.Controls.Add(this.btnOpenFile);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCallsImport";
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