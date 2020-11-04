using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;


namespace Fall2020_CSC403_Project
{

    public partial class FrmPick_UP
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

        
        {
          private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Pick_Up = new System.Windows.Forms.Button();
            this.picPotion = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            this.SuspendLayout();

            // 
            // btnAttack
            // 
            this.Pick_Up.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pick_Up.Location = new System.Drawing.Point(127, 422);
            this.Pick_Up.Name = "Pick Up";
            this.Pick_Up.Size = new System.Drawing.Size(128, 43);
            this.Pick_Up.TabIndex = 2;
            this.Pick_Up.Text = "Pick Up";
            this.Pick_Up.UseVisualStyleBackColor = true;
            this.Pick_Up.Click += new System.EventHandler(this.Pick_Up_Click);
        }
    }
}