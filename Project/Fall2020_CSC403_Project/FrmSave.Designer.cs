using Fall2020_CSC403_Project.code;
using System;

namespace Fall2020_CSC403_Project
{
    partial class FrmSave
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
            this.picgirl = new System.Windows.Forms.PictureBox();
            this.save_message = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picgirl)).BeginInit();
            this.SuspendLayout();
            // 
            // picgirl
            // 
            this.picgirl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picgirl.Image = global::Fall2020_CSC403_Project.Properties.Resources.girl1;
            this.picgirl.Location = new System.Drawing.Point(468, 141);
            this.picgirl.Name = "picgirl";
            this.picgirl.Size = new System.Drawing.Size(184, 373);
            this.picgirl.TabIndex = 0;
            this.picgirl.TabStop = false;
            // 
            // save_message
            // 
            this.save_message.AutoSize = true;
            this.save_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_message.Location = new System.Drawing.Point(213, 114);
            this.save_message.Name = "save_message";
            this.save_message.Size = new System.Drawing.Size(269, 31);
            this.save_message.TabIndex = 1;
            this.save_message.Text = "You saved me !!!!!!!";
            // 
            // FrmSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.HotPink;
            this.ClientSize = new System.Drawing.Size(822, 575);
            this.Controls.Add(this.save_message);
            this.Controls.Add(this.picgirl);
            this.Name = "FrmSave";
            this.Text = "FrmSave";
            ((System.ComponentModel.ISupportInitialize)(this.picgirl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picgirl;
        private System.Windows.Forms.Label save_message;
    }
}