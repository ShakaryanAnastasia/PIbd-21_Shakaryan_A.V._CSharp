﻿namespace Lab_2
{
    partial class FormParking
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.groupBoxParking = new System.Windows.Forms.GroupBox();
            this.pictureBoxPlace = new System.Windows.Forms.PictureBox();
            this.buttonPlace = new System.Windows.Forms.Button();
            this.maskedTextBoxPlace = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.listBoxLevel = new System.Windows.Forms.ListBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.labelLavel = new System.Windows.Forms.Label();
            this.buttonAddTransport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBoxParking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlace)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(1149, 785);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // groupBoxParking
            // 
            this.groupBoxParking.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBoxParking.Controls.Add(this.pictureBoxPlace);
            this.groupBoxParking.Controls.Add(this.buttonPlace);
            this.groupBoxParking.Controls.Add(this.maskedTextBoxPlace);
            this.groupBoxParking.Controls.Add(this.labelPlace);
            this.groupBoxParking.Location = new System.Drawing.Point(1183, 441);
            this.groupBoxParking.Name = "groupBoxParking";
            this.groupBoxParking.Size = new System.Drawing.Size(200, 332);
            this.groupBoxParking.TabIndex = 1;
            this.groupBoxParking.TabStop = false;
            this.groupBoxParking.Text = "Забрать автобус";
            // 
            // pictureBoxPlace
            // 
            this.pictureBoxPlace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPlace.Location = new System.Drawing.Point(18, 176);
            this.pictureBoxPlace.Name = "pictureBoxPlace";
            this.pictureBoxPlace.Size = new System.Drawing.Size(151, 140);
            this.pictureBoxPlace.TabIndex = 3;
            this.pictureBoxPlace.TabStop = false;
            // 
            // buttonPlace
            // 
            this.buttonPlace.Location = new System.Drawing.Point(18, 126);
            this.buttonPlace.Name = "buttonPlace";
            this.buttonPlace.Size = new System.Drawing.Size(83, 29);
            this.buttonPlace.TabIndex = 2;
            this.buttonPlace.Text = "Забрать";
            this.buttonPlace.UseVisualStyleBackColor = true;
            this.buttonPlace.Click += new System.EventHandler(this.buttonPlace_Click);
            // 
            // maskedTextBoxPlace
            // 
            this.maskedTextBoxPlace.Location = new System.Drawing.Point(84, 84);
            this.maskedTextBoxPlace.Name = "maskedTextBoxPlace";
            this.maskedTextBoxPlace.Size = new System.Drawing.Size(49, 22);
            this.maskedTextBoxPlace.TabIndex = 1;
            // 
            // labelPlace
            // 
            this.labelPlace.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(15, 89);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(53, 17);
            this.labelPlace.TabIndex = 0;
            this.labelPlace.Text = "Место:";
            // 
            // listBoxLevel
            // 
            this.listBoxLevel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listBoxLevel.FormattingEnabled = true;
            this.listBoxLevel.ItemHeight = 16;
            this.listBoxLevel.Location = new System.Drawing.Point(1165, 53);
            this.listBoxLevel.Name = "listBoxLevel";
            this.listBoxLevel.Size = new System.Drawing.Size(151, 180);
            this.listBoxLevel.TabIndex = 8;
            this.listBoxLevel.Click += new System.EventHandler(this.listBoxLevels_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // labelLavel
            // 
            this.labelLavel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelLavel.AutoSize = true;
            this.labelLavel.Location = new System.Drawing.Point(1162, 18);
            this.labelLavel.Name = "labelLavel";
            this.labelLavel.Size = new System.Drawing.Size(56, 17);
            this.labelLavel.TabIndex = 9;
            this.labelLavel.Text = "Уровни";
            // 
            // buttonAddTransport
            // 
            this.buttonAddTransport.Location = new System.Drawing.Point(1180, 272);
            this.buttonAddTransport.Name = "buttonAddTransport";
            this.buttonAddTransport.Size = new System.Drawing.Size(184, 34);
            this.buttonAddTransport.TabIndex = 10;
            this.buttonAddTransport.Text = "Добавить транспорт";
            this.buttonAddTransport.UseVisualStyleBackColor = true;
            this.buttonAddTransport.Click += new System.EventHandler(this.buttonSetBus_Click);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 785);
            this.Controls.Add(this.buttonAddTransport);
            this.Controls.Add(this.labelLavel);
            this.Controls.Add(this.listBoxLevel);
            this.Controls.Add(this.groupBoxParking);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.Text = "Parking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBoxParking.ResumeLayout(false);
            this.groupBoxParking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.GroupBox groupBoxParking;
        private System.Windows.Forms.Button buttonPlace;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlace;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.PictureBox pictureBoxPlace;
        private System.Windows.Forms.ListBox listBoxLevel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label labelLavel;
        private System.Windows.Forms.Button buttonAddTransport;
    }
}