namespace Game_Physics_Assignment_Form
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
            this.components = new System.ComponentModel.Container();
            this.canvas = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.distanceTextbox = new System.Windows.Forms.TextBox();
            this.mass_Sun = new System.Windows.Forms.TextBox();
            this.mass_Planet = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.starComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.planetVelocity = new System.Windows.Forms.TextBox();
            this.secondGameTimer = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.radianTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.Location = new System.Drawing.Point(12, 154);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(611, 347);
            this.canvas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Distance (1-10)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mass of Star(kg)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mass of Planet(kg)";
            // 
            // distanceTextbox
            // 
            this.distanceTextbox.Location = new System.Drawing.Point(144, 100);
            this.distanceTextbox.Name = "distanceTextbox";
            this.distanceTextbox.Size = new System.Drawing.Size(100, 22);
            this.distanceTextbox.TabIndex = 5;
            this.distanceTextbox.Text = "0";
            // 
            // mass_Sun
            // 
            this.mass_Sun.Enabled = false;
            this.mass_Sun.Location = new System.Drawing.Point(144, 44);
            this.mass_Sun.Name = "mass_Sun";
            this.mass_Sun.Size = new System.Drawing.Size(100, 22);
            this.mass_Sun.TabIndex = 6;
            // 
            // mass_Planet
            // 
            this.mass_Planet.Location = new System.Drawing.Point(144, 72);
            this.mass_Planet.Name = "mass_Planet";
            this.mass_Planet.Size = new System.Drawing.Size(100, 22);
            this.mass_Planet.TabIndex = 7;
            this.mass_Planet.Text = "0";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(346, 100);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(511, 97);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // starComboBox
            // 
            this.starComboBox.FormattingEnabled = true;
            this.starComboBox.Location = new System.Drawing.Point(144, 14);
            this.starComboBox.Name = "starComboBox";
            this.starComboBox.Size = new System.Drawing.Size(121, 24);
            this.starComboBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Choose a Star";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Planet Velocity (m/s)";
            // 
            // planetVelocity
            // 
            this.planetVelocity.Location = new System.Drawing.Point(460, 15);
            this.planetVelocity.Name = "planetVelocity";
            this.planetVelocity.Size = new System.Drawing.Size(100, 22);
            this.planetVelocity.TabIndex = 13;
            this.planetVelocity.Text = "0";
            // 
            // secondGameTimer
            // 
            this.secondGameTimer.Interval = 20;
            this.secondGameTimer.Tick += new System.EventHandler(this.secondGameTimer_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Starting Angel (0-2, rad)";
            // 
            // radianTextBox
            // 
            this.radianTextBox.Location = new System.Drawing.Point(460, 46);
            this.radianTextBox.Name = "radianTextBox";
            this.radianTextBox.Size = new System.Drawing.Size(100, 22);
            this.radianTextBox.TabIndex = 15;
            this.radianTextBox.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 513);
            this.Controls.Add(this.radianTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.planetVelocity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.starComboBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.mass_Planet);
            this.Controls.Add(this.mass_Sun);
            this.Controls.Add(this.distanceTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.canvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox distanceTextbox;
        private System.Windows.Forms.TextBox mass_Sun;
        private System.Windows.Forms.TextBox mass_Planet;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.ComboBox starComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox planetVelocity;
        private System.Windows.Forms.Timer secondGameTimer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox radianTextBox;
    }
}

