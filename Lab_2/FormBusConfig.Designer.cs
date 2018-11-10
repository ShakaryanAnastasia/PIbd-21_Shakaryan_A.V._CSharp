namespace Lab_2
{
    partial class FormBusConfig
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
            this.pictureBoxTransport = new System.Windows.Forms.PictureBox();
            this.groupBoxTransport = new System.Windows.Forms.GroupBox();
            this.labelBus = new System.Windows.Forms.Label();
            this.labelTroll = new System.Windows.Forms.Label();
            this.panelTransport = new System.Windows.Forms.Panel();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.labelBaseColor = new System.Windows.Forms.Label();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.panelBlueViolet = new System.Windows.Forms.Panel();
            this.panelTurquoise = new System.Windows.Forms.Panel();
            this.panelAquamarine = new System.Windows.Forms.Panel();
            this.panelActiveBorder = new System.Windows.Forms.Panel();
            this.panelMediumVioletRed = new System.Windows.Forms.Panel();
            this.panelDarkViolet = new System.Windows.Forms.Panel();
            this.panelLightBlue = new System.Windows.Forms.Panel();
            this.panelLightCoral = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTransport)).BeginInit();
            this.groupBoxTransport.SuspendLayout();
            this.panelTransport.SuspendLayout();
            this.groupBoxColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxTransport
            // 
            this.pictureBoxTransport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxTransport.Location = new System.Drawing.Point(31, 27);
            this.pictureBoxTransport.Name = "pictureBoxTransport";
            this.pictureBoxTransport.Size = new System.Drawing.Size(200, 165);
            this.pictureBoxTransport.TabIndex = 0;
            this.pictureBoxTransport.TabStop = false;
            // 
            // groupBoxTransport
            // 
            this.groupBoxTransport.Controls.Add(this.labelTroll);
            this.groupBoxTransport.Controls.Add(this.labelBus);
            this.groupBoxTransport.Location = new System.Drawing.Point(39, 37);
            this.groupBoxTransport.Name = "groupBoxTransport";
            this.groupBoxTransport.Size = new System.Drawing.Size(246, 250);
            this.groupBoxTransport.TabIndex = 1;
            this.groupBoxTransport.TabStop = false;
            this.groupBoxTransport.Text = "Тип транспорта";
            // 
            // labelBus
            // 
            this.labelBus.AllowDrop = true;
            this.labelBus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBus.Location = new System.Drawing.Point(30, 70);
            this.labelBus.Name = "labelBus";
            this.labelBus.Size = new System.Drawing.Size(194, 55);
            this.labelBus.TabIndex = 0;
            this.labelBus.Text = "Автобус";
            this.labelBus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelBus_MouseDown);
            // 
            // labelTroll
            // 
            this.labelTroll.AllowDrop = true;
            this.labelTroll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTroll.Location = new System.Drawing.Point(30, 165);
            this.labelTroll.Name = "labelTroll";
            this.labelTroll.Size = new System.Drawing.Size(194, 56);
            this.labelTroll.TabIndex = 1;
            this.labelTroll.Text = "Троллейбус";
            this.labelTroll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTroll.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTrolleybus_MouseDown);
            // 
            // panelTransport
            // 
            this.panelTransport.AllowDrop = true;
            this.panelTransport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTransport.Controls.Add(this.pictureBoxTransport);
            this.panelTransport.Location = new System.Drawing.Point(338, 19);
            this.panelTransport.Name = "panelTransport";
            this.panelTransport.Size = new System.Drawing.Size(268, 311);
            this.panelTransport.TabIndex = 2;
            this.panelTransport.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelTransport_DragDrop);
            this.panelTransport.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelTransport_DragEnter);
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.panelLightCoral);
            this.groupBoxColor.Controls.Add(this.panelLightBlue);
            this.groupBoxColor.Controls.Add(this.panelDarkViolet);
            this.groupBoxColor.Controls.Add(this.panelMediumVioletRed);
            this.groupBoxColor.Controls.Add(this.panelActiveBorder);
            this.groupBoxColor.Controls.Add(this.panelAquamarine);
            this.groupBoxColor.Controls.Add(this.panelTurquoise);
            this.groupBoxColor.Controls.Add(this.panelBlueViolet);
            this.groupBoxColor.Location = new System.Drawing.Point(649, 36);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(206, 286);
            this.groupBoxColor.TabIndex = 3;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Цвета";
            // 
            // labelBaseColor
            // 
            this.labelBaseColor.AllowDrop = true;
            this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseColor.Location = new System.Drawing.Point(373, 246);
            this.labelBaseColor.Name = "labelBaseColor";
            this.labelBaseColor.Size = new System.Drawing.Size(206, 29);
            this.labelBaseColor.TabIndex = 4;
            this.labelBaseColor.Text = "Основной цвет";
            this.labelBaseColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(373, 296);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(205, 26);
            this.labelDopColor.TabIndex = 5;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // panelBlueViolet
            // 
            this.panelBlueViolet.BackColor = System.Drawing.Color.BlueViolet;
            this.panelBlueViolet.Location = new System.Drawing.Point(32, 37);
            this.panelBlueViolet.Name = "panelBlueViolet";
            this.panelBlueViolet.Size = new System.Drawing.Size(52, 49);
            this.panelBlueViolet.TabIndex = 6;
            this.panelBlueViolet.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelTurquoise
            // 
            this.panelTurquoise.BackColor = System.Drawing.Color.Turquoise;
            this.panelTurquoise.Location = new System.Drawing.Point(32, 92);
            this.panelTurquoise.Name = "panelTurquoise";
            this.panelTurquoise.Size = new System.Drawing.Size(52, 49);
            this.panelTurquoise.TabIndex = 7;
            this.panelTurquoise.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelAquamarine
            // 
            this.panelAquamarine.BackColor = System.Drawing.Color.Aquamarine;
            this.panelAquamarine.Location = new System.Drawing.Point(32, 147);
            this.panelAquamarine.Name = "panelAquamarine";
            this.panelAquamarine.Size = new System.Drawing.Size(52, 49);
            this.panelAquamarine.TabIndex = 7;
            this.panelAquamarine.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelActiveBorder
            // 
            this.panelActiveBorder.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelActiveBorder.Location = new System.Drawing.Point(32, 202);
            this.panelActiveBorder.Name = "panelActiveBorder";
            this.panelActiveBorder.Size = new System.Drawing.Size(52, 49);
            this.panelActiveBorder.TabIndex = 7;
            this.panelActiveBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelMediumVioletRed
            // 
            this.panelMediumVioletRed.BackColor = System.Drawing.Color.MediumVioletRed;
            this.panelMediumVioletRed.Location = new System.Drawing.Point(127, 37);
            this.panelMediumVioletRed.Name = "panelMediumVioletRed";
            this.panelMediumVioletRed.Size = new System.Drawing.Size(52, 49);
            this.panelMediumVioletRed.TabIndex = 7;
            this.panelMediumVioletRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelDarkViolet
            // 
            this.panelDarkViolet.BackColor = System.Drawing.Color.DarkViolet;
            this.panelDarkViolet.Location = new System.Drawing.Point(127, 92);
            this.panelDarkViolet.Name = "panelDarkViolet";
            this.panelDarkViolet.Size = new System.Drawing.Size(52, 49);
            this.panelDarkViolet.TabIndex = 7;
            this.panelDarkViolet.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelLightBlue
            // 
            this.panelLightBlue.BackColor = System.Drawing.Color.LightBlue;
            this.panelLightBlue.Location = new System.Drawing.Point(127, 147);
            this.panelLightBlue.Name = "panelLightBlue";
            this.panelLightBlue.Size = new System.Drawing.Size(52, 49);
            this.panelLightBlue.TabIndex = 7;
            this.panelLightBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelLightCoral
            // 
            this.panelLightCoral.BackColor = System.Drawing.Color.LightCoral;
            this.panelLightCoral.Location = new System.Drawing.Point(127, 202);
            this.panelLightCoral.Name = "panelLightCoral";
            this.panelLightCoral.Size = new System.Drawing.Size(52, 49);
            this.panelLightCoral.TabIndex = 7;
            this.panelLightCoral.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(39, 296);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(111, 34);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(177, 338);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(107, 31);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormBusConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 401);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelDopColor);
            this.Controls.Add(this.labelBaseColor);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.panelTransport);
            this.Controls.Add(this.groupBoxTransport);
            this.Name = "FormBusConfig";
            this.Text = "FormBusConfig";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTransport)).EndInit();
            this.groupBoxTransport.ResumeLayout(false);
            this.panelTransport.ResumeLayout(false);
            this.groupBoxColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTransport;
        private System.Windows.Forms.GroupBox groupBoxTransport;
        private System.Windows.Forms.Label labelTroll;
        private System.Windows.Forms.Label labelBus;
        private System.Windows.Forms.Panel panelTransport;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.Panel panelLightCoral;
        private System.Windows.Forms.Panel panelLightBlue;
        private System.Windows.Forms.Panel panelDarkViolet;
        private System.Windows.Forms.Panel panelMediumVioletRed;
        private System.Windows.Forms.Panel panelActiveBorder;
        private System.Windows.Forms.Panel panelAquamarine;
        private System.Windows.Forms.Panel panelTurquoise;
        private System.Windows.Forms.Panel panelBlueViolet;
        private System.Windows.Forms.Label labelBaseColor;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
    }
}