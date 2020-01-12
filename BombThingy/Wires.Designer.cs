namespace KTANEer
{
    partial class Wires
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
            this.btnRed = new System.Windows.Forms.Button();
            this.btnWhite = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.WireBox = new System.Windows.Forms.ListBox();
            this.btnSolve = new System.Windows.Forms.Button();
            this.OutputBox = new System.Windows.Forms.ListBox();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnBlack = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRed
            // 
            this.btnRed.Location = new System.Drawing.Point(436, 13);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(75, 23);
            this.btnRed.TabIndex = 0;
            this.btnRed.Text = "Red";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnWhite
            // 
            this.btnWhite.Location = new System.Drawing.Point(436, 42);
            this.btnWhite.Name = "btnWhite";
            this.btnWhite.Size = new System.Drawing.Size(75, 23);
            this.btnWhite.TabIndex = 1;
            this.btnWhite.TabStop = false;
            this.btnWhite.Text = "White";
            this.btnWhite.UseVisualStyleBackColor = true;
            this.btnWhite.Click += new System.EventHandler(this.btnWhite_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.Location = new System.Drawing.Point(436, 71);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(75, 23);
            this.btnBlue.TabIndex = 2;
            this.btnBlue.Text = "Blue";
            this.btnBlue.UseVisualStyleBackColor = true;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // WireBox
            // 
            this.WireBox.FormattingEnabled = true;
            this.WireBox.Location = new System.Drawing.Point(12, 220);
            this.WireBox.Name = "WireBox";
            this.WireBox.Size = new System.Drawing.Size(120, 95);
            this.WireBox.TabIndex = 3;
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(329, 415);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(75, 23);
            this.btnSolve.TabIndex = 4;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // OutputBox
            // 
            this.OutputBox.FormattingEnabled = true;
            this.OutputBox.Location = new System.Drawing.Point(601, 220);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(120, 95);
            this.OutputBox.TabIndex = 5;
            // 
            // btnYellow
            // 
            this.btnYellow.Location = new System.Drawing.Point(436, 100);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(75, 23);
            this.btnYellow.TabIndex = 6;
            this.btnYellow.Text = "Yellow";
            this.btnYellow.UseVisualStyleBackColor = true;
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            // 
            // btnBlack
            // 
            this.btnBlack.Location = new System.Drawing.Point(436, 129);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(75, 23);
            this.btnBlack.TabIndex = 7;
            this.btnBlack.Text = "Black";
            this.btnBlack.UseVisualStyleBackColor = true;
            this.btnBlack.Click += new System.EventHandler(this.btnBlack_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 13);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Wires
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnBlack);
            this.Controls.Add(this.btnYellow);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.WireBox);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnWhite);
            this.Controls.Add(this.btnRed);
            this.Name = "Wires";
            this.Text = "Wires";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnWhite;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.ListBox WireBox;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.ListBox OutputBox;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnBlack;
        private System.Windows.Forms.Button btnReset;
    }
}