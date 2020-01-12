namespace KTANEer
{
    partial class SequenceWiresForm
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
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnBlack = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRed
            // 
            this.btnRed.Location = new System.Drawing.Point(127, 202);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(105, 85);
            this.btnRed.TabIndex = 0;
            this.btnRed.Text = "Red";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.Location = new System.Drawing.Point(238, 202);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(105, 85);
            this.btnBlue.TabIndex = 1;
            this.btnBlue.Text = "Blue";
            this.btnBlue.UseVisualStyleBackColor = true;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnBlack
            // 
            this.btnBlack.Location = new System.Drawing.Point(349, 202);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(105, 85);
            this.btnBlack.TabIndex = 2;
            this.btnBlack.Text = "Black";
            this.btnBlack.UseVisualStyleBackColor = true;
            this.btnBlack.Click += new System.EventHandler(this.btnBlack_Click);
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(127, 302);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(105, 85);
            this.btnA.TabIndex = 3;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Visible = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(238, 302);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(105, 85);
            this.btnB.TabIndex = 4;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Visible = false;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(349, 302);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(105, 85);
            this.btnC.TabIndex = 5;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Visible = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(238, 127);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(100, 20);
            this.OutputBox.TabIndex = 6;
            // 
            // SequenceWiresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.btnBlack);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnRed);
            this.Name = "SequenceWiresForm";
            this.Text = "SequenceWiresForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnBlack;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.TextBox OutputBox;
    }
}