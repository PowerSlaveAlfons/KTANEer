namespace BombThingy
{
    partial class ButtonForm
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
            this.ButtonStatusBox = new System.Windows.Forms.ListBox();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnWhite = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            this.btnDetonate = new System.Windows.Forms.Button();
            this.btnHold = new System.Windows.Forms.Button();
            this.btnPress = new System.Windows.Forms.Button();
            this.btnBlueStrip = new System.Windows.Forms.Button();
            this.btnWhiteStrip = new System.Windows.Forms.Button();
            this.btnYellowStrip = new System.Windows.Forms.Button();
            this.btnOtherStrip = new System.Windows.Forms.Button();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonStatusBox
            // 
            this.ButtonStatusBox.FormattingEnabled = true;
            this.ButtonStatusBox.Location = new System.Drawing.Point(12, 194);
            this.ButtonStatusBox.Name = "ButtonStatusBox";
            this.ButtonStatusBox.Size = new System.Drawing.Size(120, 95);
            this.ButtonStatusBox.TabIndex = 0;
            // 
            // btnBlue
            // 
            this.btnBlue.Location = new System.Drawing.Point(284, 31);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(75, 23);
            this.btnBlue.TabIndex = 1;
            this.btnBlue.Text = "Blue";
            this.btnBlue.UseVisualStyleBackColor = true;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnWhite
            // 
            this.btnWhite.Location = new System.Drawing.Point(284, 61);
            this.btnWhite.Name = "btnWhite";
            this.btnWhite.Size = new System.Drawing.Size(75, 23);
            this.btnWhite.TabIndex = 2;
            this.btnWhite.Text = "White";
            this.btnWhite.UseVisualStyleBackColor = true;
            this.btnWhite.Click += new System.EventHandler(this.btnWhite_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.Location = new System.Drawing.Point(284, 91);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(75, 23);
            this.btnYellow.TabIndex = 3;
            this.btnYellow.Text = "Yellow";
            this.btnYellow.UseVisualStyleBackColor = true;
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            // 
            // btnRed
            // 
            this.btnRed.Location = new System.Drawing.Point(284, 121);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(75, 23);
            this.btnRed.TabIndex = 4;
            this.btnRed.Text = "Red";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.Location = new System.Drawing.Point(485, 30);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(75, 23);
            this.btnAbort.TabIndex = 5;
            this.btnAbort.Text = "Abort";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // btnDetonate
            // 
            this.btnDetonate.Location = new System.Drawing.Point(485, 59);
            this.btnDetonate.Name = "btnDetonate";
            this.btnDetonate.Size = new System.Drawing.Size(75, 23);
            this.btnDetonate.TabIndex = 6;
            this.btnDetonate.Text = "Detonate";
            this.btnDetonate.UseVisualStyleBackColor = true;
            this.btnDetonate.Click += new System.EventHandler(this.btnDetonate_Click);
            // 
            // btnHold
            // 
            this.btnHold.Location = new System.Drawing.Point(485, 88);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(75, 23);
            this.btnHold.TabIndex = 7;
            this.btnHold.Text = "Hold";
            this.btnHold.UseVisualStyleBackColor = true;
            this.btnHold.Click += new System.EventHandler(this.btnHold_Click);
            // 
            // btnPress
            // 
            this.btnPress.Location = new System.Drawing.Point(485, 117);
            this.btnPress.Name = "btnPress";
            this.btnPress.Size = new System.Drawing.Size(75, 23);
            this.btnPress.TabIndex = 8;
            this.btnPress.Text = "Press";
            this.btnPress.UseVisualStyleBackColor = true;
            this.btnPress.Click += new System.EventHandler(this.btnPress_Click);
            // 
            // btnBlueStrip
            // 
            this.btnBlueStrip.Location = new System.Drawing.Point(631, 317);
            this.btnBlueStrip.Name = "btnBlueStrip";
            this.btnBlueStrip.Size = new System.Drawing.Size(75, 23);
            this.btnBlueStrip.TabIndex = 10;
            this.btnBlueStrip.Text = "Blue Strip";
            this.btnBlueStrip.UseVisualStyleBackColor = true;
            this.btnBlueStrip.Visible = false;
            this.btnBlueStrip.Click += new System.EventHandler(this.btnBlueStrip_Click);
            // 
            // btnWhiteStrip
            // 
            this.btnWhiteStrip.Location = new System.Drawing.Point(631, 347);
            this.btnWhiteStrip.Name = "btnWhiteStrip";
            this.btnWhiteStrip.Size = new System.Drawing.Size(75, 23);
            this.btnWhiteStrip.TabIndex = 11;
            this.btnWhiteStrip.Text = "White Strip";
            this.btnWhiteStrip.UseVisualStyleBackColor = true;
            this.btnWhiteStrip.Visible = false;
            this.btnWhiteStrip.Click += new System.EventHandler(this.btnWhiteStrip_Click);
            // 
            // btnYellowStrip
            // 
            this.btnYellowStrip.Location = new System.Drawing.Point(631, 377);
            this.btnYellowStrip.Name = "btnYellowStrip";
            this.btnYellowStrip.Size = new System.Drawing.Size(75, 23);
            this.btnYellowStrip.TabIndex = 12;
            this.btnYellowStrip.Text = "Yellow Strip";
            this.btnYellowStrip.UseVisualStyleBackColor = true;
            this.btnYellowStrip.Visible = false;
            this.btnYellowStrip.Click += new System.EventHandler(this.btnYellowStrip_Click);
            // 
            // btnOtherStrip
            // 
            this.btnOtherStrip.Location = new System.Drawing.Point(631, 407);
            this.btnOtherStrip.Name = "btnOtherStrip";
            this.btnOtherStrip.Size = new System.Drawing.Size(75, 23);
            this.btnOtherStrip.TabIndex = 13;
            this.btnOtherStrip.Text = "Other Color";
            this.btnOtherStrip.UseVisualStyleBackColor = true;
            this.btnOtherStrip.Visible = false;
            this.btnOtherStrip.Click += new System.EventHandler(this.btnOtherStrip_Click);
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(511, 174);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(277, 115);
            this.OutputBox.TabIndex = 14;
            // 
            // ButtonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.btnOtherStrip);
            this.Controls.Add(this.btnYellowStrip);
            this.Controls.Add(this.btnWhiteStrip);
            this.Controls.Add(this.btnBlueStrip);
            this.Controls.Add(this.btnPress);
            this.Controls.Add(this.btnHold);
            this.Controls.Add(this.btnDetonate);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.btnYellow);
            this.Controls.Add(this.btnWhite);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.ButtonStatusBox);
            this.Name = "ButtonForm";
            this.Text = "ButtonForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ButtonStatusBox;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnWhite;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.Button btnDetonate;
        private System.Windows.Forms.Button btnHold;
        private System.Windows.Forms.Button btnPress;
        private System.Windows.Forms.Button btnBlueStrip;
        private System.Windows.Forms.Button btnWhiteStrip;
        private System.Windows.Forms.Button btnYellowStrip;
        private System.Windows.Forms.Button btnOtherStrip;
        private System.Windows.Forms.TextBox OutputBox;
    }
}