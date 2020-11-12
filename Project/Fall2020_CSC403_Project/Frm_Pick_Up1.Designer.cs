namespace Fall2020_CSC403_Project
{
    partial class Frm_Pick_Up1
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
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picItem1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.picItem2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
            this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer.Location = new System.Drawing.Point(91, 139);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(219, 231);
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // picItem1
            // 
            this.picItem1.BackColor = System.Drawing.Color.Transparent;
            this.picItem1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.potion;
            this.picItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picItem1.Location = new System.Drawing.Point(534, 139);
            this.picItem1.Name = "picItem1";
            this.picItem1.Size = new System.Drawing.Size(219, 231);
            this.picItem1.TabIndex = 1;
            this.picItem1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(125, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "Trade";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Pick_Up_Click);
            // 
            // picItem2
            // 
            this.picItem2.BackColor = System.Drawing.Color.Transparent;
            this.picItem2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.potion;
            this.picItem2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picItem2.Location = new System.Drawing.Point(837, 139);
            this.picItem2.Name = "picItem2";
            this.picItem2.Size = new System.Drawing.Size(219, 231);
            this.picItem2.TabIndex = 3;
            this.picItem2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(672, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "You can only hold one weapon.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(531, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Current item held";
            // 
            // Frm_Pick_Up1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1178, 602);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picItem2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picItem1);
            this.Controls.Add(this.picPlayer);
            this.Name = "Frm_Pick_Up1";
            this.Text = "Frm_Pick_Up1";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
            this.Load += new System.EventHandler(this.Frm_Pick_Up1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void InitializeComponent1()
        {
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picItem1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
            this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer.Location = new System.Drawing.Point(91, 139);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(219, 231);
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // picPotion
            // 
            this.picItem1.BackColor = System.Drawing.Color.Transparent;
            this.picItem1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.potion;
            this.picItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picItem1.Location = new System.Drawing.Point(713, 139);
            this.picItem1.Name = "picPotion";
            this.picItem1.Size = new System.Drawing.Size(219, 231);
            this.picItem1.TabIndex = 1;
            this.picItem1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(125, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pick Up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Pick_Up_Click);
            // 
            // Frm_Pick_Up1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1178, 602);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picItem1);
            this.Controls.Add(this.picPlayer);
            this.Name = "Frm_Pick_Up1";
            this.Text = "Frm_Pick_Up1";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picItem1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picItem2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}