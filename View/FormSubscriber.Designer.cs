namespace BillingSystem.View
{
    partial class FormSubscriber
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
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbPatronymic = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbPnones = new System.Windows.Forms.ListBox();
            this.btnAddNumber = new System.Windows.Forms.Button();
            this.btnEditNumber = new System.Windows.Forms.Button();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDeleteNumber = new System.Windows.Forms.Button();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPatronymic = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.gbSubscriberInf = new System.Windows.Forms.GroupBox();
            this.gbSubsPnones = new System.Windows.Forms.GroupBox();
            this.gbSubscriberInf.SuspendLayout();
            this.gbSubsPnones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSurname
            // 
            this.tbSurname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSurname.Location = new System.Drawing.Point(80, 26);
            this.tbSurname.MaximumSize = new System.Drawing.Size(150, 20);
            this.tbSurname.MinimumSize = new System.Drawing.Size(150, 20);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(150, 20);
            this.tbSurname.TabIndex = 7;
            // 
            // tbPatronymic
            // 
            this.tbPatronymic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPatronymic.Location = new System.Drawing.Point(80, 83);
            this.tbPatronymic.MaximumSize = new System.Drawing.Size(150, 20);
            this.tbPatronymic.MinimumSize = new System.Drawing.Size(150, 20);
            this.tbPatronymic.Name = "tbPatronymic";
            this.tbPatronymic.Size = new System.Drawing.Size(150, 20);
            this.tbPatronymic.TabIndex = 9;
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(80, 54);
            this.tbName.MaximumSize = new System.Drawing.Size(150, 20);
            this.tbName.MinimumSize = new System.Drawing.Size(150, 20);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(150, 20);
            this.tbName.TabIndex = 8;
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEmail.Location = new System.Drawing.Point(80, 141);
            this.tbEmail.MaximumSize = new System.Drawing.Size(150, 20);
            this.tbEmail.MinimumSize = new System.Drawing.Size(150, 20);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(150, 20);
            this.tbEmail.TabIndex = 11;
            // 
            // lbPnones
            // 
            this.lbPnones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPnones.FormattingEnabled = true;
            this.lbPnones.Location = new System.Drawing.Point(8, 19);
            this.lbPnones.Name = "lbPnones";
            this.lbPnones.Size = new System.Drawing.Size(164, 95);
            this.lbPnones.TabIndex = 12;
            // 
            // btnAddNumber
            // 
            this.btnAddNumber.Location = new System.Drawing.Point(8, 120);
            this.btnAddNumber.Name = "btnAddNumber";
            this.btnAddNumber.Size = new System.Drawing.Size(164, 23);
            this.btnAddNumber.TabIndex = 13;
            this.btnAddNumber.Text = "Добавить номер";
            this.btnAddNumber.UseVisualStyleBackColor = true;
            this.btnAddNumber.Click += new System.EventHandler(this.btnAddNumber_Click);
            // 
            // btnEditNumber
            // 
            this.btnEditNumber.Location = new System.Drawing.Point(8, 149);
            this.btnEditNumber.Name = "btnEditNumber";
            this.btnEditNumber.Size = new System.Drawing.Size(164, 23);
            this.btnEditNumber.TabIndex = 14;
            this.btnEditNumber.Text = "Изменить номер";
            this.btnEditNumber.UseVisualStyleBackColor = true;
            this.btnEditNumber.Click += new System.EventHandler(this.btnEditNumber_Click);
            // 
            // tbLogin
            // 
            this.tbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLogin.Location = new System.Drawing.Point(80, 112);
            this.tbLogin.MaximumSize = new System.Drawing.Size(150, 20);
            this.tbLogin.MinimumSize = new System.Drawing.Size(150, 20);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(150, 20);
            this.tbLogin.TabIndex = 10;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Location = new System.Drawing.Point(20, 176);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(210, 23);
            this.btnResetPassword.TabIndex = 16;
            this.btnResetPassword.Text = "Сбросить пароль";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(11, 239);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(252, 23);
            this.btnOK.TabIndex = 17;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(286, 239);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(185, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDeleteNumber
            // 
            this.btnDeleteNumber.Location = new System.Drawing.Point(8, 178);
            this.btnDeleteNumber.Name = "btnDeleteNumber";
            this.btnDeleteNumber.Size = new System.Drawing.Size(164, 23);
            this.btnDeleteNumber.TabIndex = 15;
            this.btnDeleteNumber.Text = "Удалить номер";
            this.btnDeleteNumber.UseVisualStyleBackColor = true;
            this.btnDeleteNumber.Click += new System.EventHandler(this.btnDeleteNumber_Click);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSurname.Location = new System.Drawing.Point(17, 29);
            this.lblSurname.MaximumSize = new System.Drawing.Size(63, 13);
            this.lblSurname.MinimumSize = new System.Drawing.Size(43, 13);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(59, 13);
            this.lblSurname.TabIndex = 20;
            this.lblSurname.Text = "Фамилия:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(17, 57);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(32, 13);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "Имя:";
            // 
            // lblPatronymic
            // 
            this.lblPatronymic.AutoSize = true;
            this.lblPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPatronymic.Location = new System.Drawing.Point(17, 86);
            this.lblPatronymic.Name = "lblPatronymic";
            this.lblPatronymic.Size = new System.Drawing.Size(57, 13);
            this.lblPatronymic.TabIndex = 22;
            this.lblPatronymic.Text = "Отчество:";
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLogin.Location = new System.Drawing.Point(17, 115);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(41, 13);
            this.lblLogin.TabIndex = 23;
            this.lblLogin.Text = "Логин:";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmail.Location = new System.Drawing.Point(17, 144);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 24;
            this.lblEmail.Text = "E-mail:";
            // 
            // gbSubscriberInf
            // 
            this.gbSubscriberInf.Controls.Add(this.lblSurname);
            this.gbSubscriberInf.Controls.Add(this.lblEmail);
            this.gbSubscriberInf.Controls.Add(this.tbName);
            this.gbSubscriberInf.Controls.Add(this.lblLogin);
            this.gbSubscriberInf.Controls.Add(this.btnResetPassword);
            this.gbSubscriberInf.Controls.Add(this.tbPatronymic);
            this.gbSubscriberInf.Controls.Add(this.lblPatronymic);
            this.gbSubscriberInf.Controls.Add(this.tbSurname);
            this.gbSubscriberInf.Controls.Add(this.lblName);
            this.gbSubscriberInf.Controls.Add(this.tbEmail);
            this.gbSubscriberInf.Controls.Add(this.tbLogin);
            this.gbSubscriberInf.Location = new System.Drawing.Point(12, 12);
            this.gbSubscriberInf.Name = "gbSubscriberInf";
            this.gbSubscriberInf.Size = new System.Drawing.Size(251, 214);
            this.gbSubscriberInf.TabIndex = 25;
            this.gbSubscriberInf.TabStop = false;
            this.gbSubscriberInf.Text = "Данные абонента";
            // 
            // gbSubsPnones
            // 
            this.gbSubsPnones.Controls.Add(this.lbPnones);
            this.gbSubsPnones.Controls.Add(this.btnAddNumber);
            this.gbSubsPnones.Controls.Add(this.btnDeleteNumber);
            this.gbSubsPnones.Controls.Add(this.btnEditNumber);
            this.gbSubsPnones.Location = new System.Drawing.Point(278, 15);
            this.gbSubsPnones.Name = "gbSubsPnones";
            this.gbSubsPnones.Size = new System.Drawing.Size(193, 211);
            this.gbSubsPnones.TabIndex = 26;
            this.gbSubsPnones.TabStop = false;
            this.gbSubsPnones.Text = "Телефонные номера абонента";
            // 
            // FormSubscriber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 276);
            this.Controls.Add(this.gbSubsPnones);
            this.Controls.Add(this.gbSubscriberInf);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(499, 314);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(499, 314);
            this.Name = "FormSubscriber";
            this.gbSubscriberInf.ResumeLayout(false);
            this.gbSubscriberInf.PerformLayout();
            this.gbSubsPnones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbPatronymic;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.ListBox lbPnones;
        private System.Windows.Forms.Button btnAddNumber;
        private System.Windows.Forms.Button btnEditNumber;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDeleteNumber;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPatronymic;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.GroupBox gbSubscriberInf;
        private System.Windows.Forms.GroupBox gbSubsPnones;
    }
}