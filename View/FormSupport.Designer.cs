namespace BillingSystem.View
{
    partial class FormSupport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSupport));
            this.lblProgramName = new System.Windows.Forms.Label();
            this.lblCopyrights = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbAboutContent = new System.Windows.Forms.TextBox();
            this.lnklblEmail1 = new System.Windows.Forms.LinkLabel();
            this.lnllblEmail2 = new System.Windows.Forms.LinkLabel();
            this.lnklblEmail3 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProgramName
            // 
            this.lblProgramName.AutoSize = true;
            this.lblProgramName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProgramName.Location = new System.Drawing.Point(137, 12);
            this.lblProgramName.Name = "lblProgramName";
            this.lblProgramName.Size = new System.Drawing.Size(194, 25);
            this.lblProgramName.TabIndex = 1;
            this.lblProgramName.Text = "BillingSystem 1.0";
            // 
            // lblCopyrights
            // 
            this.lblCopyrights.AutoSize = true;
            this.lblCopyrights.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCopyrights.Location = new System.Drawing.Point(142, 37);
            this.lblCopyrights.Name = "lblCopyrights";
            this.lblCopyrights.Size = new System.Drawing.Size(71, 16);
            this.lblCopyrights.TabIndex = 2;
            this.lblCopyrights.Text = "© ФКН, 2012";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tbAboutContent
            // 
            this.tbAboutContent.BackColor = System.Drawing.Color.White;
            this.tbAboutContent.Enabled = false;
            this.tbAboutContent.ForeColor = System.Drawing.Color.Black;
            this.tbAboutContent.Location = new System.Drawing.Point(21, 156);
            this.tbAboutContent.Multiline = true;
            this.tbAboutContent.Name = "tbAboutContent";
            this.tbAboutContent.ReadOnly = true;
            this.tbAboutContent.Size = new System.Drawing.Size(330, 120);
            this.tbAboutContent.TabIndex = 4;
            this.tbAboutContent.Text = resources.GetString("tbAboutContent.Text");
            // 
            // lnklblEmail1
            // 
            this.lnklblEmail1.AutoSize = true;
            this.lnklblEmail1.Location = new System.Drawing.Point(142, 63);
            this.lnklblEmail1.Name = "lnklblEmail1";
            this.lnklblEmail1.Size = new System.Drawing.Size(119, 13);
            this.lnklblEmail1.TabIndex = 5;
            this.lnklblEmail1.TabStop = true;
            this.lnklblEmail1.Text = "a.o.donskih@yandex.ru";
            // 
            // lnllblEmail2
            // 
            this.lnllblEmail2.AutoSize = true;
            this.lnllblEmail2.Location = new System.Drawing.Point(142, 83);
            this.lnllblEmail2.Name = "lnllblEmail2";
            this.lnllblEmail2.Size = new System.Drawing.Size(117, 13);
            this.lnllblEmail2.TabIndex = 6;
            this.lnllblEmail2.TabStop = true;
            this.lnllblEmail2.Text = "andrew.fkn@yandex.ru";
            // 
            // lnklblEmail3
            // 
            this.lnklblEmail3.AutoSize = true;
            this.lnklblEmail3.Location = new System.Drawing.Point(142, 104);
            this.lnklblEmail3.Name = "lnklblEmail3";
            this.lnklblEmail3.Size = new System.Drawing.Size(105, 13);
            this.lnklblEmail3.TabIndex = 7;
            this.lnklblEmail3.TabStop = true;
            this.lnklblEmail3.Text = "vragovR@yandex.ru";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Сведения о продукте:";
            // 
            // FormSupport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 292);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lnklblEmail3);
            this.Controls.Add(this.lnllblEmail2);
            this.Controls.Add(this.lnklblEmail1);
            this.Controls.Add(this.tbAboutContent);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCopyrights);
            this.Controls.Add(this.lblProgramName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(383, 330);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(383, 330);
            this.Name = "FormSupport";
            this.Text = "О программе BillingSystem";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProgramName;
        private System.Windows.Forms.Label lblCopyrights;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbAboutContent;
        private System.Windows.Forms.LinkLabel lnklblEmail1;
        private System.Windows.Forms.LinkLabel lnllblEmail2;
        private System.Windows.Forms.LinkLabel lnklblEmail3;
        private System.Windows.Forms.Label label1;
    }
}