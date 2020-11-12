namespace Fall2020_CSC403_Project
{
    partial class FrmNotWorthy
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnworthy1 = new System.Windows.Forms.Button();
            this.pichammer = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pichammer)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.lightningplayer;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(91, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 322);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label2.Location = new System.Drawing.Point(44, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "You are not Worthy!!!!!!!!";
            // 
            // btnworthy1
            // 
            this.btnworthy1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnworthy1.Location = new System.Drawing.Point(339, 475);
            this.btnworthy1.Name = "btnworthy1";
            this.btnworthy1.Size = new System.Drawing.Size(154, 44);
            this.btnworthy1.TabIndex = 3;
            this.btnworthy1.Text = "I am not Worthy";
            this.btnworthy1.UseVisualStyleBackColor = true;
            this.btnworthy1.Click += new System.EventHandler(this.btnworthy1_Click);
            // 
            // pichammer
            // 
            this.pichammer.BackColor = System.Drawing.Color.Transparent;
            this.pichammer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.hammer;
            this.pichammer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pichammer.Location = new System.Drawing.Point(522, 132);
            this.pichammer.Name = "pichammer";
            this.pichammer.Size = new System.Drawing.Size(223, 322);
            this.pichammer.TabIndex = 4;
            this.pichammer.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(496, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mjölnir has flown away.";
            // 
            // FrmNotWorthy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(822, 575);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pichammer);
            this.Controls.Add(this.btnworthy1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmNotWorthy";
            this.Text = "FrmNotWorthy";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pichammer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnworthy1;
        private System.Windows.Forms.PictureBox pichammer;
        private System.Windows.Forms.Label label1;
    }
}