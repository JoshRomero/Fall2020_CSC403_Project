namespace Fall2020_CSC403_Project
{
    partial class FrmLevel_0
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
            this.components = new System.ComponentModel.Container();
            this.lblInGameTime = new System.Windows.Forms.Label();
            this.tmrPlayerMove = new System.Windows.Forms.Timer(this.components);
            this.tmrUpdateInGameTime = new System.Windows.Forms.Timer(this.components);
            this.lblInGameTime1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picdarkwall4 = new System.Windows.Forms.PictureBox();
            this.picdarkwall5 = new System.Windows.Forms.PictureBox();
            this.picgirl = new System.Windows.Forms.PictureBox();
            this.picBossKoolAid = new System.Windows.Forms.PictureBox();
            this.picdarkwall3 = new System.Windows.Forms.PictureBox();
            this.picdarkwall2 = new System.Windows.Forms.PictureBox();
            this.picPlayer0 = new System.Windows.Forms.PictureBox();
            this.picdarkwall1 = new System.Windows.Forms.PictureBox();
            this.picdarkwall0 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picdarkwall4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picdarkwall5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picgirl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossKoolAid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picdarkwall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picdarkwall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picdarkwall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picdarkwall0)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInGameTime
            // 
            this.lblInGameTime.Location = new System.Drawing.Point(0, 0);
            this.lblInGameTime.Name = "lblInGameTime";
            this.lblInGameTime.Size = new System.Drawing.Size(100, 23);
            this.lblInGameTime.TabIndex = 0;
            // 
            // tmrPlayerMove
            // 
            this.tmrPlayerMove.Enabled = true;
            this.tmrPlayerMove.Interval = 10;
            this.tmrPlayerMove.Tick += new System.EventHandler(this.tmrPlayerMove_Tick);
            // 
            // tmrUpdateInGameTime
            // 
            this.tmrUpdateInGameTime.Enabled = true;
            this.tmrUpdateInGameTime.Tick += new System.EventHandler(this.tmrUpdateInGameTime_Tick);
            // 
            // lblInGameTime1
            // 
            this.lblInGameTime1.AutoSize = true;
            this.lblInGameTime1.BackColor = System.Drawing.Color.Black;
            this.lblInGameTime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInGameTime1.ForeColor = System.Drawing.Color.White;
            this.lblInGameTime1.Location = new System.Drawing.Point(12, 9);
            this.lblInGameTime1.Name = "lblInGameTime1";
            this.lblInGameTime1.Size = new System.Drawing.Size(46, 18);
            this.lblInGameTime1.TabIndex = 13;
            this.lblInGameTime1.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(33, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Help me !!!!!";
            // 
            // picdarkwall4
            // 
            this.picdarkwall4.BackColor = System.Drawing.Color.Transparent;
            this.picdarkwall4.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.darkwall;
            this.picdarkwall4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picdarkwall4.Location = new System.Drawing.Point(-5, 447);
            this.picdarkwall4.Name = "picdarkwall4";
            this.picdarkwall4.Size = new System.Drawing.Size(344, 267);
            this.picdarkwall4.TabIndex = 9;
            this.picdarkwall4.TabStop = false;
            // 
            // picdarkwall5
            // 
            this.picdarkwall5.BackColor = System.Drawing.Color.Transparent;
            this.picdarkwall5.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.darkwall;
            this.picdarkwall5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picdarkwall5.Location = new System.Drawing.Point(-5, -1);
            this.picdarkwall5.Name = "picdarkwall5";
            this.picdarkwall5.Size = new System.Drawing.Size(344, 229);
            this.picdarkwall5.TabIndex = 8;
            this.picdarkwall5.TabStop = false;
            // 
            // picgirl
            // 
            this.picgirl.BackColor = System.Drawing.Color.Transparent;
            this.picgirl.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.girl1;
            this.picgirl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picgirl.Location = new System.Drawing.Point(69, 332);
            this.picgirl.Name = "picgirl";
            this.picgirl.Size = new System.Drawing.Size(44, 75);
            this.picgirl.TabIndex = 6;
            this.picgirl.TabStop = false;
            // 
            // picBossKoolAid
            // 
            this.picBossKoolAid.BackColor = System.Drawing.Color.Transparent;
            this.picBossKoolAid.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_koolaid;
            this.picBossKoolAid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBossKoolAid.Location = new System.Drawing.Point(146, 247);
            this.picBossKoolAid.Name = "picBossKoolAid";
            this.picBossKoolAid.Size = new System.Drawing.Size(193, 194);
            this.picBossKoolAid.TabIndex = 5;
            this.picBossKoolAid.TabStop = false;
            // 
            // picdarkwall3
            // 
            this.picdarkwall3.BackColor = System.Drawing.Color.Transparent;
            this.picdarkwall3.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.darkwall;
            this.picdarkwall3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picdarkwall3.Location = new System.Drawing.Point(354, 12);
            this.picdarkwall3.Name = "picdarkwall3";
            this.picdarkwall3.Size = new System.Drawing.Size(254, 263);
            this.picdarkwall3.TabIndex = 4;
            this.picdarkwall3.TabStop = false;
            // 
            // picdarkwall2
            // 
            this.picdarkwall2.BackColor = System.Drawing.Color.Transparent;
            this.picdarkwall2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.darkwall;
            this.picdarkwall2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picdarkwall2.Location = new System.Drawing.Point(354, 393);
            this.picdarkwall2.Name = "picdarkwall2";
            this.picdarkwall2.Size = new System.Drawing.Size(254, 321);
            this.picdarkwall2.TabIndex = 3;
            this.picdarkwall2.TabStop = false;
            // 
            // picPlayer0
            // 
            this.picPlayer0.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer0.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
            this.picPlayer0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer0.Location = new System.Drawing.Point(1043, 281);
            this.picPlayer0.Name = "picPlayer0";
            this.picPlayer0.Size = new System.Drawing.Size(54, 106);
            this.picPlayer0.TabIndex = 2;
            this.picPlayer0.TabStop = false;
            // 
            // picdarkwall1
            // 
            this.picdarkwall1.BackColor = System.Drawing.Color.Transparent;
            this.picdarkwall1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.darkwall;
            this.picdarkwall1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picdarkwall1.Location = new System.Drawing.Point(614, 196);
            this.picdarkwall1.Name = "picdarkwall1";
            this.picdarkwall1.Size = new System.Drawing.Size(483, 79);
            this.picdarkwall1.TabIndex = 1;
            this.picdarkwall1.TabStop = false;
            // 
            // picdarkwall0
            // 
            this.picdarkwall0.BackColor = System.Drawing.Color.Transparent;
            this.picdarkwall0.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.darkwall;
            this.picdarkwall0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picdarkwall0.Location = new System.Drawing.Point(614, 393);
            this.picdarkwall0.Name = "picdarkwall0";
            this.picdarkwall0.Size = new System.Drawing.Size(483, 91);
            this.picdarkwall0.TabIndex = 0;
            this.picdarkwall0.TabStop = false;
            // 
            // FrmLevel_0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1176, 726);
            this.Controls.Add(this.picdarkwall4);
            this.Controls.Add(this.picdarkwall5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picgirl);
            this.Controls.Add(this.picBossKoolAid);
            this.Controls.Add(this.picdarkwall3);
            this.Controls.Add(this.picdarkwall2);
            this.Controls.Add(this.picdarkwall1);
            this.Controls.Add(this.picdarkwall0);
            this.Controls.Add(this.picPlayer0);
            this.Name = "FrmLevel_0";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Explore";
            this.Load += new System.EventHandler(this.FrmLevel_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picdarkwall4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picdarkwall5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picgirl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossKoolAid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picdarkwall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picdarkwall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picdarkwall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picdarkwall0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblInGameTime;
        private System.Windows.Forms.Timer tmrUpdateInGameTime;
        private System.Windows.Forms.Timer tmrPlayerMove;
        private System.Windows.Forms.Label lblInGameTime1;
        private System.Windows.Forms.PictureBox picdarkwall0;
        private System.Windows.Forms.PictureBox picdarkwall1;
        private System.Windows.Forms.PictureBox picPlayer0;
        private System.Windows.Forms.PictureBox picdarkwall2;
        private System.Windows.Forms.PictureBox picdarkwall3;
        private System.Windows.Forms.PictureBox picBossKoolAid;
        private System.Windows.Forms.PictureBox picgirl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picdarkwall5;
        private System.Windows.Forms.PictureBox picdarkwall4;
    }
}