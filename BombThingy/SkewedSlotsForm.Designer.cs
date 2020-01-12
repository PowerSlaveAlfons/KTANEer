namespace BombThingy
{
    partial class SkewedSlotsForm
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
            this.OutputBox3 = new System.Windows.Forms.TextBox();
            this.OutputBox2 = new System.Windows.Forms.TextBox();
            this.OutputBox1 = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.InputBox1 = new System.Windows.Forms.MaskedTextBox();
            this.InputBox3 = new System.Windows.Forms.MaskedTextBox();
            this.InputBox2 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // OutputBox3
            // 
            this.OutputBox3.Enabled = false;
            this.OutputBox3.Location = new System.Drawing.Point(176, 152);
            this.OutputBox3.Name = "OutputBox3";
            this.OutputBox3.Size = new System.Drawing.Size(25, 20);
            this.OutputBox3.TabIndex = 5;
            // 
            // OutputBox2
            // 
            this.OutputBox2.Enabled = false;
            this.OutputBox2.Location = new System.Drawing.Point(145, 152);
            this.OutputBox2.Name = "OutputBox2";
            this.OutputBox2.Size = new System.Drawing.Size(25, 20);
            this.OutputBox2.TabIndex = 4;
            // 
            // OutputBox1
            // 
            this.OutputBox1.Enabled = false;
            this.OutputBox1.Location = new System.Drawing.Point(114, 152);
            this.OutputBox1.Name = "OutputBox1";
            this.OutputBox1.Size = new System.Drawing.Size(25, 20);
            this.OutputBox1.TabIndex = 3;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(55, 133);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(31, 13);
            this.lblInput.TabIndex = 6;
            this.lblInput.Text = "Input";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(55, 155);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(39, 13);
            this.lblOutput.TabIndex = 7;
            this.lblOutput.Text = "Output";
            // 
            // InputBox1
            // 
            this.InputBox1.Location = new System.Drawing.Point(114, 126);
            this.InputBox1.Mask = "0";
            this.InputBox1.Name = "InputBox1";
            this.InputBox1.Size = new System.Drawing.Size(25, 20);
            this.InputBox1.TabIndex = 1;
            this.InputBox1.ValidatingType = typeof(int);
            this.InputBox1.TextChanged += new System.EventHandler(this.InputBox3_TextChanged);
            // 
            // InputBox3
            // 
            this.InputBox3.Location = new System.Drawing.Point(176, 126);
            this.InputBox3.Mask = "0";
            this.InputBox3.Name = "InputBox3";
            this.InputBox3.Size = new System.Drawing.Size(25, 20);
            this.InputBox3.TabIndex = 3;
            this.InputBox3.ValidatingType = typeof(int);
            this.InputBox3.TextChanged += new System.EventHandler(this.InputBox3_TextChanged);
            // 
            // InputBox2
            // 
            this.InputBox2.Location = new System.Drawing.Point(145, 126);
            this.InputBox2.Mask = "0";
            this.InputBox2.Name = "InputBox2";
            this.InputBox2.Size = new System.Drawing.Size(25, 20);
            this.InputBox2.TabIndex = 2;
            this.InputBox2.ValidatingType = typeof(int);
            this.InputBox2.TextChanged += new System.EventHandler(this.InputBox3_TextChanged);
            // 
            // SkewedSlotsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InputBox2);
            this.Controls.Add(this.InputBox3);
            this.Controls.Add(this.InputBox1);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.OutputBox3);
            this.Controls.Add(this.OutputBox2);
            this.Controls.Add(this.OutputBox1);
            this.Name = "SkewedSlotsForm";
            this.Text = "SkewedSlotsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox OutputBox3;
        private System.Windows.Forms.TextBox OutputBox2;
        private System.Windows.Forms.TextBox OutputBox1;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.MaskedTextBox InputBox1;
        private System.Windows.Forms.MaskedTextBox InputBox3;
        private System.Windows.Forms.MaskedTextBox InputBox2;
    }
}