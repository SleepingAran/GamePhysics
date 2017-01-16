namespace Game_Physics_Lab_3
{
    partial class shuffleboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.muTextBox = new System.Windows.Forms.TextBox();
            this.velocityTextBox = new System.Windows.Forms.TextBox();
            this.massTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Friction Coefficient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Initial Velocity (m/s)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Disk Mass (kg)";
            // 
            // muTextBox
            // 
            this.muTextBox.Location = new System.Drawing.Point(179, 26);
            this.muTextBox.Name = "muTextBox";
            this.muTextBox.Size = new System.Drawing.Size(100, 22);
            this.muTextBox.TabIndex = 3;
            // 
            // velocityTextBox
            // 
            this.velocityTextBox.Location = new System.Drawing.Point(179, 59);
            this.velocityTextBox.Name = "velocityTextBox";
            this.velocityTextBox.Size = new System.Drawing.Size(100, 22);
            this.velocityTextBox.TabIndex = 4;
            // 
            // massTextBox
            // 
            this.massTextBox.Location = new System.Drawing.Point(179, 93);
            this.massTextBox.Name = "massTextBox";
            this.massTextBox.Size = new System.Drawing.Size(100, 22);
            this.massTextBox.TabIndex = 5;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(297, 26);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(85, 50);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(297, 92);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(85, 23);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // drawingPanel
            // 
            this.drawingPanel.Location = new System.Drawing.Point(12, 138);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(370, 196);
            this.drawingPanel.TabIndex = 8;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 50;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // shuffleboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 406);
            this.Controls.Add(this.drawingPanel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.massTextBox);
            this.Controls.Add(this.velocityTextBox);
            this.Controls.Add(this.muTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "shuffleboard";
            this.Text = "Shuffleboard Game";
            this.Load += new System.EventHandler(this.shuffleboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox muTextBox;
        private System.Windows.Forms.TextBox velocityTextBox;
        private System.Windows.Forms.TextBox massTextBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Panel drawingPanel;
        private System.Windows.Forms.Timer gameTimer;
    }
}

