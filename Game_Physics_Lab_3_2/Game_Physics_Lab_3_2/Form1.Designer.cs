namespace Game_Physics_Lab_3_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fireButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.vxTextBox = new System.Windows.Forms.TextBox();
            this.vzTextBox = new System.Windows.Forms.TextBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.drawingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Initial Horizontal Velocity (m/s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Initial Vertical Velocity (m/s)";
            // 
            // fireButton
            // 
            this.fireButton.Location = new System.Drawing.Point(70, 119);
            this.fireButton.Name = "fireButton";
            this.fireButton.Size = new System.Drawing.Size(75, 50);
            this.fireButton.TabIndex = 2;
            this.fireButton.Text = "Fire";
            this.fireButton.UseVisualStyleBackColor = true;
            this.fireButton.Click += new System.EventHandler(this.fireButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(70, 201);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 48);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // drawingPanel
            // 
            this.drawingPanel.Controls.Add(this.pictureBox1);
            this.drawingPanel.Location = new System.Drawing.Point(180, 119);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(359, 236);
            this.drawingPanel.TabIndex = 4;
            // 
            // vxTextBox
            // 
            this.vxTextBox.Location = new System.Drawing.Point(266, 34);
            this.vxTextBox.Name = "vxTextBox";
            this.vxTextBox.Size = new System.Drawing.Size(100, 22);
            this.vxTextBox.TabIndex = 5;
            // 
            // vzTextBox
            // 
            this.vzTextBox.Location = new System.Drawing.Point(266, 68);
            this.vzTextBox.Name = "vzTextBox";
            this.vzTextBox.Size = new System.Drawing.Size(100, 22);
            this.vzTextBox.TabIndex = 6;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 50;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 367);
            this.Controls.Add(this.vzTextBox);
            this.Controls.Add(this.vxTextBox);
            this.Controls.Add(this.drawingPanel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.fireButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.drawingPanel.ResumeLayout(false);
            this.drawingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button fireButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Panel drawingPanel;
        private System.Windows.Forms.TextBox vxTextBox;
        private System.Windows.Forms.TextBox vzTextBox;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

