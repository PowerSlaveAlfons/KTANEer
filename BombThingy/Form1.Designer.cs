namespace BombThingy
{
    partial class Form1
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
            this.btnInit = new System.Windows.Forms.Button();
            this.btnPassword = new System.Windows.Forms.Button();
            this.btnMaze = new System.Windows.Forms.Button();
            this.btnSequenceWires = new System.Windows.Forms.Button();
            this.btnComplicatedWires = new System.Windows.Forms.Button();
            this.btnMorse = new System.Windows.Forms.Button();
            this.btnMemory = new System.Windows.Forms.Button();
            this.btnWhosOnFirst = new System.Windows.Forms.Button();
            this.btnSimonSays = new System.Windows.Forms.Button();
            this.btnKeypad = new System.Windows.Forms.Button();
            this.btnButton = new System.Windows.Forms.Button();
            this.btnWires = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(358, 415);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(75, 23);
            this.btnInit.TabIndex = 0;
            this.btnInit.Text = "Init";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // btnPassword
            // 
            this.btnPassword.BackgroundImage = global::BombThingy.Properties.Resources.Password;
            this.btnPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPassword.Location = new System.Drawing.Point(204, 100);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnPassword.Size = new System.Drawing.Size(86, 82);
            this.btnPassword.TabIndex = 11;
            this.btnPassword.UseVisualStyleBackColor = true;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // btnMaze
            // 
            this.btnMaze.BackgroundImage = global::BombThingy.Properties.Resources.Maze;
            this.btnMaze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMaze.Location = new System.Drawing.Point(106, 100);
            this.btnMaze.Name = "btnMaze";
            this.btnMaze.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnMaze.Size = new System.Drawing.Size(92, 82);
            this.btnMaze.TabIndex = 10;
            this.btnMaze.UseVisualStyleBackColor = true;
            this.btnMaze.Click += new System.EventHandler(this.btnMaze_Click);
            // 
            // btnSequenceWires
            // 
            this.btnSequenceWires.BackgroundImage = global::BombThingy.Properties.Resources.SequenceWires;
            this.btnSequenceWires.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSequenceWires.Location = new System.Drawing.Point(12, 100);
            this.btnSequenceWires.Name = "btnSequenceWires";
            this.btnSequenceWires.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSequenceWires.Size = new System.Drawing.Size(86, 82);
            this.btnSequenceWires.TabIndex = 9;
            this.btnSequenceWires.UseVisualStyleBackColor = true;
            this.btnSequenceWires.Click += new System.EventHandler(this.btnSequenceWires_Click);
            // 
            // btnComplicatedWires
            // 
            this.btnComplicatedWires.BackgroundImage = global::BombThingy.Properties.Resources.ComplicatedWires;
            this.btnComplicatedWires.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnComplicatedWires.Location = new System.Drawing.Point(664, 12);
            this.btnComplicatedWires.Name = "btnComplicatedWires";
            this.btnComplicatedWires.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnComplicatedWires.Size = new System.Drawing.Size(86, 82);
            this.btnComplicatedWires.TabIndex = 8;
            this.btnComplicatedWires.UseVisualStyleBackColor = true;
            this.btnComplicatedWires.Click += new System.EventHandler(this.btnComplicatedWires_Click);
            // 
            // btnMorse
            // 
            this.btnMorse.BackgroundImage = global::BombThingy.Properties.Resources.Morse;
            this.btnMorse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMorse.Location = new System.Drawing.Point(572, 12);
            this.btnMorse.Name = "btnMorse";
            this.btnMorse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnMorse.Size = new System.Drawing.Size(86, 82);
            this.btnMorse.TabIndex = 7;
            this.btnMorse.UseVisualStyleBackColor = true;
            this.btnMorse.Click += new System.EventHandler(this.btnMorse_Click);
            // 
            // btnMemory
            // 
            this.btnMemory.BackgroundImage = global::BombThingy.Properties.Resources.Memory;
            this.btnMemory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMemory.Location = new System.Drawing.Point(480, 12);
            this.btnMemory.Name = "btnMemory";
            this.btnMemory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnMemory.Size = new System.Drawing.Size(86, 82);
            this.btnMemory.TabIndex = 6;
            this.btnMemory.UseVisualStyleBackColor = true;
            this.btnMemory.Click += new System.EventHandler(this.btnMemory_Click);
            // 
            // btnWhosOnFirst
            // 
            this.btnWhosOnFirst.BackgroundImage = global::BombThingy.Properties.Resources.WhosOnFirst;
            this.btnWhosOnFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWhosOnFirst.Location = new System.Drawing.Point(388, 12);
            this.btnWhosOnFirst.Name = "btnWhosOnFirst";
            this.btnWhosOnFirst.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnWhosOnFirst.Size = new System.Drawing.Size(86, 82);
            this.btnWhosOnFirst.TabIndex = 5;
            this.btnWhosOnFirst.UseVisualStyleBackColor = true;
            this.btnWhosOnFirst.Click += new System.EventHandler(this.btnWhosOnFirst_Click);
            // 
            // btnSimonSays
            // 
            this.btnSimonSays.BackgroundImage = global::BombThingy.Properties.Resources.SimonSays;
            this.btnSimonSays.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSimonSays.Location = new System.Drawing.Point(296, 12);
            this.btnSimonSays.Name = "btnSimonSays";
            this.btnSimonSays.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSimonSays.Size = new System.Drawing.Size(86, 82);
            this.btnSimonSays.TabIndex = 4;
            this.btnSimonSays.UseVisualStyleBackColor = true;
            this.btnSimonSays.Click += new System.EventHandler(this.btnSimonSays_Click);
            // 
            // btnKeypad
            // 
            this.btnKeypad.BackgroundImage = global::BombThingy.Properties.Resources.Keypad;
            this.btnKeypad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKeypad.Location = new System.Drawing.Point(204, 12);
            this.btnKeypad.Name = "btnKeypad";
            this.btnKeypad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnKeypad.Size = new System.Drawing.Size(86, 82);
            this.btnKeypad.TabIndex = 3;
            this.btnKeypad.UseVisualStyleBackColor = true;
            this.btnKeypad.Click += new System.EventHandler(this.btnKeypad_Click);
            // 
            // btnButton
            // 
            this.btnButton.BackgroundImage = global::BombThingy.Properties.Resources.Button;
            this.btnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnButton.Location = new System.Drawing.Point(106, 12);
            this.btnButton.Name = "btnButton";
            this.btnButton.Size = new System.Drawing.Size(92, 82);
            this.btnButton.TabIndex = 2;
            this.btnButton.UseVisualStyleBackColor = true;
            this.btnButton.Click += new System.EventHandler(this.btnButton_Click);
            // 
            // btnWires
            // 
            this.btnWires.BackgroundImage = global::BombThingy.Properties.Resources.Wires;
            this.btnWires.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWires.Location = new System.Drawing.Point(12, 12);
            this.btnWires.Name = "btnWires";
            this.btnWires.Size = new System.Drawing.Size(88, 82);
            this.btnWires.TabIndex = 1;
            this.btnWires.UseVisualStyleBackColor = true;
            this.btnWires.Click += new System.EventHandler(this.btnWires_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.btnMaze);
            this.Controls.Add(this.btnSequenceWires);
            this.Controls.Add(this.btnComplicatedWires);
            this.Controls.Add(this.btnMorse);
            this.Controls.Add(this.btnMemory);
            this.Controls.Add(this.btnWhosOnFirst);
            this.Controls.Add(this.btnSimonSays);
            this.Controls.Add(this.btnKeypad);
            this.Controls.Add(this.btnButton);
            this.Controls.Add(this.btnWires);
            this.Controls.Add(this.btnInit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Button btnWires;
        private System.Windows.Forms.Button btnButton;
        private System.Windows.Forms.Button btnKeypad;
        private System.Windows.Forms.Button btnSimonSays;
        private System.Windows.Forms.Button btnWhosOnFirst;
        private System.Windows.Forms.Button btnMemory;
        private System.Windows.Forms.Button btnMorse;
        private System.Windows.Forms.Button btnComplicatedWires;
        private System.Windows.Forms.Button btnSequenceWires;
        private System.Windows.Forms.Button btnMaze;
        private System.Windows.Forms.Button btnPassword;
    }
}

