﻿namespace Fall2020_CSC403_Project
{
    partial class FrmLevel_2
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
            this.picbat = new System.Windows.Forms.PictureBox();
            this.piccookie = new System.Windows.Forms.PictureBox();
            this.pictpotion2 = new System.Windows.Forms.PictureBox();
            this.picWall21 = new System.Windows.Forms.PictureBox();
            this.picWall20 = new System.Windows.Forms.PictureBox();
            this.picWall19 = new System.Windows.Forms.PictureBox();
            this.picWall18 = new System.Windows.Forms.PictureBox();
            this.picWall17 = new System.Windows.Forms.PictureBox();
            this.picWall15 = new System.Windows.Forms.PictureBox();
            this.picWall13 = new System.Windows.Forms.PictureBox();
            this.picWall16 = new System.Windows.Forms.PictureBox();
            this.picWall14 = new System.Windows.Forms.PictureBox();
            this.picPlayer2 = new System.Windows.Forms.PictureBox();
            this.lblInGameTime1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piccookie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictpotion2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).BeginInit();
            this.SuspendLayout();
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
           /* // 
            // lblInGameTime
            // 
            this.lblInGameTime.AutoSize = true;
            this.lblInGameTime.BackColor = System.Drawing.Color.Black;
            this.lblInGameTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInGameTime.ForeColor = System.Drawing.Color.White;
            this.lblInGameTime.Location = new System.Drawing.Point(12, 9);
            this.lblInGameTime.Name = "lblInGameTime";
            this.lblInGameTime.Size = new System.Drawing.Size(46, 18);
            this.lblInGameTime.TabIndex = 2;
            this.lblInGameTime.Text = "label1";
            this.lblInGameTime.Click += new System.EventHandler(this.lblInGameTime_Click);*/
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
            // picbat
            // 
            this.picbat.BackColor = System.Drawing.Color.Transparent;
            this.picbat.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.bat;
            this.picbat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbat.Location = new System.Drawing.Point(582, 525);
            this.picbat.Name = "picbat";
            this.picbat.Size = new System.Drawing.Size(128, 120);
            this.picbat.TabIndex = 12;
            this.picbat.TabStop = false;
            // 
            // piccookie
            // 
            this.piccookie.BackColor = System.Drawing.Color.Transparent;
            this.piccookie.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Cookie;
            this.piccookie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.piccookie.Location = new System.Drawing.Point(1011, 78);
            this.piccookie.Name = "piccookie";
            this.piccookie.Size = new System.Drawing.Size(135, 111);
            this.piccookie.TabIndex = 11;
            this.piccookie.TabStop = false;
            // 
            // pictpotion2
            // 
            this.pictpotion2.BackColor = System.Drawing.Color.Transparent;
            this.pictpotion2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.tpotion;
            this.pictpotion2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictpotion2.Location = new System.Drawing.Point(90, 69);
            this.pictpotion2.Name = "pictpotion2";
            this.pictpotion2.Size = new System.Drawing.Size(61, 59);
            this.pictpotion2.TabIndex = 9;
            this.pictpotion2.TabStop = false;
            // 
            // picWall21
            // 
            this.picWall21.BackColor = System.Drawing.Color.Transparent;
            this.picWall21.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall21.Location = new System.Drawing.Point(1092, 199);
            this.picWall21.Name = "picWall21";
            this.picWall21.Size = new System.Drawing.Size(79, 450);
            this.picWall21.TabIndex = 8;
            this.picWall21.TabStop = false;
            // 
            // picWall20
            // 
            this.picWall20.BackColor = System.Drawing.Color.Transparent;
            this.picWall20.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall20.Location = new System.Drawing.Point(909, 69);
            this.picWall20.Name = "picWall20";
            this.picWall20.Size = new System.Drawing.Size(79, 450);
            this.picWall20.TabIndex = 7;
            this.picWall20.TabStop = false;
            // 
            // picWall19
            // 
            this.picWall19.BackColor = System.Drawing.Color.Transparent;
            this.picWall19.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall19.Location = new System.Drawing.Point(716, 199);
            this.picWall19.Name = "picWall19";
            this.picWall19.Size = new System.Drawing.Size(79, 450);
            this.picWall19.TabIndex = 6;
            this.picWall19.TabStop = false;
            // 
            // picWall18
            // 
            this.picWall18.BackColor = System.Drawing.Color.Transparent;
            this.picWall18.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall18.Location = new System.Drawing.Point(530, 69);
            this.picWall18.Name = "picWall18";
            this.picWall18.Size = new System.Drawing.Size(79, 450);
            this.picWall18.TabIndex = 5;
            this.picWall18.TabStop = false;
            // 
            // picWall17
            // 
            this.picWall17.BackColor = System.Drawing.Color.Transparent;
            this.picWall17.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall17.Location = new System.Drawing.Point(345, 199);
            this.picWall17.Name = "picWall17";
            this.picWall17.Size = new System.Drawing.Size(79, 450);
            this.picWall17.TabIndex = 4;
            this.picWall17.TabStop = false;
            // 
            // picWall15
            // 
            this.picWall15.BackColor = System.Drawing.Color.Transparent;
            this.picWall15.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall15.Location = new System.Drawing.Point(167, 69);
            this.picWall15.Name = "picWall15";
            this.picWall15.Size = new System.Drawing.Size(79, 474);
            this.picWall15.TabIndex = 3;
            this.picWall15.TabStop = false;
            // 
            // picWall13
            // 
            this.picWall13.BackColor = System.Drawing.Color.Transparent;
            this.picWall13.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall13.Location = new System.Drawing.Point(0, 63);
            this.picWall13.Name = "picWall13";
            this.picWall13.Size = new System.Drawing.Size(74, 499);
            this.picWall13.TabIndex = 2;
            this.picWall13.TabStop = false;
            // 
            // picWall16
            // 
            this.picWall16.BackColor = System.Drawing.Color.Transparent;
            this.picWall16.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall16.Location = new System.Drawing.Point(144, 655);
            this.picWall16.Name = "picWall16";
            this.picWall16.Size = new System.Drawing.Size(1027, 76);
            this.picWall16.TabIndex = 1;
            this.picWall16.TabStop = false;
            // 
            // picWall14
            // 
            this.picWall14.BackColor = System.Drawing.Color.Transparent;
            this.picWall14.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall14.Location = new System.Drawing.Point(0, 0);
            this.picWall14.Name = "picWall14";
            this.picWall14.Size = new System.Drawing.Size(1171, 63);
            this.picWall14.TabIndex = 0;
            this.picWall14.TabStop = false;
            // 
            // picPlayer2
            // 
            this.picPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
            this.picPlayer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer2.Location = new System.Drawing.Point(12, 590);
            this.picPlayer2.Name = "picPlayer2";
            this.picPlayer2.Size = new System.Drawing.Size(54, 106);
            this.picPlayer2.TabIndex = 10;
            this.picPlayer2.TabStop = false;
            // 
            // FrmLevel_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1176, 726);
            this.Controls.Add(this.lblInGameTime1);
            this.Controls.Add(this.picbat);
            this.Controls.Add(this.piccookie);
            this.Controls.Add(this.pictpotion2);
            this.Controls.Add(this.picWall21);
            this.Controls.Add(this.picWall20);
            this.Controls.Add(this.picWall19);
            this.Controls.Add(this.picWall18);
            this.Controls.Add(this.picWall17);
            this.Controls.Add(this.picWall15);
            this.Controls.Add(this.picWall13);
            this.Controls.Add(this.picWall16);
            this.Controls.Add(this.picWall14);
            this.Controls.Add(this.picPlayer2);
            this.Name = "FrmLevel_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Explore";
            this.Load += new System.EventHandler(this.FrmLevel_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picbat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piccookie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictpotion2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblInGameTime;
        private System.Windows.Forms.Timer tmrUpdateInGameTime;
        private System.Windows.Forms.Timer tmrPlayerMove;
        private System.Windows.Forms.PictureBox picWall14;
        private System.Windows.Forms.PictureBox picWall16;
        private System.Windows.Forms.PictureBox picWall13;
        private System.Windows.Forms.PictureBox picWall15;
        private System.Windows.Forms.PictureBox picWall17;
        private System.Windows.Forms.PictureBox picWall18;
        private System.Windows.Forms.PictureBox picWall19;
        private System.Windows.Forms.PictureBox picWall20;
        private System.Windows.Forms.PictureBox picWall21;
        private System.Windows.Forms.PictureBox pictpotion2;
        private System.Windows.Forms.PictureBox picPlayer2;
        private System.Windows.Forms.PictureBox piccookie;
        private System.Windows.Forms.PictureBox picbat;
        private System.Windows.Forms.Label lblInGameTime1;
    }
}