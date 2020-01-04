namespace BombThingy
{
    partial class ComplicatedWiresForm
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
            this.BoxRed = new System.Windows.Forms.CheckBox();
            this.BoxBlue = new System.Windows.Forms.CheckBox();
            this.BoxStar = new System.Windows.Forms.CheckBox();
            this.BoxLED = new System.Windows.Forms.CheckBox();
            this.SolutionBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BoxRed
            // 
            this.BoxRed.AutoSize = true;
            this.BoxRed.Location = new System.Drawing.Point(334, 83);
            this.BoxRed.Name = "BoxRed";
            this.BoxRed.Size = new System.Drawing.Size(46, 17);
            this.BoxRed.TabIndex = 0;
            this.BoxRed.Text = "Red";
            this.BoxRed.UseVisualStyleBackColor = true;
            this.BoxRed.CheckedChanged += new System.EventHandler(this.BoxRed_CheckedChanged);
            // 
            // BoxBlue
            // 
            this.BoxBlue.AutoSize = true;
            this.BoxBlue.Location = new System.Drawing.Point(334, 106);
            this.BoxBlue.Name = "BoxBlue";
            this.BoxBlue.Size = new System.Drawing.Size(47, 17);
            this.BoxBlue.TabIndex = 1;
            this.BoxBlue.Text = "Blue";
            this.BoxBlue.UseVisualStyleBackColor = true;
            this.BoxBlue.CheckedChanged += new System.EventHandler(this.BoxBlue_CheckedChanged);
            // 
            // BoxStar
            // 
            this.BoxStar.AutoSize = true;
            this.BoxStar.Location = new System.Drawing.Point(334, 130);
            this.BoxStar.Name = "BoxStar";
            this.BoxStar.Size = new System.Drawing.Size(45, 17);
            this.BoxStar.TabIndex = 2;
            this.BoxStar.Text = "Star";
            this.BoxStar.UseVisualStyleBackColor = true;
            this.BoxStar.CheckedChanged += new System.EventHandler(this.BoxStar_CheckedChanged);
            // 
            // BoxLED
            // 
            this.BoxLED.AutoSize = true;
            this.BoxLED.Location = new System.Drawing.Point(334, 154);
            this.BoxLED.Name = "BoxLED";
            this.BoxLED.Size = new System.Drawing.Size(47, 17);
            this.BoxLED.TabIndex = 3;
            this.BoxLED.Text = "LED";
            this.BoxLED.UseVisualStyleBackColor = true;
            this.BoxLED.CheckedChanged += new System.EventHandler(this.BoxLED_CheckedChanged);
            // 
            // SolutionBox
            // 
            this.SolutionBox.Location = new System.Drawing.Point(298, 216);
            this.SolutionBox.Name = "SolutionBox";
            this.SolutionBox.Size = new System.Drawing.Size(100, 20);
            this.SolutionBox.TabIndex = 4;
            // 
            // ComplicatedWiresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SolutionBox);
            this.Controls.Add(this.BoxLED);
            this.Controls.Add(this.BoxStar);
            this.Controls.Add(this.BoxBlue);
            this.Controls.Add(this.BoxRed);
            this.Name = "ComplicatedWiresForm";
            this.Text = "ComplicatedWiresForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox BoxRed;
        private System.Windows.Forms.CheckBox BoxBlue;
        private System.Windows.Forms.CheckBox BoxStar;
        private System.Windows.Forms.CheckBox BoxLED;
        private System.Windows.Forms.TextBox SolutionBox;
    }
}