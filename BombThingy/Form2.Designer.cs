namespace BombThingy
{
    partial class InitForm
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
            this.SerialBox = new System.Windows.Forms.TextBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BatteryBox = new System.Windows.Forms.TextBox();
            this.HolderBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PlateLabel = new System.Windows.Forms.Label();
            this.btnAddPlate = new System.Windows.Forms.Button();
            this.PortsBox = new System.Windows.Forms.ListBox();
            this.btnStereoRCA = new System.Windows.Forms.Button();
            this.btnSerial = new System.Windows.Forms.Button();
            this.btnRJ45 = new System.Windows.Forms.Button();
            this.btnPS2 = new System.Windows.Forms.Button();
            this.btnParallel = new System.Windows.Forms.Button();
            this.btnDVID = new System.Windows.Forms.Button();
            this.IndicatorBox = new System.Windows.Forms.ListBox();
            this.IndicatorTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddLit = new System.Windows.Forms.Button();
            this.btnAddUnlit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SerialNumber";
            // 
            // SerialBox
            // 
            this.SerialBox.Location = new System.Drawing.Point(168, 41);
            this.SerialBox.Name = "SerialBox";
            this.SerialBox.Size = new System.Drawing.Size(100, 20);
            this.SerialBox.TabIndex = 1;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(361, 402);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 2;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Batteries";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Holders";
            // 
            // BatteryBox
            // 
            this.BatteryBox.Location = new System.Drawing.Point(126, 82);
            this.BatteryBox.Name = "BatteryBox";
            this.BatteryBox.Size = new System.Drawing.Size(100, 20);
            this.BatteryBox.TabIndex = 5;
            // 
            // HolderBox
            // 
            this.HolderBox.Location = new System.Drawing.Point(317, 82);
            this.HolderBox.Name = "HolderBox";
            this.HolderBox.Size = new System.Drawing.Size(100, 20);
            this.HolderBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(649, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Number of Port plates:";
            // 
            // PlateLabel
            // 
            this.PlateLabel.AutoSize = true;
            this.PlateLabel.Location = new System.Drawing.Point(768, 40);
            this.PlateLabel.Name = "PlateLabel";
            this.PlateLabel.Size = new System.Drawing.Size(29, 13);
            this.PlateLabel.TabIndex = 8;
            this.PlateLabel.Text = "NaN";
            // 
            // btnAddPlate
            // 
            this.btnAddPlate.Location = new System.Drawing.Point(652, 75);
            this.btnAddPlate.Name = "btnAddPlate";
            this.btnAddPlate.Size = new System.Drawing.Size(75, 23);
            this.btnAddPlate.TabIndex = 9;
            this.btnAddPlate.Text = "Add Plate";
            this.btnAddPlate.UseVisualStyleBackColor = true;
            this.btnAddPlate.Click += new System.EventHandler(this.btnAddPlate_Click);
            // 
            // PortsBox
            // 
            this.PortsBox.FormattingEnabled = true;
            this.PortsBox.Location = new System.Drawing.Point(22, 120);
            this.PortsBox.Name = "PortsBox";
            this.PortsBox.Size = new System.Drawing.Size(120, 95);
            this.PortsBox.TabIndex = 12;
            // 
            // btnStereoRCA
            // 
            this.btnStereoRCA.BackgroundImage = global::BombThingy.Properties.Resources.StereoRCA;
            this.btnStereoRCA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStereoRCA.Location = new System.Drawing.Point(516, 306);
            this.btnStereoRCA.Name = "btnStereoRCA";
            this.btnStereoRCA.Size = new System.Drawing.Size(64, 79);
            this.btnStereoRCA.TabIndex = 16;
            this.btnStereoRCA.UseVisualStyleBackColor = true;
            this.btnStereoRCA.Click += new System.EventHandler(this.btnStereoRCA_Click);
            // 
            // btnSerial
            // 
            this.btnSerial.BackgroundImage = global::BombThingy.Properties.Resources.Serial;
            this.btnSerial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSerial.Location = new System.Drawing.Point(516, 241);
            this.btnSerial.Name = "btnSerial";
            this.btnSerial.Size = new System.Drawing.Size(91, 59);
            this.btnSerial.TabIndex = 15;
            this.btnSerial.UseVisualStyleBackColor = true;
            this.btnSerial.Click += new System.EventHandler(this.btnSerial_Click);
            // 
            // btnRJ45
            // 
            this.btnRJ45.BackgroundImage = global::BombThingy.Properties.Resources.RJ45;
            this.btnRJ45.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRJ45.Location = new System.Drawing.Point(424, 306);
            this.btnRJ45.Name = "btnRJ45";
            this.btnRJ45.Size = new System.Drawing.Size(59, 49);
            this.btnRJ45.TabIndex = 14;
            this.btnRJ45.UseVisualStyleBackColor = true;
            this.btnRJ45.Click += new System.EventHandler(this.btnRJ45_Click);
            // 
            // btnPS2
            // 
            this.btnPS2.BackgroundImage = global::BombThingy.Properties.Resources.PS2;
            this.btnPS2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPS2.Location = new System.Drawing.Point(424, 238);
            this.btnPS2.Name = "btnPS2";
            this.btnPS2.Size = new System.Drawing.Size(75, 62);
            this.btnPS2.TabIndex = 13;
            this.btnPS2.UseVisualStyleBackColor = true;
            this.btnPS2.Click += new System.EventHandler(this.btnPS2_Click);
            // 
            // btnParallel
            // 
            this.btnParallel.BackgroundImage = global::BombThingy.Properties.Resources.Parrallel;
            this.btnParallel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnParallel.Location = new System.Drawing.Point(424, 178);
            this.btnParallel.Name = "btnParallel";
            this.btnParallel.Size = new System.Drawing.Size(167, 54);
            this.btnParallel.TabIndex = 11;
            this.btnParallel.UseVisualStyleBackColor = true;
            this.btnParallel.Click += new System.EventHandler(this.btnParallel_Click);
            // 
            // btnDVID
            // 
            this.btnDVID.BackgroundImage = global::BombThingy.Properties.Resources.DVID;
            this.btnDVID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDVID.Location = new System.Drawing.Point(424, 120);
            this.btnDVID.Name = "btnDVID";
            this.btnDVID.Size = new System.Drawing.Size(137, 52);
            this.btnDVID.TabIndex = 10;
            this.btnDVID.UseVisualStyleBackColor = true;
            this.btnDVID.Click += new System.EventHandler(this.btnDVID_Click);
            // 
            // IndicatorBox
            // 
            this.IndicatorBox.FormattingEnabled = true;
            this.IndicatorBox.Location = new System.Drawing.Point(22, 238);
            this.IndicatorBox.Name = "IndicatorBox";
            this.IndicatorBox.Size = new System.Drawing.Size(120, 95);
            this.IndicatorBox.TabIndex = 17;
            // 
            // IndicatorTextBox
            // 
            this.IndicatorTextBox.Location = new System.Drawing.Point(204, 216);
            this.IndicatorTextBox.Name = "IndicatorTextBox";
            this.IndicatorTextBox.Size = new System.Drawing.Size(100, 20);
            this.IndicatorTextBox.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Indicator";
            // 
            // btnAddLit
            // 
            this.btnAddLit.Location = new System.Drawing.Point(317, 194);
            this.btnAddLit.Name = "btnAddLit";
            this.btnAddLit.Size = new System.Drawing.Size(75, 23);
            this.btnAddLit.TabIndex = 20;
            this.btnAddLit.Text = "Add Lit";
            this.btnAddLit.UseVisualStyleBackColor = true;
            this.btnAddLit.Click += new System.EventHandler(this.btnAddLit_Click);
            // 
            // btnAddUnlit
            // 
            this.btnAddUnlit.Location = new System.Drawing.Point(317, 241);
            this.btnAddUnlit.Name = "btnAddUnlit";
            this.btnAddUnlit.Size = new System.Drawing.Size(75, 23);
            this.btnAddUnlit.TabIndex = 21;
            this.btnAddUnlit.Text = "Add Unlit";
            this.btnAddUnlit.UseVisualStyleBackColor = true;
            this.btnAddUnlit.Click += new System.EventHandler(this.btnAddUnlit_Click);
            // 
            // InitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddUnlit);
            this.Controls.Add(this.btnAddLit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IndicatorTextBox);
            this.Controls.Add(this.IndicatorBox);
            this.Controls.Add(this.btnStereoRCA);
            this.Controls.Add(this.btnSerial);
            this.Controls.Add(this.btnRJ45);
            this.Controls.Add(this.btnPS2);
            this.Controls.Add(this.PortsBox);
            this.Controls.Add(this.btnParallel);
            this.Controls.Add(this.btnDVID);
            this.Controls.Add(this.btnAddPlate);
            this.Controls.Add(this.PlateLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HolderBox);
            this.Controls.Add(this.BatteryBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.SerialBox);
            this.Controls.Add(this.label1);
            this.Name = "InitForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SerialBox;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BatteryBox;
        private System.Windows.Forms.TextBox HolderBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PlateLabel;
        private System.Windows.Forms.Button btnAddPlate;
        private System.Windows.Forms.Button btnDVID;
        private System.Windows.Forms.Button btnParallel;
        private System.Windows.Forms.ListBox PortsBox;
        private System.Windows.Forms.Button btnPS2;
        private System.Windows.Forms.Button btnRJ45;
        private System.Windows.Forms.Button btnSerial;
        private System.Windows.Forms.Button btnStereoRCA;
        private System.Windows.Forms.ListBox IndicatorBox;
        private System.Windows.Forms.TextBox IndicatorTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddLit;
        private System.Windows.Forms.Button btnAddUnlit;
    }
}