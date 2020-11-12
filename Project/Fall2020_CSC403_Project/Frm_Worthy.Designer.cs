namespace Fall2020_CSC403_Project
{
    partial class Frm_Worthy
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnworthy = new System.Windows.Forms.Button();
            this.WorthyPN = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.WorthyPN)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(25, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "You are Worthy!!!!!!!!";
            // 
            // btnworthy
            // 
            this.btnworthy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnworthy.Location = new System.Drawing.Point(331, 464);
            this.btnworthy.Name = "btnworthy";
            this.btnworthy.Size = new System.Drawing.Size(132, 44);
            this.btnworthy.TabIndex = 2;
            this.btnworthy.Text = "I am Worthy";
            this.btnworthy.UseVisualStyleBackColor = true;
            this.btnworthy.Click += new System.EventHandler(this.btnworthy_Click);
            // 
            // WorthyPN
            // 
            this.WorthyPN.BackColor = System.Drawing.Color.Transparent;
            this.WorthyPN.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.lightningplayer;
            this.WorthyPN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WorthyPN.Location = new System.Drawing.Point(279, 110);
            this.WorthyPN.Name = "WorthyPN";
            this.WorthyPN.Size = new System.Drawing.Size(223, 322);
            this.WorthyPN.TabIndex = 0;
            this.WorthyPN.TabStop = false;
            // 
            // Frm_Worthy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(822, 575);
            this.Controls.Add(this.btnworthy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WorthyPN);
            this.Name = "Frm_Worthy";
            this.Text = "Frmworthy";
            ((System.ComponentModel.ISupportInitialize)(this.WorthyPN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox WorthyPN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnworthy;
    }
}