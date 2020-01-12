namespace KTANEer
{
    partial class MorseForm
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
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnDash = new System.Windows.Forms.Button();
            this.btnSpace = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SolutionBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(688, 12);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(100, 20);
            this.OutputBox.TabIndex = 0;
            // 
            // btnDot
            // 
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.Location = new System.Drawing.Point(127, 184);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(92, 74);
            this.btnDot.TabIndex = 1;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btnDash
            // 
            this.btnDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDash.Location = new System.Drawing.Point(225, 184);
            this.btnDash.Name = "btnDash";
            this.btnDash.Size = new System.Drawing.Size(92, 74);
            this.btnDash.TabIndex = 2;
            this.btnDash.Text = "-";
            this.btnDash.UseVisualStyleBackColor = true;
            this.btnDash.Click += new System.EventHandler(this.btnDash_Click);
            // 
            // btnSpace
            // 
            this.btnSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpace.Location = new System.Drawing.Point(323, 184);
            this.btnSpace.Name = "btnSpace";
            this.btnSpace.Size = new System.Drawing.Size(92, 74);
            this.btnSpace.TabIndex = 3;
            this.btnSpace.UseVisualStyleBackColor = true;
            this.btnSpace.Click += new System.EventHandler(this.btnSpace_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(688, 38);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear Word";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // SolutionBox
            // 
            this.SolutionBox.Location = new System.Drawing.Point(323, 281);
            this.SolutionBox.Name = "SolutionBox";
            this.SolutionBox.Size = new System.Drawing.Size(100, 20);
            this.SolutionBox.TabIndex = 5;
            // 
            // MorseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SolutionBox);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSpace);
            this.Controls.Add(this.btnDash);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.OutputBox);
            this.Name = "MorseForm";
            this.Text = "MorseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnDash;
        private System.Windows.Forms.Button btnSpace;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox SolutionBox;
    }
}